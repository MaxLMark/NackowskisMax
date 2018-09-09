using NackowskisMax.Models;
using NackowskisMax.Utility;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public static class MockOffers
    {
        public static List<Offer> Offers => new List<Offer>
            {
                new Offer
                {
                    Sum = 150
                },
                new Offer
                {
                    Sum = 170
                },
                new Offer
                {
                    Sum = 200
                },
                new Offer
                {
                    Sum = 15
                },
                new Offer
                {
                    Sum = 130
                }
            };
    }

    public class OffersTest
    {
        [Fact]
        public void Test_highest_bidding_offer()
        {

            var offerlist = MockOffers.Offers;

            var highestBid = OfferUtility.GetHighestBid(offerlist);

            Assert.Equal(200, highestBid);

        }

        [Fact]
        public void Test_average_difference()
        {
            var estimates = new List<double>
            {
                100,50,300,200,130
            };
            var highestBids = new List<double>
            {
                160,100,600,400,230
            };

            var difference = OfferUtility.GetAverageDifference(highestBids, estimates);

            Assert.Equal(142, difference);
        }
    }
}
