Feature: Using Background
	In order to avoid duplicate setup steps and unreadable scenarios
	As a SpecFlow student
	I want to learn how to extract common setup steps into a Background

Scenario: Addition
	Given I have a calculator
	And the calculator shows 5 in its display
	When I add 5
	Then the calculator shows 10 in its display

Scenario: Multiplication
	Given I have a calculator
	And the calculator shows 5 in its display
	When I multiply with 3
	Then the calculator shows 15 in its display

Scenario: Subtraction
	Given I have a calculator
	And the calculator shows 5 in its display
	When I subtract 2
	Then the calculator shows 3 in its display
