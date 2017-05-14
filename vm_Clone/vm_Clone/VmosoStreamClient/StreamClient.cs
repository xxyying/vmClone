using System;
using System.Web;

using System.Text.RegularExpressions;
using System.Collections.Generic;
using VmosoApiClient.Api;
using VmosoApiClient.Client;
using VmosoApiClient.Model;
using Newtonsoft.Json;
using log4net;
using HtmlAgilityPack;


namespace VmosoStreamClient
{
    public class StreamClient
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public const String RECORD_POSTV2 = "PostV2Record";
        public const String RECORD_POSTV2_DESCRIPTION = "Post";

        public const String RECORD_TASK = "TaskRecord";
        public const String RECORD_TASK_DESCRIPTION = "Task";

        public const String TASK_TYPE_CHAT = "chat";
        public const String TASK_TYPE_ACTION = "action";
        public const String TASK_TYPE_APPROVAL = "approval";
        public const String TASK_TYPE_EMAIL = "email";

        public const String RECORD_FILE = "FileRecord";
        public const String RECORD_FILE_DESCRIPTION = "File";

        public const String RECORD_LINKV2 = "LinkV2Record";
        public const String RECORD_LINKV2_DESCRIPTION = "Bookmark";

        public const String RECORD_NOTEV2 = "NoteV2Record";
        public const String RECORD_NOTEV2_DESCRIPTION = "Note";

        public const String RECORD_FOLDER = "FolderRecord";
        public const String RECORD_FOLDER_DESCRIPTION = "Space";

        public const String USER_OBJECT_RECORD = "UserObjectRecord";

        public const String FILE_PATH = "f";
        public const String FOLDER_PATH = "s";
        public const String POST_PATH = "p";
        public const String TASK_PATH = "t";
        public const String USER_PATH = "c";
        public const String USERGROUP_PATH = "g";
        public const String HOTSPOT_PATH = "s";
        public const String BOOKMARK_PATH = "l";

        public static Dictionary<String, String> PATHS = new Dictionary<String, String>()
        {
            { RECORD_FILE, FILE_PATH },
            { RECORD_POSTV2, POST_PATH },
            { RECORD_LINKV2, BOOKMARK_PATH },
            { RECORD_TASK, TASK_PATH }
        };




        public static Dictionary<String, String> RECORDS = new Dictionary<String, String>()
        {
            { RECORD_POSTV2, RECORD_POSTV2_DESCRIPTION },
            { RECORD_LINKV2, RECORD_LINKV2_DESCRIPTION },
            { RECORD_TASK, RECORD_TASK_DESCRIPTION },
            { RECORD_FILE, RECORD_FILE_DESCRIPTION }
        };

        private VmosoSession session;
        private ListPageRecord pager;
        private SearchStreamOptionsRecord options;

        private ListPageRecord commentsPager;

        public StreamClient(VmosoSession session)
        {
            log.Debug("Creating Stream Client for host/userKey " + session.Host + "/" + session.UserKey);
            this.session = session;
        }

        public List<StreamRule> getPresetRules()
        {
            List<StreamRule> rules = new List<StreamRule>();
            try
            {
                RuleApi ruleApi = new RuleApi(session.GetApiClient());
                GetPresetRulesResult result = ruleApi.GetPresetRules("activities");
                if (result.Hdr.Rc == 0)
                {
                    List<RuleRecord> ruleRecords = result.Rules;
                    foreach (RuleRecord ruleRecord in ruleRecords)
                    {
                        StreamRule rule = new StreamRule();
                        rule.RuleRecord = ruleRecord;
                        rule.Key = ruleRecord.Key;
                        rule.Name = ruleRecord.Name;
                        rules.Add(rule);
                    }
                    return rules;
                }
                else
                {
                    throw new Exception("Error getting preset rules");
                }

            }
            catch (ApiException ex)
            {
                throw new Exception("Error getting preset rules", ex);
            }
        }

        public List<StreamItem> GetStream()
        {
            List<StreamRule> rules = new List<StreamRule>();
            return GetStream(rules, null);
        }

