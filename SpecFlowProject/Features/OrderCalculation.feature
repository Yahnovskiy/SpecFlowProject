Feature: Order calculation
	In the first three scenarios implemented calculation expected order values via automation code
	In the next three scenarios implemented hardcoded expected order value with fees
	
#calculated expected values via automation code
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
	And I calculate expected order price with additional items
	Then I check calculated total price with fees
	Examples:
	  | DrinksBefore | StartersBefore | MainsBefore | TimeBefore | DrinksAfter | MainsAfter | TimeAfter |
	  | 2            | 1              | 2           | 18:00      | 2           | 2          | 20:00     |

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
	
#utilized hardcoded expected values via constants in Examples tables
Scenario Outline: Place and calculate order (with constant expected result)
	Given I store my order
	  | Drinks   | Starters   | Mains   | Time   |
	  | <Drinks> | <Starters> | <Mains> | <Time> |
	When I place order and get calculated total price with fees
	And I calculate expected order price
	Then I check calculated total price with fees
	Examples:
	  | Drinks | Starters | Mains | Time | TotalPrice |
	  | 4      | 4        | 4     | Now  |            |
   
Scenario Outline: Place, update and calculate order with time (with constant expected result)
	Given I store my order
	  | Drinks         | Starters         | Mains         | Time         |
	  | <DrinksBefore> | <StartersBefore> | <MainsBefore> | <TimeBefore> |
	And I place order and get calculated total price with fees
	And Total price with fees should be '<TotalPriceBefore>'
	When I add food to my order when drinks non discounted
	  | Drinks        | Starters        | Mains        | Time        |
	  | <DrinksAfter> | <StartersAfter> | <MainsAfter> | <TimeAfter> |
	And I place order with new items and get calculated total price with fees
	Then Total price with fees should be '<TotalPriceAfter>'
	Examples:
	  | DrinksBefore | StartersBefore | MainsBefore | TimeBefore | TotalPriceBefore | DrinksAfter | MainsAfter | TimeAfter | TotalPriceAfter | 
	  | 2            | 1              | 2           | 18:00      |    23.65         | 2           | 2          | 20:00     |   44.55         | 

Scenario Outline: Place, update and calculate order (with constant expected result)
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
	  | Drinks | Starters | Mains | Time | DrinksUpdated | StartersUpdated | MainsUpdated | TotalPrice | TotalPriceWithUpdated |
	  | 4      | 4        | 4     | Now  | 3             | 3               | 3            |            |                       |