namespace CardGameApp.UnitTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void CreateDeck_ListCount_ReturnSum()
		{
			PlayingCardDeck playingCardDeck = new();
			playingCardDeck.CreateDeck();

			int totalCards = playingCardDeck.deckList.Count();
			int expected = 52;

			Assert.That(expected, Is.EqualTo(totalCards));
		}

		[Test]
		public void ContainsAllCards_CheckAllSuitsAndRanks_ReturnSum()
		{
			PlayingCardDeck playingCardDeck = new();
			bool testMethod = playingCardDeck.ContainsAllCards();

			bool expected = true;

			Assert.That(testMethod, Is.EqualTo(expected));
		}

		[Test]
		public void SetIsCardVisible_SetToTrue_ReturnBoolOutput()
		{
			PlayingCard boolTest = new();
			boolTest.SetIsCardVisible(true);
			bool result = boolTest.GetIsCardVisible();

			bool expected = true;

			Assert.That(expected, Is.EqualTo(result));
		}
	}
}