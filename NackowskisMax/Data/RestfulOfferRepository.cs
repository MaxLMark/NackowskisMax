using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NackowskisMax.Models;
using NackowskisMax.Utility.Http;

namespace NackowskisMax.Data
{
    public class RestfulOfferRepository : IOfferRepository
    {
        private readonly IRestClient _restClient;
        private string url = "http://nackowskis.azurewebsites.net/api/Bud";
        private const int groupId = 1000;
        public RestfulOfferRepository(IRestClient restClient)
        {
            _restClient = restClient;
        }
        public Task Create(Offer offer)
        {
            return _restClient.PostAsync<Offer>(url, offer);
        }

        public Task Delete(int Id)
        {
            var urlstring = url + "/" + 0 + "/" + Id;
            return _restClient.DeleteAsync<Offer>(urlstring);
        }

        public Task<Offer[]> GetAllAsync(int auctionId)
        {
            var urlstring = "/" + 0 + "/" + auctionId;
            return _restClient.GetAsync<Offer[]>(urlstring);
        }

        //OBS: Funktionaliteten verkar saknas från APIn
        public Task Update(Offer auction)
        {
            var urlstring = url + "/" + 0 + "/" + auction.Id;
            return _restClient.PostAsync<Offer>(urlstring, auction);
        }
    }
}
