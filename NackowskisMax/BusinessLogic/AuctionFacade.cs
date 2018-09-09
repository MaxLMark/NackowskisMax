using NackowskisMax.Data;
using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.BusinessLogic
{
    public class AuctionFacade
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IOfferRepository _offerRepository;
        private const int groupId = 1000;
        public AuctionFacade(IAuctionRepository auctionRepository, IOfferRepository offerRepository)
        {
            _auctionRepository = auctionRepository;
            _offerRepository = offerRepository;
        }

        public Task<AuctionItem[]> GetAllAuctionsAsync()
        {
            //var auctions = await _auctionRepository.GetAllAsync(groupId);

            return _auctionRepository.GetAllAsync(groupId);
        }
        public Task<AuctionItem> GetAuctionAsync(int Id)
        {
            return _auctionRepository.Get(groupId, Id);
        }

        public Task CreateAuction(AuctionItem auction)
        {
            return _auctionRepository.Create(auction);
        }

        public Task DeleteAuction(int Id)
        {
            return _auctionRepository.Delete(Id);
        }

        public Task UpdateAuction(AuctionItem auction)
        {
            return _auctionRepository.Update(auction);
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
    }
}
