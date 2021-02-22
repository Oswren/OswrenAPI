using System;
using System.Collections.Generic;

namespace OswrenAPI.Domain.Models
{
    public class CardsCacheItem
    {
        public string Set { get; set; }
        public List<TcgCard> CardList { get; set; }
        public DateTime TimeLastRequested { get; set; }
    }
}
