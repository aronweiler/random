Feature: MainWindow

A short summary of the feature

	Scenario: Button is clicked when nothing is in the results textbox
		Given the result textbox is: '<null>'
		When the button is clicked
		Then the result should be: 'Clicked'

	Scenario: Button is clicked when something is in the results textbox
		Given the result textbox is: 'Clicked'
		When the button is clicked
		Then the result should be: '<null>'

	Scenario: Value retriever test				
		When the button is clicked the result matches
		| Starting Text | Resulting Text  |
		| Clicked | <null>  |
		| <null>  | Clicked |