using System;
using VmosoApiClient.Model;
using System.Collections.Generic;
using System.Drawing;

namespace VmosoContactClient
{
    public class ContactItem
    {
        public String Key { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String IconKey { get; set; }
        public String Link { get; set; }
        public ProfileRecord ProfileRecord { get; set; }

        public ContactItem()
        {
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
                        if(!word.Equals("")) { 
                            capitals += word.Substring(0, 1).ToUpper();
                            count++;
                            if (count == 2) break;
                        }
                    }
                    return capitals;
                }
            } else
            {
                return "";
            }
        }

    }
}
