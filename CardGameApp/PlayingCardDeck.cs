using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CardGameApp.PlayingCard;

namespace CardGameApp
{
	public class PlayingCardDeck
	{

		public List<PlayingCard> deckList = new();

		public void CreateDeck()
		{
			deckList = new List<PlayingCard>();
			foreach(SuitEnums suit in Enum.GetValues(typeof(SuitEnums)))
			{
				foreach(RankEnums rank in Enum.GetValues(typeof(RankEnums)))
				{
					if(rank == 0)
					{
						continue;
					}
					else
					{
					deckList.Add(new PlayingCard(rank, suit));
					}
				}
			}
		}

		public bool ContainsAllCards()
		{
			CreateDeck();
			//int clubsCount = deckList.Count(card => card.Suit == PlayingCard.SuitEnums.Clubs);
			//int spadesCount = deckList.Count(card => card.Suit == PlayingCard.SuitEnums.Spades);
			//int heartsCount = deckList.Count(card => card.Suit == PlayingCard.SuitEnums.Hearts);
			//int diamondsCount = deckList.Count(card => card.Suit == PlayingCard.SuitEnums.Diamonds);

			//return (clubsCount == 13 || spadesCount == 13 || heartsCount == 13 || diamondsCount == 13);

			if (deckList.Count != deckList.Distinct().Count() && deckList.Count == 52)
			{
				return false;
			}
			else
			{
				return true;
			}
			
		}

	}
}
