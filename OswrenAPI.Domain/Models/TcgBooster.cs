using System.Collections.Generic;

namespace OswrenAPI.Domain.Models
{
    public class TcgBooster
    {
        public const int MtgStandardCommonCount = 10;
        public const int MtgStandardUncommonCount = 3;
        public const int MtgStandardRareOrMythicCount = 1;
        public const int MtgStandardLandCount = 1;

        public List<TcgCard> Cards { get; set; }
    }
}
