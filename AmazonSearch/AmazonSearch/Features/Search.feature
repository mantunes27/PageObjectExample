Feature: Search
	As an Amazon user
	I want to use the search function
	so that I can find the item I want

@mytag
Scenario: Check Price
	Given I have navigated to Amazon
	And I typed game of thrones a song of ice and fire
	When I press the search button 
	Then the price of the book should be £7.99
