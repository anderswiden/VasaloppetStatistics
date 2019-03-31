using System.Linq;
using VLStatDataLayer;

namespace VLStatServiceLayer.RaceResultServices.QueryObjects
{
    public static class RaceResultListDtoSelect
    {
        public static IQueryable<RaceResultListDto> MapRaceResultToDto(this IQueryable<RaceResult> raceResults)
        {
            return raceResults.Select(rr => new RaceResultListDto
            {
                RaceResultId = rr.RaceResultId,
                StartNumber = rr.StartNumber,
                FirstName = rr.FirstName,
                LastName = rr.LastName,
                FinishTime = rr.Splits.OrderByDescending(s => s.CheckPointIndex).First().SplitTime
            });
        }
    }
}
