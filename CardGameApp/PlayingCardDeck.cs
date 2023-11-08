using System;
using System.Collections.Generic;
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

	}
}
