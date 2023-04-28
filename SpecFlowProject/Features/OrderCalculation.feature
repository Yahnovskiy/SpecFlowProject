Feature: Order calculation

Scenario: Add two numbers
	Given Calculate total price
	| Food     | Count |
	| Drinks   | 4     |
	| Starters | 4     |
	| Mains    | 4     |
 Then I should have '11.88'
