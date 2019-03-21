using System;
using System.Collections.Generic;
using System.Text;

namespace VLStatDataLayer
{
    class RaceResult
    {
        public int RaceResultId { get; set; }

        public int StartNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Split> Splits { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }
    }
}
