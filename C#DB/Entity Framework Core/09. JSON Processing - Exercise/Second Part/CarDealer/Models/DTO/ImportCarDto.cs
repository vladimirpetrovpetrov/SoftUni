using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models.DTO
{
    public class ImportCarDto
    {
        public ImportCarDto()
        {
            this.PartsIds = new HashSet<int>();
        }

        [JsonProperty("make")]
        public string Make { get; set; } = null!;

        [JsonProperty("model")]
        public string Model { get; set; } = null!;

        [JsonProperty("traveledDistance")]
        public int TraveledDistance { get; set; }

        [JsonProperty("partsId")]
        public virtual ICollection<int> PartsIds { get; set; }
    }
}
