using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NackowskisMax.Models;
using NackowskisMax.Utility.Http;

namespace NackowskisMax.Data
{
    public class RestfulAuctionRepository : IAuctionRepository
    {
        private readonly IRestClient _restClient;
        private string url = "http://nackowskis.azurewebsites.net/api/Auktion/1000";
        public RestfulAuctionRepository(IRestClient restClient)
        {
            restClient = _restClient;
            
        }
        public void Create(AuctionItem auction)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuctionItem> GetAll(int groupId)
        {
           // FIX THIS
            return _restClient.GetAsync(typeof(IEnumerable<AuctionItem>))(url);
        }

        public AuctionItem Get(int groupId, int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(AuctionItem auction)
        {
            throw new NotImplementedException();
        }
    }
}
