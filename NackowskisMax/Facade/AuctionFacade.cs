using NackowskisMax.BusinessLogic;
using NackowskisMax.Data;
using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Facade
{
    public class AuctionFacade
    {
        private readonly AuctionBusiness _auctionBusiness;
        private readonly OfferBusiness _offerBusiness;
        private readonly IAuctionRepository _auctionRepository;
        private readonly IOfferRepository _offerRepository;
        private const int groupId = 1000;
        
        public AuctionFacade(IAuctionRepository auctionRepository, IOfferRepository offerRepository,AuctionBusiness auctionBusiness, OfferBusiness offerBusiness)
        {
            _auctionRepository = auctionRepository;
            _offerRepository = offerRepository;
            _auctionBusiness = auctionBusiness;
            _offerBusiness = offerBusiness;
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
            
            return _auctionBusiness.CreateAuction(auction);
        }

        public Task DeleteAuction(int Id)
        {
            return _auctionBusiness.DeleteAuction(Id);
        }

        public Task UpdateAuction(AuctionItem auction)
        {
            return _auctionBusiness.UpdateAuction(auction);
        }

        public Task CreateOffer(Offer offer)
        {
            return _offerBusiness.CreateOffer(offer);
        }

        public Task DeleteOffer(int Id)
        {
           return _offerBusiness.DeleteOffer(Id);
        }

        public async Task<Offer[]> GetAllOffersAsync(int auctionId)
        {

            var offers = await _offerBusiness.GetAllOffersAsync(auctionId);

            return offers;
        }

        public Task UpdateOffer(Offer auction)
        {
            return _offerBusiness.UpdateOffer(auction);
        }

        public async Task<List<AuctionItem>> CheckActivity(AuctionItem[] auctionItems)
        {
            var auctionList = await _auctionBusiness.ActivityChecker(auctionItems);
            return auctionList;
        }

        public async Task<int> CheckOfferBid(Offer[] offerlist, int offerSum)
        {

            return await _offerBusiness.CheckOfferBid(offerlist, offerSum);
        }
    }
}
