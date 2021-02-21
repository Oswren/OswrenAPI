using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OswrenAPI.TCG.Models.MTG.Cards
{
    public class MtgCards
    {
        [JsonPropertyName("cards")]
        public List<MtgCard> Cards { get; set; }
    }
}
