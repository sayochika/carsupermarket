Feature: CustomerCanSearchForCar
	In order to buy a car of my choice 
	As a customer 
	I want the ability to search for a car of my choice


Scenario Outline: Customer can search for any car of their choice
	Given I navigate to carsupermarket homepage
	When I enter postcode as "<Postcode>"
	And I select the car "<Make>"
	And I select the corresponding car "<Model>"
	And I click on the Search button
	Then car "<Make>" is displayed
	
Scenarios:
 | Make | Model | Postcode |
 | Audi | A6    | OL9 8LE  |
