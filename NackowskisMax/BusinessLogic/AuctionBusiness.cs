using NackowskisMax.Data;
using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.BusinessLogic
{
    public class AuctionBusiness
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IOfferRepository _offerRepository;
        private const int groupId = 1000;
        public AuctionBusiness(IAuctionRepository auctionRepository, IOfferRepository offerRepository)
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

        public async Task<List<AuctionItem>> ActivityChecker(AuctionItem[] auctionItems)
        {
            var auctionItemList = new List<AuctionItem>();
            foreach (var item in auctionItems)
            {
                var offerlist = await _offerRepository.GetAllAsync((int)item.Id);
                var today = DateTime.Now;
                var auctionEndDate = item.EndDate;

                var result = DateTime.Compare(today, auctionEndDate);

                if (result < 0)
                    item.Active = "Yes";
                else if (result == 0)
                    item.Active = "Yes";
                else
                    item.Active = "No";

                if (offerlist.Length > 0)
                {
                    foreach (var offer in offerlist)
                    {
                        item.OfferList.Add(offer);
                    }
                }

                auctionItemList.Add(item);
            }

            return auctionItemList;
        }

    }
}