        public List<StreamItem> GetStream(String query)
        {
            List<StreamRule> rules = new List<StreamRule>();
            return GetStream(rules,query);
        }


        public StreamItem GetStreamItem(String contentKey)
        {
            List<StreamRule> rules = new List<StreamRule>();
            PaginationRecord pg = new PaginationRecord();
            pg.Page = "F";
            pg.Limit = 10;
            SearchStreamOptionsRecord options = new SearchStreamOptionsRecord();

            if (rules != null)
            {
                List<String> ruleKeys = new List<String>();
                foreach (StreamRule rule in rules)
                {
                    ruleKeys.Add(rule.Key);
                }
                options.RuleKey = ruleKeys;
            }

            options.ObjectKey = contentKey;
            options.SortAttr = new List<String>() { "DOMINANT_ACTIVITY_TIME" };
            options.StatusFilter = new List<String>() { "online" };
            options.CreatorFilter = "all";
            options.SortDir = "DESC";
            options.UnreadFilter = "all";
            options.RelevanceFilter = "most";
            options.FolderLevelFilter = "current";
            options.ZoneFilter = "engage";
            options.LocaleFilter = new List<String>() { "user" };
            options.RuleType = "activities";
            FormatRecord formatRecord = new FormatRecord();
            formatRecord.ReturnCounts = true;
            formatRecord.ReturnRatings = true;
            formatRecord.ReturnSparc = true;
            formatRecord.ReturnAcl = true;
            options.Format = formatRecord.ToJson();

            List<StreamItem> items = InvokeSearch(pg);
            if(items.Count > 0)
            {
                return items[0];
            } else
            {
                throw new Exception("Error getting stream item");
            }

        }
        public List<StreamItem> GetStream(StreamRule rule, String query)
        {
            List<StreamRule> rules = new List<StreamRule>();
            rules.Add(rule);
            return GetStream(rules, query);
        }

        public List<StreamItem> GetStream(List<StreamRule> rules, String query)
        {

            PaginationRecord pg = new PaginationRecord();
            pg.Page = "F";
            pg.Limit = 10;
            options = new SearchStreamOptionsRecord();

            if (!string.IsNullOrEmpty(query))
            {
                options.SearchString = query;
                options.SortAttr = new List<String>() { "FULLTEXT_SEARCH_SCORE" }; 
            } else
            {
                options.SortAttr = new List<String>() { "DOMINANT_ACTIVITY_TIME" };
            }

            if (rules != null)
            {
                List<String> ruleKeys = new List<String>();
                foreach (StreamRule rule in rules)
                {
                    ruleKeys.Add(rule.Key);
                }
                options.RuleKey = ruleKeys;
            }

            
            options.StatusFilter = new List<String>() { "online" };
            options.CreatorFilter = "all";
            options.SortDir = "DESC";
            options.UnreadFilter = "all";
            options.RelevanceFilter = "most";
            options.FolderLevelFilter = "current";
            options.ZoneFilter = "engage";
            options.LocaleFilter = new List<String>() { "user" };
            options.RuleType = "activities";
            FormatRecord formatRecord = new FormatRecord();
            formatRecord.ReturnCounts = true;
            formatRecord.ReturnRatings = true;
            formatRecord.ReturnSparc = true;
            formatRecord.ReturnAcl = true;
            options.Format = formatRecord.ToJson();


            return InvokeSearch(pg);

        }

