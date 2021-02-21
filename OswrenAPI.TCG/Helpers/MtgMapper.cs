using OswrenAPI.TCG.Models.MTG.Cards;
using OswrenAPI.TCG.Models.MTG.Sets;
using System.Collections.Generic;
using System.Linq;

namespace OswrenAPI.TCG.Helpers
{
    public static class MtgMapper
    {
        public static List<Domain.Models.TcgSet> MapSetLists(List<MtgSet> setList)
        {
            var mappedSets = new List<Domain.Models.TcgSet>();
            foreach (var set in setList)
            {
                mappedSets.Add
                (
                    new Domain.Models.TcgSet
                    {
                        Code = set.Code,
                        Name = set.Name,
                        Type = set.Type,
                        ReleaseDate = set.ReleaseDate
                    }
                );
            }

            return mappedSets.OrderBy(mappedSet => mappedSet.ReleaseDate).ToList();
        }

        public static List<Domain.Models.TcgCard> MapCardList(List<MtgCard> cardList)
        {
            var mappedCards = new List<Domain.Models.TcgCard>();
            foreach(var card in cardList)
            {
                var isNonFoilCard = int.TryParse(card.Number, out int parsedNumber);

                if(isNonFoilCard)
                {
                    mappedCards.Add
                    (
                        new Domain.Models.TcgCard
                        {
                            Id = card.Id,
                            Name = card.Name,
                            Text = card.Text,
                            Rarity = card.Rarity,
                            Set = card.Set,
                            SetNumber = parsedNumber,
                            SetNumberString = parsedNumber + $"/{cardList.Count}",
                            ImageUrl = card.ImageUrl,
                            Type = card.Type,
                            Foil = false
                        }
                    );
                }   
            }

            return mappedCards.OrderBy(mappedCard => mappedCard.SetNumber).ToList();
        }
    }
}
