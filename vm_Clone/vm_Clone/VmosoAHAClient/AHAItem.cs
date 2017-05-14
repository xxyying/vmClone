using System;

namespace VmosoAHAClient
{
    public class AHAItem
    {
        public String Symbol { get; set; }
        public String Key { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String SubType { get; set; }
        public String Link { get; set; }
        public String IconKey { get; set; }
        public String FileType { get; set; }
        public String LastUpdater { get; set; }
        public DateTime TimeUpdated { get; set; }
        public String Version { get; set; }
        public String Json { get; set;}

        public AHAItem(String Symbol, String Key, String Name, String Type, String SubType, String IconKey, String Link)
        {
            this.Symbol = Symbol;
            this.Key = Key;
            this.Name = Name;
            this.Type = Type;
            this.SubType = SubType;
            this.IconKey = IconKey;
            this.Link = Link;
            
        }

        public String GetNameCapitals()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                if (Name.Contains("@"))
                {
                    String capitals = "";
                    char[] separators = { '.', '-', '_' };
                    string[] words = Name.Split(separators);
                    int count = 0;
                    foreach (string word in words)
                    {
                        capitals += word.Substring(0, 1).ToUpper();
                        count++;
                        if (count == 2) break;
                    }
                    return capitals;
                }
                else
                {
                    String capitals = "";
                    string[] words = Name.Split(' ');
                    int count = 0;
                    foreach (string word in words)
                    {
                        capitals += word.Substring(0, 1).ToUpper();
                        count++;
                        if (count == 2) break;
                    }
                    return capitals;
                }
            }
            else
            {
                return "";
            }
        }

    }
}
