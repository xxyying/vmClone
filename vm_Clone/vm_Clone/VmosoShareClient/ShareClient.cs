using System;
using System.IO;
using System.Collections.Generic;
using VmosoApiClient.Api;
using VmosoApiClient.Client;
using VmosoApiClient.Model;
using log4net;
using System.Drawing;
using VmosoAHAClient;

namespace VmosoShareClient
{
    public class ShareClient
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public String CUSTOM_SPACE_TAG = "custom";
        public String CORPORATE_SPACE = "sys:folder:corporate";
        public String CUSTOM_SPACE = "sys:folder:custom";
        public String PUBLIC_SPACE = "sys:folder:public";
        public String MUTUAL_SPACE = "sys:folder:mutual";

        private VmosoSession session;

        private ListPageRecord pager;
        private SearchStreamOptionsRecord options;

        public ShareClient(VmosoSession session)
        {
            log.Debug("Creating ShareClient for host/userKey " + session.Host + "/" + session.UserKey);
            this.session = session;
        }

        public List<ShareSpace> GetRootSpaces()
        {
            log.Debug("Getting root spaces...");
            SpaceApi spaceApi = new SpaceApi(session.GetApiClient());

            GetSpacesResult getSpacesResult = spaceApi.GetSpaces(CUSTOM_SPACE_TAG);
            if (getSpacesResult.Hdr.Rc == 0)
            {
                List<SpaceV2Record> spaces = getSpacesResult.Folders;
                List<ShareSpace> shareSpaces = new List<ShareSpace>();
                foreach (SpaceV2Record space in spaces)
                {
                    if (space.NameKey.Equals(CORPORATE_SPACE) || space.NameKey.Equals(CUSTOM_SPACE) || space.NameKey.Equals(MUTUAL_SPACE) || space.NameKey.Equals(PUBLIC_SPACE))
                    {
                        ShareSpace shareSpace = new ShareSpace(space.Key, space.DisplayName, space);
                        shareSpaces.Insert(0,shareSpace);
                    }
                }

                return shareSpaces;
            }
            else
            {
                throw new Exception("Vmoso error getting root spaces. Rc=" + getSpacesResult.Hdr.Rc);
            }
        }

        public List<ShareSpace> getSubSpaces(ShareSpace parentSpace)
        {
            List<ShareSpace> shareSubSpaces = new List<ShareSpace>();
            SpaceApi spaceApi = new SpaceApi(session.GetApiClient());
            PaginationRecord pg = new PaginationRecord();
            pg.Limit = 10;
            pg.Page = "F";

            FolderOptionsRecord options = new FolderOptionsRecord();
            options.SortDir = "DESC";

            GetSubSpacesResult subSpacesResult = spaceApi.GetSubSpaces(parentSpace.Key, pg.ToJson(), parentSpace.Key, options.ToJson(), null, "myvmoso");
            if (subSpacesResult.Hdr.Rc == 0)
            {
                List<SpaceV2Record> subSpaces = subSpacesResult.Folders;
                foreach (SpaceV2Record subSpace in subSpaces)
                {
                    ShareSpace childSpace = new ShareSpace(subSpace.Key, subSpace.DisplayName, subSpace);
                    shareSubSpaces.Add(childSpace);
                }
            }
            else
            {
                log.Error("Error accesing subspaces for parent space " + parentSpace.Name);
                
            }
            return shareSubSpaces;
        }

        public ShareFileItem createFile(ShareFileItem item, List<String> spaceKeys)
        {
            return createFile(item.FileInfo, item.Title, item.Description, spaceKeys, item.GetIcon());          
        }

