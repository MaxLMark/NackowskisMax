using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Data
{
    public interface IOfferRepository
    {
        Task<Offer[]> GetAllAsync(int auctionId);
        //AuctionItem GetOffer(int groupId, int Id);
        Task Create(Offer offer);
        Task Delete(int Id);
        Task Update(Offer auction);
    }
}
