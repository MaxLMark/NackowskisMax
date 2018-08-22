using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Models
{
    public class Offer
    {
        [JsonProperty("BudID")]
        public int Id { get; set; }
        [JsonProperty("Summa")]
        public int Sum { get; set; }
        [JsonProperty("AuktionID")]
        public int AuctionId { get; set; }
        [JsonProperty("Budgivare")]
        public string Bidder { get; set; }

    }
}