        public ShareFileItem createFile(FileInfo fileInfo, String title, String description , List<String> spaceKeys, Bitmap icon)
        {
            try
            {
                FileRecord fileRecord = VmosoFileUtils.uploadFile(session, fileInfo.FullName, title, description, true);

                if (spaceKeys != null)
                {
                    SpaceApi spaceApi = new SpaceApi(session.GetApiClient());
                    ShareObjectInput shareInput = new ShareObjectInput(null, spaceKeys, null);
                    ShareObjectResult shareResult = spaceApi.ShareObject(fileRecord.Key, shareInput);
                    if (shareResult.Hdr.Rc == 0)
                    {
                        FileApi fileApi = new FileApi(session.GetApiClient());
                        ViewFileResult viewFileResult = fileApi.ViewFile(fileRecord.Key);
                        if (viewFileResult.Hdr.Rc == 0)
                        {
                            fileRecord = viewFileResult.File;
                        }
                        else
                        {
                            throw new Exception("Vmoso error getting created link. Rc=" + viewFileResult.Hdr.Rc);
                        }
                    }
                    else
                    {
                        throw new Exception("Vmoso error sharing link. Rc=" + shareResult.Hdr.Rc);
                    }
                }

                ShareFileItem item = new ShareFileItem(fileRecord.Name, fileRecord.Description);
                item.Key = fileRecord.Key;
                item.FileInfo = fileInfo;
                item.SetIcon(icon);
                item.Record = fileRecord;

                List<ShareSpace> itemSpaces = new List<ShareSpace>();
                foreach (DisplayRecord spaceDisplayRecord in fileRecord.Destinations)
                {
                    ShareSpace space = new ShareSpace(spaceDisplayRecord.Key, spaceDisplayRecord.DisplayName, null);
                    itemSpaces.Add(space);
                }

                item.Spaces = itemSpaces;
                return item;

            } catch(Exception ex)
            {
                throw new Exception("Error creating file", ex);
            }
        }

        public ShareFileItem uploadNewFileVersion(ShareFileItem shareFileItem)
        {
            try
            {
                FileRecord fileRecord = VmosoFileUtils.uploadNewVersion(session, shareFileItem.Key, shareFileItem.FileInfo.FullName);

                shareFileItem.Record = fileRecord;

                return shareFileItem;

            }
            catch (Exception ex)
            {
                throw new Exception("Error creating file", ex);
            }
        }

        public ShareFileItem findFile(ShareFileItem shareFileItem)
        {
            try
            {
                AHAItem foundItem = null;
                AHAClient ahaClient = new AHAClient(session);
                if (shareFileItem.FileInfo != null)
                {
                    List<AHAItem> items = ahaClient.Search("&" + shareFileItem.FileInfo.Name);
                    if (items.Count == 1)
                    {
                        foundItem = items[0];
                    }
                }
                if(foundItem == null)
                {
                    if(shareFileItem.FileInfo != null)
                    {
                        if (!shareFileItem.FileInfo.Name.Equals(shareFileItem.Title))
                        {
                            List<AHAItem> items = ahaClient.Search("&" + shareFileItem.Title);
                            if (items.Count == 1)
                            {
                                foundItem = items[0];
                            }
                        }
                    } else
                    {
                        List<AHAItem> items = ahaClient.Search("&" + shareFileItem.Title);
                        if (items.Count == 1)
                        {
                            foundItem = items[0];
                        }
                    }
                }

                if (foundItem != null)
                {
                    FileApi fileApi = new FileApi(session.GetApiClient());
                    ViewFileResult viewFileResult = fileApi.ViewFile(foundItem.Key);
                    if (viewFileResult.Hdr.Rc == 0)
                    {
                        FileRecord fileRecord = viewFileResult.File;

                        ShareFileItem newShareFileItem = new ShareFileItem(fileRecord.Name, fileRecord.Description);
                        newShareFileItem.Key = fileRecord.Key;
                        newShareFileItem.FileInfo = shareFileItem.FileInfo;
                        newShareFileItem.SetIcon(shareFileItem.GetIcon());
                        newShareFileItem.Record = fileRecord;

                        List<ShareSpace> itemSpaces = new List<ShareSpace>();
                        foreach (DisplayRecord spaceDisplayRecord in fileRecord.Destinations)
                        {
                            ShareSpace space = new ShareSpace(spaceDisplayRecord.Key, spaceDisplayRecord.DisplayName, null);
                            itemSpaces.Add(space);
                        }

                        newShareFileItem.Spaces = itemSpaces;
                        return newShareFileItem;
                    }
                    else
                    {
                        return null;
                    }
                } else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating file", ex);
            }
        }

