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
		private bool IsCardVisible { get; set; }

		public RankEnums Rank {  get; }

		public SuitEnums Suit { get; }

        public PlayingCard(RankEnums rank = 0, SuitEnums suit = 0)
        {
            Rank = rank;
			Suit = suit;

        }

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

		public void SetIsCardVisible(bool input)
		{
			IsCardVisible = input;
		}

		public override string ToString()
		{
			return $"{Rank} of {Suit}";
		}
	}
}
