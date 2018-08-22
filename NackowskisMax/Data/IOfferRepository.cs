using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Data
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> GetAll(int groupId);
        //AuctionItem GetOffer(int groupId, int Id);
        void Create(Offer offer);
        void Delete(int Id);
        void Update(Offer auction);
    }
}
