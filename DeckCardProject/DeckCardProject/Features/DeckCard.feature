Feature: DeckCard
The following Scenario checks for the number of cards remaining
after certain cards are drawn from teh deck


Scenario: Check if remaining cards count is correctly returned from the backend
	Given I create the new deck
	When I draw the cards 5 times from the deck 
	Then the remaining cards count of the deck is accurate
