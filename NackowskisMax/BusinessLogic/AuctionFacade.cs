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

        public IEnumerable<AuctionItem> GetAllAuctions()
        {
            return _auctionRepository.GetAll(groupId);
        }
        public AuctionItem GetAuction(int Id)
        {
            return _auctionRepository.Get(groupId, Id);
        }

        public void CreateAuction(AuctionItem auction)
        {
            _auctionRepository.Create(auction);
        }

        public void DeleteAuction(int Id)
        {
            _auctionRepository.Delete(Id);
        }

        public void UpdateAuction(AuctionItem auction)
        {
            _auctionRepository.Update(auction);
        }

        public void CreateOffer(Offer offer)
        {
            _offerRepository.Create(offer);
        }

        public void DeleteOffer(int Id)
        {
            _offerRepository.Delete(Id);
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            return _offerRepository.GetAll(groupId);
        }

        public void UpdateOffer(Offer auction)
        {
            _offerRepository.Update(auction);
        }
    }
}
