using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackowskisMax.Models
{
    public class AuctionItem
    {
        [JsonProperty("AuktionID")]
        public int? Id { get; set; }
        [JsonProperty("Titel")]
        public string Title { get; set; }
        [JsonProperty("Beskrivning")]
        public string Description { get; set; }
        [JsonProperty("StartDatum")]
        public DateTime StartDate { get; set; }
        [JsonProperty("SlutDatum")]
        public DateTime EndDate { get; set; }
        [JsonProperty("Gruppkod")]
        public int GroupId { get; set; }
        [JsonProperty("Utropspris")]
        public int? Estimate { get; set; }
        [JsonProperty("SkapadAv")]
        public string CreatedBy { get; set; }

        public List<Offer> OfferList = new List<Offer>();

    }

}
