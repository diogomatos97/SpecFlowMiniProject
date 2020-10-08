Feature: SDBuy
In order to be able to buy items
As a loged in user  
I want to be able to select a product

@AddToCart
Scenario: Select Product
	Given I am loged in
	When I select a product
	Then I should see the cart icon displaying "1"

@AddToCart
Scenario: Select 2 Products
	Given I am loged in
	When I select two products
	Then I should see the cart icon displaying "2"

@GoToCart
Scenario: Go to cart
	Given I am loged in
	When I select a product
	And I Click on the cart button
	Then I should see the cart page

@CheckCartItems
Scenario: Check Cart
	Given I am loged in
	When I select <num> product
	And I Click on the cart button
	Then I should see the cart page
	And I should have <expected> product displaying

	Examples:
		| num | expected |
		| 1   | 1        |
		| 2   | 2        |
		| 3   | 3        |