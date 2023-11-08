using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp
{
	public class PlayingCard
	{
		public bool isCardVisible { get; set; }

		public RankEnums Rank {  get; }

		public SuitEnums Suit { get; }

        public PlayingCard(RankEnums rank, SuitEnums suit)
        {
            Rank = rank;
			Suit = suit;

        }
		
		//Card = new ((PlayingCardsValue)i, (PlayingCardsType)j);

		public enum RankEnums
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

		public enum SuitEnums
		{
			Clubs,
			Diamonds,
			Hearts,
			Spades
		}

		public override string ToString()
		{
			return $"{Rank} of {Suit}";
		}
	}
}
