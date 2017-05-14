using System;
using VmosoApiClient.Model;

namespace VmosoStreamClient
{
    public class StreamRule
    {
        public String Key { get; set; }
        public String Name { get; set; }
        public RuleRecord RuleRecord { get; set; }
        public StreamRule()
        {
        }

    }
}