        public ShareFileItem updateFile(String key, FileInfo fileInfo, String title, String description, List<String> spaceKeys, Bitmap icon)
        {
            try
            {
                FileApi fileApi = new FileApi(session.GetApiClient());

                ViewFileResult viewFileResult = fileApi.ViewFile(key);

                if (viewFileResult.Hdr.Rc == 0)
                {
                    FileRecord existingFile = viewFileResult.File;
                    existingFile.Name = title;
                    existingFile.Description = description;

                    UpdateFileInput updateFileInput = new UpdateFileInput(existingFile, null);
                    UpdateFileResult updateFileResult = fileApi.UpdateFile(key, updateFileInput);

                    if (updateFileResult.Hdr.Rc == 0)
                    {
                        FileRecord updatedFile = updateFileResult.Updated;

                        SpaceApi spaceApi = new SpaceApi(session.GetApiClient());

                        // Remove spaces
                        foreach (DisplayRecord destination in updatedFile.Destinations)
                        {
                            if (!spaceKeys.Contains(destination.Key))
                            {
                                List<String> itemKeysToRemove = new List<String>() { updatedFile.Key };
                                RemoveObjectsInput removeObjectsInput = new RemoveObjectsInput(destination.Key, itemKeysToRemove);
                                RemoveObjectsResult removeObjectsResult = spaceApi.RemoveObjects(destination.Key, removeObjectsInput);
                                if (removeObjectsResult.Hdr.Rc != 0)
                                {
                                    throw new Exception("Vmoso error removing file from space. Rc=" + removeObjectsResult.Hdr.Rc);
                                }

                            }
                            else
                            {
                                spaceKeys.Remove(destination.Key);
                            }
                        }

                        if (spaceKeys.Count > 0)
                        {
                            ShareObjectInput shareInput = new ShareObjectInput(null, spaceKeys, null);
                            ShareObjectResult shareResult = spaceApi.ShareObject(updatedFile.Key, shareInput);
                            if (shareResult.Hdr.Rc != 0)
                            {
                                throw new Exception("Vmoso error sharing file. Rc=" + shareResult.Hdr.Rc);
                            }
                        }

                        viewFileResult = fileApi.ViewFile(updatedFile.Key);
                        if (viewFileResult.Hdr.Rc == 0)
                        {
                            updatedFile = viewFileResult.File;
                            ShareFileItem item = new ShareFileItem(updatedFile.Name, updatedFile.Description);
                            item.Key = updatedFile.Key;
                            item.FileInfo = fileInfo;
                            item.Record = updatedFile;
                            item.SetIcon(icon);

                            List<ShareSpace> itemSpaces = new List<ShareSpace>();
                            foreach (DisplayRecord spaceDisplayRecord in updatedFile.Destinations)
                            {
                                ShareSpace space = new ShareSpace(spaceDisplayRecord.Key, spaceDisplayRecord.DisplayName, null);
                                itemSpaces.Add(space);
                            }

                            item.Spaces = itemSpaces;
                            return item;
                        }
                        else
                        {
                            throw new Exception("Vmoso error getting updated file. Rc=" + viewFileResult.Hdr.Rc);
                        }
                    }
                    else
                    {
                        throw new Exception("Vmoso error updating file. Rc=" + updateFileResult.Hdr.Rc);
                    }
                }
                else
                {
                    throw new Exception("Vmoso error getting file to update. Rc=" + viewFileResult.Hdr.Rc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Vmoso updating file", ex);
            }
        }

        

        public ShareLinkItem createBookmark(ShareLinkItem item, List<String> spaceKeys)
        {
            return createBookmark(item.Link, item.Title, item.Description, spaceKeys, item.GetIcon());
        }

        public ShareLinkItem createBookmark(Uri link, String title, String description, List<String> spaceKeys, Bitmap icon)
        {

            try
            {
                LinkApi linkApi = new LinkApi(session.GetApiClient());

                LinkV2Record linkRecord = new LinkV2Record();
                linkRecord.Link = link.ToString();
                linkRecord.Title = title;
                linkRecord.Text = description;
                linkRecord.Type = "document";
                linkRecord.Subtype = "link";

                CreateLinkInput createLinkInput = new CreateLinkInput(linkRecord);
                CreateLinkResult createLinkResult = linkApi.CreateLink(createLinkInput);
                if (createLinkResult.Hdr.Rc == 0)
                {
                    LinkV2Record createdLink = createLinkResult.Link;

                    if (spaceKeys != null)
                    {
                        SpaceApi spaceApi = new SpaceApi(session.GetApiClient());
                        ShareObjectInput shareInput = new ShareObjectInput(null, spaceKeys, null);
                        ShareObjectResult shareResult = spaceApi.ShareObject(createdLink.Key, shareInput);
                        if (shareResult.Hdr.Rc == 0)
                        {
                            GetLinkResult getLinkResult = linkApi.GetLink(createdLink.Key);
                            if (getLinkResult.Hdr.Rc == 0)
                            {
                                createdLink = getLinkResult.Link;
                            }
                            else
                            {
                                throw new Exception("Vmoso error getting created link. Rc=" + getLinkResult.Hdr.Rc);
                            }
                        }
                        else
                        {
                            throw new Exception("Vmoso error sharing link. Rc=" + shareResult.Hdr.Rc);
                        }
                    }

                    ShareLinkItem item = new ShareLinkItem(createdLink.Title, createdLink.Text);
                    item.Key = createdLink.Key;
                    item.Link = new Uri(createdLink.Link);
                    item.Record = createdLink;
                    item.SetIcon(icon);

                    List<ShareSpace> itemSpaces = new List<ShareSpace>();
                    foreach (DisplayRecord spaceDisplayRecord in createdLink.Destinations)
                    {
                        ShareSpace space = new ShareSpace(spaceDisplayRecord.Key, spaceDisplayRecord.DisplayName, null);
                        itemSpaces.Add(space);
                    }

                    item.Spaces = itemSpaces;
                    return item;
                }
                else
                {
                    throw new Exception("Vmoso error creating link. Rc=" + createLinkResult.Hdr.Rc);
                }
            } catch(Exception ex)
            {
                throw new Exception("Vmoso error creating link", ex);
            }
        }

        public ShareLinkItem updateBookmark(String key, Uri link, String title, String description, List<String> spaceKeys, Bitmap icon)
        {
            try
            {
                LinkApi linkApi = new LinkApi(session.GetApiClient());
                DocumentApi documentApi = new DocumentApi(session.GetApiClient());

                GetLinkResult getLinkResult = linkApi.GetLink(key);
                if (getLinkResult.Hdr.Rc == 0)
                {
                    LinkV2Record existingLink = getLinkResult.Link;
                    existingLink.Link = link.ToString();
                    existingLink.Title = title;
                    existingLink.Text = description;
                    existingLink.Type = "link";

                    //UpdateLinkInput updateLinkInput = new UpdateLinkInput(existingLink);
                    //UpdateLinkResult updateLinkResult = linkApi.UpdateLink(key, updateLinkInput);

                    UpdateDocumentInput updateDocumentInput = new UpdateDocumentInput(existingLink);
                    UpdateDocumentResult updateDocumentResult = documentApi.UpdateDocument(key, updateDocumentInput);

                    if (updateDocumentResult.Hdr.Rc == 0)
                    {
                        DocumentV2Record updatedDocument = updateDocumentResult.Document;

                        SpaceApi spaceApi = new SpaceApi(session.GetApiClient());

                        // Remove spaces
                        foreach (DisplayRecord destination in updatedDocument.Destinations)
                        {
                            if (!spaceKeys.Contains(destination.Key))
                            {
                                List<String> itemKeysToRemove = new List<String>() { updatedDocument.Key };
                                RemoveObjectsInput removeObjectsInput = new RemoveObjectsInput(destination.Key, itemKeysToRemove);
                                RemoveObjectsResult removeObjectsResult = spaceApi.RemoveObjects(destination.Key, removeObjectsInput);
                                if (removeObjectsResult.Hdr.Rc != 0)
                                {
                                    throw new Exception("Vmoso error removing bookmark from space. Rc=" + removeObjectsResult.Hdr.Rc);
                                }

                            }
                            else
                            {
                                spaceKeys.Remove(destination.Key);
                            }
                        }

                        if (spaceKeys.Count > 0)
                        {
                            ShareObjectInput shareInput = new ShareObjectInput(null, spaceKeys, null);
                            ShareObjectResult shareResult = spaceApi.ShareObject(updatedDocument.Key, shareInput);
                            if (shareResult.Hdr.Rc != 0)
                            {
                                throw new Exception("Vmoso error sharing bookmark. Rc=" + shareResult.Hdr.Rc);
                            }
                        }

                        getLinkResult = linkApi.GetLink(updatedDocument.Key);
                        if (getLinkResult.Hdr.Rc == 0)
                        {
                            LinkV2Record updatedLink = getLinkResult.Link;
                            ShareLinkItem item = new ShareLinkItem(updatedLink.Title, updatedLink.Text);
                            item.Key = updatedLink.Key;
                            item.Link = new Uri(updatedLink.Link);
                            item.Record = updatedLink;
                            item.SetIcon(icon);

                            List<ShareSpace> itemSpaces = new List<ShareSpace>();
                            foreach (DisplayRecord spaceDisplayRecord in updatedLink.Destinations)
                            {
                                ShareSpace space = new ShareSpace(spaceDisplayRecord.Key, spaceDisplayRecord.DisplayName, null);
                                itemSpaces.Add(space);
                            }

                            item.Spaces = itemSpaces;
                            return item;
                        }
                        else
                        {
                            throw new Exception("Vmoso error getting updated link. Rc=" + getLinkResult.Hdr.Rc);
                        }
                    }
                    else
                    {
                        throw new Exception("Vmoso error updating link. Rc=" + updateDocumentResult.Hdr.Rc);
                    }
                }
                else
                {
                    throw new Exception("Vmoso error getting link to update. Rc=" + getLinkResult.Hdr.Rc);
                }
            } catch(Exception ex)
            {
                throw new Exception("Vmoso error getting link to update", ex);
            }
        }

        public ShareLinkItem createBookmarkAsDocument(Uri link, String title, String description, List<String> spaceKeys, Bitmap icon)
        {

            try {
                DocumentApi documentApi = new DocumentApi(session.GetApiClient());

                LinkV2Record linkRecord = new LinkV2Record();
                linkRecord.Link = link.ToString();
                linkRecord.Title = title;
                linkRecord.Text = description;
                linkRecord.Type = "link";

                CreateDocumentInput createDocumentInput = new CreateDocumentInput(linkRecord);
                CreateDocumentResult createDocumentResult = documentApi.CreateDocument(createDocumentInput);
                if (createDocumentResult.Hdr.Rc == 0)
                {
                    DocumentV2Record createdDocument = createDocumentResult.Document;
                    LinkV2Record createdLink = null;

                    if (spaceKeys != null)
                    {
                        SpaceApi spaceApi = new SpaceApi(session.GetApiClient());
                        ShareObjectInput shareInput = new ShareObjectInput(null, spaceKeys, null);
                        ShareObjectResult shareResult = spaceApi.ShareObject(createdDocument.Key, shareInput);
                        if (shareResult.Hdr.Rc == 0)
                        {
                            LinkApi linkApi = new LinkApi(session.GetApiClient());
                            GetLinkResult getLinkResult = linkApi.GetLink(createdDocument.Key);
                            if (getLinkResult.Hdr.Rc == 0)
                            {
                                createdLink = getLinkResult.Link;
                            }
                            else
                            {
                                throw new Exception("Vmoso error getting created link. Rc=" + getLinkResult.Hdr.Rc);
                            }
                        }
                        else
                        {
                            throw new Exception("Vmoso error sharing link. Rc=" + shareResult.Hdr.Rc);
                        }
                    }

                    ShareLinkItem item = new ShareLinkItem(createdLink.Title, createdLink.Text);
                    item.Key = createdLink.Key;
                    item.Link = new Uri(createdLink.Link);
                    item.Record = createdLink;
                    item.SetIcon(icon);

                    List<ShareSpace> itemSpaces = new List<ShareSpace>();
                    foreach (DisplayRecord spaceDisplayRecord in createdLink.Destinations)
                    {
                        ShareSpace space = new ShareSpace(spaceDisplayRecord.Key, spaceDisplayRecord.DisplayName, null);
                        itemSpaces.Add(space);
                    }

                    item.Spaces = itemSpaces;
                    return item;
                }
                else
                {
                    throw new Exception("Vmoso error creating link. Rc=" + createDocumentResult.Hdr.Rc);
                }
            } catch(Exception ex)
            {
                throw new Exception("Vmoso error creating link",ex);
            }
        }
    }
}
