using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Utility
{
    public class OfferUtility
    {
        public static double GetHighestBid(IEnumerable<Offer> offers)
        {
            return offers?.Max(x => x.Sum) ?? 0;
        }

        public static double GetAverageDifference(IEnumerable<double> highestBids, IEnumerable<double> estimates)
        {
            return highestBids.Average() - estimates.Average();
        }
    }
}
