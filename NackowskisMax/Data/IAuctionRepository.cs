using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Data
{
    public interface IAuctionRepository
    {
        IEnumerable<AuctionItem> GetAll(int groupId);
        AuctionItem Get(int groupId, int Id);
        void Create(AuctionItem auction);
        void Delete(int Id);
        void Update(AuctionItem auction);
    }
}
