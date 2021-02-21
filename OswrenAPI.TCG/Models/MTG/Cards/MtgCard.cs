using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OswrenAPI.TCG.Models.MTG.Cards
{
    public class MtgCard
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("manaCost")]
        public string ManaCost { get; set; }

        [JsonPropertyName("cmc")]
        public int Cmc { get; set; }

        [JsonPropertyName("colors")]
        public List<string> Colors { get; set; }

        [JsonPropertyName("colorIdentity")]
        public List<string> ColorIdentity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("supertypes")]
        public List<string> Supertypes { get; set; }

        [JsonPropertyName("types")]
        public List<string> Types { get; set; }

        [JsonPropertyName("subtypes")]
        public List<string> Subtypes { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("set")]
        public string Set { get; set; }

        [JsonPropertyName("setName")]
        public string SetName { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("flavor")]
        public string Flavor { get; set; }

        [JsonPropertyName("artist")]
        public string Artist { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("power")]
        public string Power { get; set; }

        [JsonPropertyName("toughness")]
        public string Toughness { get; set; }

        [JsonPropertyName("layout")]
        public string Layout { get; set; }

        [JsonPropertyName("multiverseid")]
        public int Multiverseid { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("rulings")]
        public List<MtgRuling> Rulings { get; set; }

        [JsonPropertyName("foreignNames")]
        public List<MtgForeignName> ForeignNames { get; set; }

        [JsonPropertyName("printings")]
        public List<string> Printings { get; set; }

        [JsonPropertyName("originalText")]
        public string OriginalText { get; set; }

        [JsonPropertyName("originalType")]
        public string OriginalType { get; set; }

        [JsonPropertyName("legalities")]
        public List<MtgLegality> Legalities { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("names")]
        public List<string> Names { get; set; }

        [JsonPropertyName("watermark")]
        public string Watermark { get; set; }
    }
}
