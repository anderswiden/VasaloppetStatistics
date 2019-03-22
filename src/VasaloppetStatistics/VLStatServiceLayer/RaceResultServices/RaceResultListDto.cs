using System;
using System.Collections.Generic;
using System.Text;

namespace VLStatServiceLayer.RaceResultServices
{
    public class RaceResultListDto
    {
        public int RaceResultId { get; set; }

        public int StartNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime FinishTime { get; set; }
    }
}
