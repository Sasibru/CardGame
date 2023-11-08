namespace CardGameApp.UnitTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Count_TotalCards_ReturnSum()
		{
			PlayingCardDeck playingCardDeck = new();
			playingCardDeck.CreateDeck();

			int totalCards = playingCardDeck.deckList.Count();
			int expected = 52;

			Assert.That(expected, Is.EqualTo(totalCards));
		}

		[Test]
		public void VisibleCard_ViewBoolOutput_ReturnResult()
		{
			PlayingCard boolTest = new();
			boolTest.SetIsCardVisible(true);
			bool result = boolTest.IsCardVisible;

			bool expected = true;

			Assert.That(expected, Is.EqualTo(result));
		}
	}
}