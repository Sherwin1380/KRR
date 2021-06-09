


using System.Collections.Generic;

namespace KRR
{
    public class State
    {
        public string action { get; set; }
        public string agent { get; set; }
        public string fluent { get; set; }
        public List<string> condition { get; set; }
    }
}
