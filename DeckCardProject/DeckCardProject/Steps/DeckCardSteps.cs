using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using DeckCardProject.ModuleClasses;
using RestSharp;

namespace DeckCardProject.Steps
{
    [Binding]
    class DeckCardSteps
    {
        DeckCardRequests deck_request;

        [Test]
        [Given(@"I create the new deck")]
        public void GivenICreateTheNewDeck()
        {
            deck_request = new DeckCardRequests();
            var response = deck_request.CreateNewDeck();
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        [When(@"I draw the cards (.*) times from the deck")]
        public void WhenIDrawTheCardsTimesFromTheDeck(int no_of_times)
        {
            deck_request.DrawCardsForGivenTimes(Method.GET, no_of_times);
        }

        [Then(@"the remaining cards count of the deck is accurate")]
        public void ThenTheRemainingCardsCountOfTheDeckIsAccurate()
        {
            Assert.IsTrue(deck_request.IsRemainingCardsCorrect(), "Remaining deck cards count returned is not correct");
        }

    }
}
