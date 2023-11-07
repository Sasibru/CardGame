using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp
{
	public class PlayingCardDeck
	{
		List<PlayingCard> deckList = new();
		public PlayingCard.PlayingCardsType PlayingCardType { get; private set; }
		public PlayingCard.PlayingCardsValue PlayingCardValue { get; private set; }
		public void CreateCard(PlayingCard.PlayingCardsType playingCardType, PlayingCard.PlayingCardsValue playingCardValue)
		{
			PlayingCardType = playingCardType;
			PlayingCardValue = playingCardValue;
		}

		public void CreateDeck()
		{
			
		}

	}
}
