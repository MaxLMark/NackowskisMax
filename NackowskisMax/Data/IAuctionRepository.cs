using NackowskisMax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Data
{
    public interface IAuctionRepository
    {
        Task<AuctionItem[]> GetAllAsync(int groupId);
        Task<AuctionItem> Get(int groupId, int Id);
        Task Create(AuctionItem auction);
        Task Delete(int Id);
        Task Update(AuctionItem auction);
    }
}
