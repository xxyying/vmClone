using System;
using System.Collections.Generic;
using VmosoApiClient.Api;
using VmosoApiClient.Client;
using VmosoApiClient.Model;
using Newtonsoft.Json;
using log4net;

namespace VmosoAHAClient
{
    public class AHAClient
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public const String AMP_SYMBOL = "&";
        public const String AT_SYMBOL = "@";
        public const String HASH_SYMBOL = "#";

        public const String USER_TYPE = "user";

        public const String USERGROUP_TYPE = "usergroupV2";

        public const String HOTSPOT_TYPE = "hotspot";

        public const String POST_TYPE = "postV2";

        public const String TASK_TYPE = "task";
        public const String TASK_ACTION_SUBTYPE = "action";
        public const String TASK_CHAT_SUBTYPE = "chat";
        public const String TASK_DEFAULT_SUBTYPE = "default";
        public const String TASK_APPROVAL_SUBTYPE = "approval";
        public const String TASK_MAIL_SUBTYPE = "mail";
        public const String TASK_FEEDBACK_SUBTYPE = "feedback";

        public const String FILE_TYPE = "file";
        public const String FILE_DOCUMENT_SUBTYPE = "document";
        public const String FILE_DOCUMENT_PPT = "ppt";
        public const String FILE_DOCUMENT_PPTX = "pptx";
        public const String FILE_DOCUMENT_PDF = "pdf";
        public const String FILE_DOCUMENT_ZIP = "zip";
        public const String FILE_DOCUMENT_DOC = "doc";
        public const String FILE_DOCUMENT_DOCX = "docx";
        public const String FILE_DOCUMENT_XLS = "xls";
        public const String FILE_DOCUMENT_XLSX = "xlsx";
        public const String FILE_DOCUMENT_TXT = "txt";

        public const String FILE_AUDIO_SUBTYPE = "audio";
        public const String FILE_VIDEO_SUBTYPE = "video";

        public const String FILE_IMAGE_SUBTYPE = "image";
        public const String FILE_IMAGE_PNG = "png";
        public const String FILE_IMAGE_JPG = "jpg";

        public const String FILE_GENERAL_SUBTYPE = "general";
        public const String FILE_GENERAL_ZIP = "zip";
        public const String FILE_GENERAL_EPS = "eps";

        public const String DOCUMENT_TYPE = "document";
        public const String DOCUMENT_ACTION_SUBTYPE = "action";
        public const String DOCUMENT_APPROVAL_SUBTYPE = "approval";

        public const String FILE_PATH = "f";
        public const String FOLDER_PATH = "s";
        public const String POST_PATH = "p";
        public const String TASK_PATH = "t";
        public const String USER_PATH = "c";
        public const String USERGROUP_PATH = "g";
        public const String HOTSPOT_PATH = "s";
        public const String DOCUMENT_PATH = "l";

        public static Dictionary<String, String> PATHS = new Dictionary<String, String>()
        {
            { FILE_TYPE, FILE_PATH },
            { POST_TYPE, POST_PATH },
            { USER_TYPE, USER_PATH },
            { TASK_TYPE, TASK_PATH },
            { USERGROUP_TYPE, USERGROUP_PATH },
            { HOTSPOT_TYPE, HOTSPOT_PATH },
            { DOCUMENT_TYPE, DOCUMENT_PATH }
        };

        private VmosoSession session;
        private ListPageRecord pager;
        private SearchStreamOptionsRecord options;

        public AHAClient(VmosoSession session)
        {
            log.Debug("Creating AHAClient for host/userKey " + session.Host + "/" + session.UserKey);
            this.session = session;
        }

        public List<AHAItem> Search(String query)
        {
            log.Debug("Searching " + query);
            List<AHAItem> items = null;
            if (isAHAQuery(query))
            {
                String symbol = getAHASymbol(query);
                try
                {
                    switch (symbol)
                    {
                        case AMP_SYMBOL:
                            items = SearchFiles(query);
                            break;
                        case HASH_SYMBOL:
                            items = SearchActivities(query);
                            break;
                        case AT_SYMBOL:
                            items = SearchPeopleAndSpaces(query);
                            break;
                    }
                    return items;

                }
                catch (Exception ex)
                {
                    throw new Exception("Error while searching data", ex);
                }
            } else
            {
                items = SearchAll(query);
                return items;
            }
        }

