# ClearBankTechnicalTask
Clear Bank technical task repository


# Instructions to run the test:

## Pre-requisites:

* NUnit framework: 
	_You need to add nunit.framework dll to the project references using NuGet package manager_
* Specflow:
  _You need to add TechTalk.Specflow dll to the project references using NuGet package manager_
* RestSharp:
  _You need to add RestSharp dll to the project references using NuGet package manager_
  
## Steps to run the test:

* Go to Test Menu
* Go to Window SubMenu
* Go to Test Explorer
* Test Explorer will be opened
* Right click on the scenario named as "Check if remaining cards count is correctly returned from the backend" 
* Select Run Selected Tests sub menu

# Brief explanation on how the tests written

* DeckCardsRequest class:
_IT has all the operations that we need to do i.e. api calls along with the_

* Json object classes:
_This is the json object class for the responses returned from the API so that it is easy to fetch the required field values_

* Feature file:
_Gherkin language where we mention the tests in a simple English in BDD format_

* Step definition file:
_Each of the feature scenario steps are binded with the methods in here which are called when the steps are executed_

* Configuration file:
_Fetching the constant values stored in the app configuration file_

# What does the test do?

New deck card is created and the cards are drawn 5 times from the deck and checked if the remaining number of cards from the backend is accurate. 


