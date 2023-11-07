using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp
{
	public class PlayingCard
	{
		public enum PlayingCards
		{
			None,
			Ace,
			Two,
			Three,
			Four,
			Five,
			Six,
			Seven,
			Eight,
			Nine,
			Ten,
			Jack,
			Queen,
			King
		}

		public enum PlayingCardsType
		{
			Clubs,
			Diamonds,
			Hearts,
			Spades
		}

		public bool isCardVisible = false;

	}
}
