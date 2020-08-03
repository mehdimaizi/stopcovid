using System;
using System.Text.Json.Serialization;
namespace stopcovid.Models
{
    using System;
    public class ActualiteCovid
    {
         
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("info")]
        public string Actualitedujour { get; set; }

        [JsonPropertyName("source")]
        public string Provenance { get; set; }


    }


}





