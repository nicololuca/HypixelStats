using System;
namespace hypixelstats.Model
{
    public class APIFailureModel
    {
        public string cause { get; set; }
        public bool throttle { get; set; } // Present only on 429 response
        public bool Global { get; set; } // Present only on 429 response
    }
}
