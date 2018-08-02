using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace DeckCardProject.Steps
{
    [Binding]
    class DeckCardSteps
    {
        [Test]
        [Given(@"I create the new deck")]
        public void GivenICreateTheNewDeck()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I draw the cards (.*) times from the deck")]
        public void WhenIDrawTheCardsTimesFromTheDeck(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the remaining cards count of the deck is accurate")]
        public void ThenTheRemainingCardsCountOfTheDeckIsAccurate()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
