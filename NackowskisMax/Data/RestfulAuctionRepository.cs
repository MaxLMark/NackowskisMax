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
        private string url = "http://nackowskis.azurewebsites.net/api/Auktion";
        private const  int groupId = 1000;
        public RestfulAuctionRepository(IRestClient restClient)
        {
            _restClient = restClient;

        }
        public Task Create(AuctionItem auction)
        {

            //Hallo simppa!!! Funkar detta fint eller ? HALLOOOOOOO

            return _restClient.PostAsync<AuctionItem>(url, auction);

        }

        public Task Delete(int Id)
        {
            var urlstring = url + "/" + groupId + "/" + Id;
            return _restClient.DeleteAsync<AuctionItem>(urlstring);
        }

        public Task<AuctionItem[]> GetAllAsync(int groupId)
        {
            var urlstring = url + "/" + groupId;
            //HÄR HÄNDER DAS CRASH!!!!
            var items = _restClient.GetAsync<AuctionItem[]>(urlstring);

            return items;
        }

        public Task<AuctionItem> Get(int groupId, int Id)
        {
            var urlstring = url + "/" + groupId + "/" + Id;
            return _restClient.GetAsync<AuctionItem>(urlstring);
        }

        public Task Update(AuctionItem auction)
        {
            
            return _restClient.PutAsync<AuctionItem>(url, auction);
        }
    }
}
