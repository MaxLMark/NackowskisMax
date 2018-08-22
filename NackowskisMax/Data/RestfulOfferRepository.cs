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
        public RestfulOfferRepository(IRestClient restClient)
        {
            restClient = _restClient;
        }
        public void Create(Offer offer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Offer> GetAll(int groupId)
        {
            throw new NotImplementedException();
        }

        public void Update(Offer auction)
        {
            throw new NotImplementedException();
        }
    }
}