        public List<AHAItem> Search(String query, Dictionary<String, List<String>> types)
        {
            log.Debug("Searching " + query);
            query = removeAHASymbol(query);
            query = query.Replace("/", "*");

            this.options = new SearchStreamOptionsRecord();
            options.Q = query;

            List<ObjectTypeRecord> typeFilters = new List<ObjectTypeRecord>();

            if (types != null && types.Count > 0) {
                foreach (String typeKey in types.Keys)
                {
                    ObjectTypeRecord typeFilter = new ObjectTypeRecord();
                    typeFilter.Type = typeKey;
                    typeFilter.Subtypes = types[typeKey];

                    typeFilters.Add(typeFilter);
                    if(typeFilter.Subtypes == null)
                    {
                        log.Debug("Type " + typeFilter.Type);
                    } else
                    {
                        log.Debug("Type " + typeFilter.Type + ", Subtypes " + string.Join(",",typeFilter.Subtypes.ToArray()));
                    }
                    
                }
            }
            options.TypeFilters = typeFilters;
            options.SortAttr = new List<String> { "USAGE_SORT" };
            return InvokeSearch(options);
        }

        private String removeAHASymbol(String query)
        {
            if(isAHAQuery(query))
            {
                query = query.Substring(1);
            }
            return query;
        }