        public List<StreamItem> InvokeSearch(PaginationRecord pg)
        {
            try
            {
                StreamApi streamApi = new StreamApi(session.GetApiClient());
                FormatRecord formatRecord = new FormatRecord();
                formatRecord.ReturnCounts = true;
                formatRecord.ReturnRatings = true;
                formatRecord.ReturnSparc = true;
                formatRecord.ReturnAcl = true;
                StreamSearchResult result = streamApi.StreamSearch(options.ToJson(), pg.ToJson(), formatRecord.ToJson());

                if (result.Hdr.Rc == 0)
                {
                    pager = result.Pager;
                    List<StreamItem> streamItems = new List<StreamItem>();
                    List<StreamRecordWrapper> recordWrappers = result.Stream;
                    foreach (StreamRecordWrapper recordWrapper in recordWrappers)
                    {
                        StreamItem streamItem = new StreamItem();
                        streamItem.UnreadCount = (int)recordWrapper.BadgeCounts.TotalNewCount;
                        streamItem.RecordType = recordWrapper.Recordtype;

                        String recordJson = JsonConvert.SerializeObject(recordWrapper.Record);
                        switch (streamItem.RecordType)
                        {
                            case RECORD_POSTV2:
                                PostV2Record postRecord = JsonConvert.DeserializeObject<PostV2Record>(recordJson);
                                streamItem.Key = postRecord.Key;
                                streamItem.CommentListKey = postRecord.CommentlistKey;
                                streamItem.Type = postRecord.Type;
                                streamItem.SubType = postRecord.Subtype;
                                streamItem.Name = postRecord.Title;
                                streamItem.Record = postRecord;

                                break;
                            case RECORD_LINKV2:
                                LinkV2Record linkRecord = JsonConvert.DeserializeObject<LinkV2Record>(recordJson);
                                streamItem.Key = linkRecord.Key;
                                streamItem.Type = linkRecord.Type;
                                streamItem.SubType = linkRecord.Subtype;
                                streamItem.Name = linkRecord.Title;
                                streamItem.Record = linkRecord;

                                break;
                            case RECORD_TASK:
                                TaskRecord taskRecord = JsonConvert.DeserializeObject<TaskRecord>(recordJson);
                                streamItem.CommentListKey = taskRecord.CommentlistKey;
                                streamItem.Key = taskRecord.Key;
                                streamItem.Type = taskRecord.Type;
                                streamItem.SubType = taskRecord.Subtype;
                                streamItem.Name = taskRecord.Name;
                                streamItem.Record = taskRecord;

                                break;
                            case RECORD_FILE:
                                FileRecord fileRecord = JsonConvert.DeserializeObject<FileRecord>(recordJson);
                                streamItem.Key = fileRecord.Key;
                                streamItem.Type = fileRecord.Type;
                                streamItem.SubType = fileRecord.Subtype;
                                streamItem.Name = fileRecord.Name;
                                streamItem.Record = fileRecord;
                                break;
                            default:
                                Console.WriteLine(recordWrapper.Recordtype);
                                break;
                        }

                        dynamic recordObject = JsonConvert.DeserializeObject(recordJson);
                        dynamic destinations = recordObject.destinations;
                        try
                        {
                            streamItem.SpacePath = destinations[0].fullPath + "/" + destinations[0].displayName;
                        }
                        catch (Exception ex)
                        {
                        }

                        SparcActionRecord lastAction = recordWrapper.LastAction;
                        if (lastAction != null)
                        {
                            Double timeUpdated = Convert.ToDouble(lastAction.Timestamp);
                            DateTime timeStamp = UnixTimeStampToDateTime(timeUpdated);
                            streamItem.TimeUpdated = timeStamp;
                            List<StreamRecordWrapper> actors = lastAction.Actors;
                            if (actors.Count > 0)
                            {

                                String actorRecordType = actors[0].Recordtype;
                                String userRecordJson = JsonConvert.SerializeObject(actors[0].Record);
                                switch (actorRecordType)
                                {
                                    case USER_OBJECT_RECORD:
                                        UserObjectRecord userRecord = JsonConvert.DeserializeObject<UserObjectRecord>(userRecordJson);
                                        streamItem.LastUpdater = userRecord.DisplayName;
                                        streamItem.LastUpdaterFirstName = userRecord.FirstName;
                                        streamItem.LastUpdaterLastName = userRecord.LastName;
                                        streamItem.LastUpdaterIconKey = userRecord.IconSmall;
                                        break;
                                }
                            }

                            String verb = "";

                            switch(lastAction.Verb)
                            {
                                case "create":
                                    verb = "Created";
                                    break;
                                case "update":
                                    verb = "Updated";
                                    break;
                                case "delete":
                                    verb = "Deleted";
                                    break;
                                case "rename":
                                    verb = "Renamed";
                                    break;
                                default:
                                    break;
                            }

                            switch (lastAction.Sparctype)
                            {
                                case "summary":
                                    switch(lastAction.Sparcsubtype)
                                    {
                                        case "all":
                                            streamItem.LastActionContent = verb + " a " + RECORDS[streamItem.RecordType];
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "content":
                                    StreamRecordWrapper actionRecordWrapper = lastAction.Containers[0];
                                    String actionRecordJson = JsonConvert.SerializeObject(actionRecordWrapper.Record);
                                    switch (lastAction.Sparcsubtype)
                                    {
                                        case "comment":
                                            CommentV2Record commentRecord = JsonConvert.DeserializeObject<CommentV2Record>(actionRecordJson);
                                            String textWithoutComments = Regex.Replace(commentRecord.Text, "<!--.*?-->", String.Empty, RegexOptions.Multiline);
                                            HtmlDocument doc = new HtmlDocument();
                                            doc.LoadHtml(HttpUtility.HtmlDecode(textWithoutComments));
                                            
                                            streamItem.LastActionContent = doc.DocumentNode.InnerText;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;

                                default:
                                    break;
                            }
                            String path = "";
                            if (PATHS.ContainsKey(streamItem.RecordType))
                            {
                                path = PATHS[streamItem.RecordType];
                            }
                            else
                            {
                                log.Error("URL for record type " + streamItem.RecordType + " not found");
                            }
                            streamItem.Link = session.OriginalHost + "/" + path + "/" + streamItem.Key; ;

                            streamItems.Add(streamItem);
                        }
                        
                    }
                    return streamItems;
                }
                else
                {
                    throw new Exception("Error searching stream");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching stream", ex);
            }
        }

        public List<StreamItem> NextPage()
        {
            PaginationRecord pg = pager.Pg;
            pg.Page = "N";
            return InvokeSearch(pg);
        }


        public List<StreamComment> GetComments(StreamItem streamItem)
        {
            PaginationRecord pg = new PaginationRecord();
            pg.Page = "F";
            pg.Limit = 10;
            return GetComments(streamItem, pg);
        }


        public List<StreamComment> GetComments(StreamItem streamItem, PaginationRecord pg)
        {
            CommentApi commentApi = new CommentApi(session.GetApiClient());

            try
            {
                CommentListV2OptionsRecord options = new CommentListV2OptionsRecord();
                options.SortDir = "DESC";
                options.HighlightTag = "mark";
                options.CreatorFilter = "all";
                options.ReadFilter = "all";
                options.SortFilter = "updateTime";

                AdditionalDataRecord additionalData = new AdditionalDataRecord();
                additionalData.SubType = "general";
                additionalData.FirstLevelCount = true;

                GetCommentsResult getCommentsResult = commentApi.GetComments(streamItem.Key, options.ToJson(), pg.ToJson(), streamItem.CommentListKey, additionalData.ToJson());
                if (getCommentsResult.Hdr.Rc == 0)
                {
                    commentsPager = getCommentsResult.Pager;
                    List<StreamComment> comments = new List<StreamComment>();
                    List<CommentV2Record> commentRecords = getCommentsResult.Comments;
                    foreach (CommentV2Record commentRecord in commentRecords)
                    {
                        StreamComment comment = new StreamComment(commentRecord, streamItem.RecordType);
                        comments.Add(comment);
                    }

                    return comments;
                }
                else
                {
                    throw new Exception("Error getting comments for contentKey " + streamItem.Key);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting comments for contentKey " + streamItem.Key, ex);
            }
        }

        public List<StreamComment> NextCommentsPage(StreamItem streamItem)
        {
            PaginationRecord pg = commentsPager.Pg;
            pg.Page = "N";
            return GetComments(streamItem, pg);
        }

        public void MarkTilesRead(StreamItem streamItem)
        {
            ObjectApi objectApi = new ObjectApi(session.GetApiClient());

            try
            {
                MarkAllTilesReadResult result = objectApi.MarkAllTilesRead(streamItem.Key);
                if (result.Hdr.Rc == 0)
                {
                }
                else
                {
                    throw new Exception("Error updating read info for contentKey " + streamItem.Key);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating read info for contentKey " + streamItem.Key, ex);
            }
        }

        public StreamComment ReplyComment(String text, StreamComment parentComment)
        {
            return CreateComment(text, parentComment.ContentKey, parentComment.ContentRecordType, parentComment.CommentListKey, parentComment.CommentPId);
        }

        public StreamComment CreateComment(String text, StreamItem contentItem)
        {
            return CreateComment(text, contentItem.Key, contentItem.RecordType, null, 0);
        }

        public StreamComment CreateComment(String text, String contentKey, String contentRecordType)
        {
            return CreateComment(text, contentKey, contentRecordType, null, 0);
        }

        private StreamComment CreateComment(String text, String contentKey, String contentRecordType, String commentListKey, int principalCommentId)
        {
            try
            {
                CommentApi commentApi = new CommentApi(session.GetApiClient());
                CommentV2Record commentRecord = new CommentV2Record();
                commentRecord.ContentKey = contentKey;
                
                if(principalCommentId > 0) commentRecord.CommentPID = principalCommentId;
                if(commentListKey!=null) commentRecord.CommentListKey = commentListKey;

                commentRecord.Text = text;

                CreateCommentInput createCommentInput = new CreateCommentInput(contentKey, commentRecord);
                CreateCommentResult createCommentResult = commentApi.CreateComment(createCommentInput);
                if(createCommentResult.Hdr.Rc == 0)
                {
                    CommentV2Record createdComment = createCommentResult.Comment;
                    StreamComment comment = new StreamComment(createdComment, contentRecordType);
                    return comment;
                } else
                {
                    throw new Exception("Error creating comment. Rc=" + createCommentResult.Hdr.Rc);
                }
            } catch(Exception ex)
            {
                throw new Exception("Error creating comment", ex);
            }
        }

        public StreamComment UpdateComment(String text, StreamComment comment)
        {
            try
            {
                CommentApi commentApi = new CommentApi(session.GetApiClient());
                CommentV2Record commentRecord = comment.Record;
                commentRecord.Text = text;

                UpdateCommentInput updateCommentInput = new UpdateCommentInput(comment.ContentKey, commentRecord);
                UpdateCommentResult updateCommentResult = commentApi.UpdateComment(updateCommentInput);
                if (updateCommentResult.Hdr.Rc == 0)
                {
                    CommentV2Record updatedCommentRecord = updateCommentResult.Comment;
                    StreamComment updatedComment = new StreamComment(updatedCommentRecord, comment.ContentRecordType);
                    return updatedComment;
                }
                else
                {
                    throw new Exception("Error creating comment. Rc=" + updateCommentResult.Hdr.Rc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating comment", ex);
            }
        }

        public void DeleteComment(String contentKey, String commentListKey, int commentId)
        {
            try
            {
                CommentApi commentApi = new CommentApi(session.GetApiClient());
                DeleteCommentInput deleteCommentInput = new DeleteCommentInput(contentKey, commentListKey, commentId);
                DeleteCommentResult deleteCommentResult = commentApi.DeleteComment(deleteCommentInput);
                if (deleteCommentResult.Hdr.Rc != 0)
                {
                    throw new Exception("Error deleting comment. Rc=" + deleteCommentResult.Hdr.Rc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting comment", ex);
            }
        }

        public void MarkCommentsRead(StreamItem streamItem)
        {
            CommentApi commentApi = new CommentApi(session.GetApiClient());

            try
            {
                MarkAllReadInput input = new MarkAllReadInput(streamItem.CommentListKey, streamItem.Key);
                MarkAllReadResult result = commentApi.MarkAllRead(input);
                if (result.Hdr.Rc == 0)
                {
                }
                else
                {
                    throw new Exception("Error marking as read info for contentKey " + streamItem.Key);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating read info for contentKey " + streamItem.Key, ex);
            }
        }

        private String getFileExtension(String fileName)
        {

            int pos1 = fileName.LastIndexOf(".");
            if (pos1 >= 0)
            {
                if (fileName.Length > (pos1 + 1))
                {
                    return fileName.Substring(pos1 + 1).ToLower();
                }
            }
            return "";
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

    }
}
