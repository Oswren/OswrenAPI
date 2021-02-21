using System.Text.Json.Serialization;

namespace OswrenAPI.TCG.Models.MTG.Cards
{
    public class MtgLegality
    {
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("legality")]
        public string Legality { get; set; }
    }

}
