using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OswrenAPI.TCG.Models.MTG.Sets
{
    public class MtgSets
    {
        [JsonPropertyName("sets")]
        public List<MtgSet> Sets { get; set; }
    }
}
