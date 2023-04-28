Feature: Order calculation
	
Scenario Outline: Place and calculate order
	Given I place order
	  | Drinks   | Starters   | Mains   | Time   |
	  | <Drinks> | <Starters> | <Mains> | <Time> |
	When I get calculated total price with fees
	And I calculate expected order price
	Then I check calculated total price with fees
	Examples:
	  | Drinks | Starters | Mains | Time |
	  | 4      | 4        | 4     | Now  |	
		