using System.Collections.Generic;

namespace OswrenAPI.TCG.Models
{
    public class MtgSet
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Booster { get; set; }
        public string ReleaseDate { get; set; }
        public string Block { get; set; }
        public bool OnlineOnly { get; set; }
    }
}
