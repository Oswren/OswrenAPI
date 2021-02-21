using System.Text.Json.Serialization;

namespace OswrenAPI.TCG.Models.MTG.Cards
{
    public class MtgRuling
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
