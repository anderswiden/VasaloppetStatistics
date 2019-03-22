using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace VLStatServiceLayer.RaceResultServices.QueryObjects
{
    public enum OrderByOptions
    {
        [Display(Name = "Finish")]
        ByFinishTime,
    }

    public static class RaceResultListDtoSort
    {
        public static IQueryable<RaceResultListDto> OrderRaceResultsBy (this IQueryable<RaceResultListDto> results,
                                                                        OrderByOptions orderByOptions)
        {
            switch (orderByOptions)
            {
                case OrderByOptions.ByFinishTime:
                    return results.OrderByDescending(r => r.FinishTime);                   
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(orderByOptions), orderByOptions, null);
            }
        }
    }
}
