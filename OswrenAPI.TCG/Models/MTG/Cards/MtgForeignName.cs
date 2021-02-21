using System.Text.Json.Serialization;

namespace OswrenAPI.TCG.Models.MTG.Cards
{
    public class MtgForeignName
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("flavor")]
        public string Flavor { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("multiverseid")]
        public int Multiverseid { get; set; }
    }
}
