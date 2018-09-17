using NackowskisMax.Data;
using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.BusinessLogic
{
    public class OfferBusiness
    {
        private readonly IOfferRepository _offerRepository;
        public OfferBusiness(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public Task CreateOffer(Offer offer)
        {
            return _offerRepository.Create(offer);
        }

        public Task DeleteOffer(int Id)
        {
            return _offerRepository.Delete(Id);
        }

        public async Task<Offer[]> GetAllOffersAsync(int auctionId)
        {

            var offers = await _offerRepository.GetAllAsync(auctionId);

            return offers;
        }

        public Task UpdateOffer(Offer auction)
        {
            return _offerRepository.Update(auction);
        }

        public async Task<int> CheckOfferBid(Offer[] offerlist, int offerSum)
        {
            int highestbid = 0;
            foreach (var bid in offerlist)
            {
                if (bid.Sum > highestbid)
                {
                    highestbid = bid.Sum;
                }
            }
            if (offerSum < highestbid)
            {
                throw new InvalidOperationException("You cant bid lower than the highest bid");
            }
            return highestbid;
        }
    }
}
