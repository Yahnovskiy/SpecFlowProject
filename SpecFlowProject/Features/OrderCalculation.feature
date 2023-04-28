Feature: Order calculation
	
Scenario Outline: Place and calculate order
	Given I store my order
	  | Drinks   | Starters   | Mains   | Time   |
	  | <Drinks> | <Starters> | <Mains> | <Time> |
	When I place order and get calculated total price with fees
	And I calculate expected order price
	Then I check calculated total price with fees
	Examples:
	  | Drinks | Starters | Mains | Time |
	  | 4      | 4        | 4     | Now  |	
   
	Scenario Outline: Place, update and calculate order with time
		Given I store my order
		  | Drinks         | Starters         | Mains         | Time         |
		  | <DrinksBefore> | <StartersBefore> | <MainsBefore> | <TimeBefore> |
		And I place order and get calculated total price with fees
		And I calculate expected order price
		And I check calculated total price with fees
		When I add food to my order when drinks non discounted
		  | Drinks        | Starters        | Mains        | Time        |
		  | <DrinksAfter> | <StartersAfter> | <MainsAfter> | <TimeAfter> |
		And I place order with new items and get calculated total price with fees
		Then I check calculated total price with fees
		Examples:
		  | DrinksBefore | StartersBefore | MainsBefore | TimeBefore | DrinksAfter | MainsAfter | TimeAfter |
		  | 2            | 1              | 2           | 18:00      | 2                  | 2                 | 20:00     |

Scenario Outline: Place, update and calculate order
	Given I store my order
	  | Drinks   | Starters   | Mains   | Time   |
	  | <Drinks> | <Starters> | <Mains> | <Time> |
	And I place order and get calculated total price with fees
	And I calculate expected order price
	And I check calculated total price with fees
	When I update current order
	  | Drinks          | Starters          | Mains          | Time   |
	  | <DrinksUpdated> | <StartersUpdated> | <MainsUpdated> | <Time> |
	And I calculate expected order price
	Then I check calculated total price with fees
	Examples:
	  | Drinks | Starters | Mains | Time | DrinksUpdated | StartersUpdated | MainsUpdated |
	  | 4      | 4        | 4     | Now  | 3             | 3               | 3            |
		