        private bool isAHAQuery(String query)
        {
            if(query.StartsWith(AMP_SYMBOL) || query.StartsWith(AT_SYMBOL) || query.StartsWith(HASH_SYMBOL))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private String getAHASymbol(String query)
        {
            if(isAHAQuery(query))
            {
                return query.Substring(0, 1);
            } else
            {
                return "";
            }
            
        }

        private List<AHAItem> SearchPeopleAndSpaces(String query)
        {
            Dictionary<String, List<String>> types = new Dictionary<String, List<String>>();
            types.Add(USER_TYPE, null);
            types.Add(HOTSPOT_TYPE, null);

            return Search(query, types);
        }

        private List<AHAItem> SearchActivities(String query)
        {
            Dictionary<String, List<String>> types = new Dictionary<String, List<String>>();
            types.Add(TASK_TYPE, new List<String>() { TASK_CHAT_SUBTYPE, TASK_DEFAULT_SUBTYPE, TASK_APPROVAL_SUBTYPE, TASK_ACTION_SUBTYPE, TASK_MAIL_SUBTYPE, TASK_FEEDBACK_SUBTYPE });
            types.Add(POST_TYPE, null);
            return Search(query, types);
        }

        private List<AHAItem> SearchFiles(String query)
        {
            Dictionary<String, List<String>> types = new Dictionary<String, List<String>>();
            types.Add(FILE_TYPE, new List<String>() { FILE_DOCUMENT_SUBTYPE, FILE_AUDIO_SUBTYPE, FILE_IMAGE_SUBTYPE, FILE_VIDEO_SUBTYPE, FILE_GENERAL_SUBTYPE });
            types.Add(DOCUMENT_TYPE, null);
            return Search(query, types);
        }

        private List<AHAItem> SearchAll(String query)
        {
            Dictionary<String, List<String>> types = new Dictionary<String, List<String>>();
            types.Add(USER_TYPE, null);
            types.Add(HOTSPOT_TYPE, null);

            types.Add(TASK_TYPE, new List<String>() { TASK_CHAT_SUBTYPE, TASK_DEFAULT_SUBTYPE, TASK_APPROVAL_SUBTYPE, TASK_ACTION_SUBTYPE, TASK_MAIL_SUBTYPE, TASK_FEEDBACK_SUBTYPE });
            types.Add(POST_TYPE, null);

            types.Add(FILE_TYPE, new List<String>() { FILE_DOCUMENT_SUBTYPE, FILE_AUDIO_SUBTYPE, FILE_IMAGE_SUBTYPE, FILE_VIDEO_SUBTYPE, FILE_GENERAL_SUBTYPE });
            types.Add(DOCUMENT_TYPE, null);
            return Search(query, types);
        }


        public List<AHAItem> NextPage()
        {
            PaginationRecord pg = pager.Pg;
            pg.Page = "N";
            return InvokeSearch(this.options, pg);
        }

        private List<AHAItem> InvokeSearch(SearchStreamOptionsRecord options)
        {
            PaginationRecord pg = new PaginationRecord();
            pg.Page = "F";
            pg.Limit = 10;
            return InvokeSearch(this.options, pg);

        }
        private List<AHAItem> InvokeSearch(SearchStreamOptionsRecord options, PaginationRecord pg) 
        {
            try
            {
                log.Debug("Search options: " + options.ToJson());
                log.Debug("Search page: " + pg.ToJson());
                this.options = options;
                ObjectApi objectApi = new ObjectApi(session.GetApiClient());
                log.Debug("Calling SearchObjects API");
                SearchObjectsResult result = objectApi.SearchObjects(options.ToJson(), pg.ToJson());
                if (result.Hdr.Rc == 0)
                {
                    pager = result.Pager;
                    List<AHAItem> items = new List<AHAItem>();
                    List<Record> records = result.Records;
                    log.Debug(records.Count + " records returned");

                    foreach (var record in records)
                    {
                        String jsonString = record.Json;
                        log.Debug("Record: " + jsonString);
                        log.Debug("Creating AHA item");
                        AHAItem item = itemFromJson(jsonString);
                        log.Debug("AHAItem: " + JsonConvert.SerializeObject(item));

                        if (item.Type.Equals(FILE_TYPE))
                        {
                            log.Debug("Getting additional info for file");
                            FileApi fileApi = new FileApi(session.GetApiClient());
                            ViewFileResult viewFileResult = fileApi.ViewFile(item.Key);
                            if(viewFileResult.Hdr.Rc == 0) {
                                FileRecord fileRecord = viewFileResult.File;
                                item.LastUpdater = fileRecord.LastUpdater.DisplayName;
                                item.Version = fileRecord.UiVersion;
                                log.Debug("Last updater: " + item.LastUpdater);
                                log.Debug("Version: " + item.Version);
                            } else
                            {
                                log.Error("Vmoso error getting additional info for file. Rc=" + viewFileResult.Hdr.Rc);
                            }
                        }

                        items.Add(item);
                    }
                    return items;
                }
                else
                {
                    throw new Exception("Vmoso error searching objects. Rc=" + result.Hdr.Rc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching objects from Vmoso",ex);
            }

        }

        private String getFileExtension(String fileName)
        {

            int pos1 = fileName.LastIndexOf(".");
            if (pos1 >= 0)
            {
                if (fileName.Length > (pos1 + 1))
                {
                    return fileName.Substring(pos1+1).ToLower();
                } 
            } 
            return "";
        }

        public AHAItem itemFromJson(String jsonString)
        {
            dynamic dynObj = JsonConvert.DeserializeObject(jsonString);
            String key = dynObj.key;
            String name = dynObj.name;
            String type = dynObj.type;
            String subtype = dynObj.subtype;

            String symbol = getSymbolFromTypes(type, subtype);
            String iconKey = dynObj.iconSmall;
            String richLink = dynObj.rich_link;

            //String link = "<a href=\"" + session.OriginalHost + getHref(richLink) + "\">@" + name + "</a>";
            String path = "";
            if (PATHS.ContainsKey(type))
            {
                path = PATHS[type];
            }
            else
            {
                log.Error("URL for type " + type + " not found");
            }
            String link = session.OriginalHost + "/" + path + "/" + key;

            AHAItem item = new AHAItem(symbol, key, name, type, subtype, iconKey, link);
            if (type.Equals(FILE_TYPE))
            {
                String fileExtension = getFileExtension(name);
                item.FileType = fileExtension;
            }

            String timeUpdatedString = dynObj.timeupdated;

            Double timeUpdated = Double.Parse(timeUpdatedString);
            DateTime timeStamp = UnixTimeStampToDateTime(timeUpdated);
            item.TimeUpdated = timeStamp;

            item.Json = jsonString;
            return item;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private String getSymbolFromTypes(String type, String subtype)
        {
            switch (type)
            {
                case USERGROUP_TYPE:
                    return AT_SYMBOL;
                case USER_TYPE:
                    return AT_SYMBOL;
                case HOTSPOT_TYPE:
                    return AT_SYMBOL;
                case DOCUMENT_TYPE:
                    return AMP_SYMBOL;
                case FILE_TYPE:
                    return AMP_SYMBOL;
                case TASK_TYPE:
                    return HASH_SYMBOL;
                case POST_TYPE:
                    return HASH_SYMBOL;
                default:
                    return "";
            }
        }
    }
}
