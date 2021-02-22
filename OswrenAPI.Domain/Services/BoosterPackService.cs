using OswrenAPI.Domain.Interfaces;
using OswrenAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Services
{
    public class BoosterPackService : IBoosterPackService
    {
        private readonly ITcgReader _tcgBroker;

        public BoosterPackService(ITcgReader tcgBroker)
        {
            _tcgBroker = tcgBroker;
        }

        public async Task<IEnumerable<TcgCard>> GetBoosterPackForSetAsync(string set)
        {
            var cardList = await GetNonReferencedListOfCardsAsync(set);

            var allRaresAndMythics = cardList.Where(card => (card.Rarity == "Rare") || (card.Rarity == "Mythic")).ToList();
            var allUncommons = cardList.Where(card => (card.Rarity == "Uncommon")).ToList();
            var allCommons = cardList.Where(card => (card.Rarity == "Common") && !card.Type.Contains("Basic Land")).ToList();
            var allLands = cardList.Where(card => card.Type.Contains("Basic Land") && (card.Rarity != "Rare" && card.Rarity != "Mythic")).ToList();

            var randomlyPickedCommons = GetRandomCardsOfTypeFromSet(allCommons, TcgBooster.MtgStandardCommonCount);
            var randomlyPickedUncommons = GetRandomCardsOfTypeFromSet(allUncommons, TcgBooster.MtgStandardUncommonCount);
            var randomlyPickedRareOrMythic = GetRandomCardsOfTypeFromSet(allRaresAndMythics, TcgBooster.MtgStandardRareOrMythicCount);
            
            var randomlyPickedLandOrFoil = new List<TcgCard>();

            if (!allLands.Any() || ShouldPackContainFoil())
            {
                var foil = true;
                randomlyPickedLandOrFoil = GetRandomCardsOfTypeFromSet(cardList.ToList(), TcgBooster.MtgStandardLandCount, foil);
            }
            else
            {
                randomlyPickedLandOrFoil = GetRandomCardsOfTypeFromSet(allLands, TcgBooster.MtgStandardLandCount);
            }

            return randomlyPickedCommons.Concat(randomlyPickedUncommons).Concat(randomlyPickedRareOrMythic).Concat(randomlyPickedLandOrFoil).ToList();
        }

        private async Task<List<TcgCard>> GetNonReferencedListOfCardsAsync(string set)
        {
            var referencedCardList = await _tcgBroker.GetMTGCardListAsync(set);

            return referencedCardList.Select(card => card.Clone()).ToList();
        }

        private static bool ShouldPackContainFoil()
        {
            var foilRandomiser = new Random();
            return foilRandomiser.Next(4) == 1;
        }

        private static List<TcgCard> GetRandomCardsOfTypeFromSet(List<TcgCard> listOfSpecificCardType, int expectedNumberOfCardsOfType, bool foil = false)
        {
            var randomlyPickedCardsOfType = new List<TcgCard>();

            var rand = new Random();

            for (int i = 0; i < expectedNumberOfCardsOfType; i++)
            {
                var card = listOfSpecificCardType[rand.Next(listOfSpecificCardType.Count)];

                if (foil)
                {
                    card.Foil = true;
                }

                randomlyPickedCardsOfType.Add(card);
            }

            return randomlyPickedCardsOfType;
        }
    }
}
