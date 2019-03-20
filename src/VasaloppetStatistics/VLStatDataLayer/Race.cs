using System;
using System.Collections.Generic;
using System.Text;

namespace VLStatDataLayer
{
    public class Race
    {
        public int RaceId { get; set; }

        public DateTime Racetime { get; set; }
    
        public RaceType RaceType { get; set; }

    }
}
