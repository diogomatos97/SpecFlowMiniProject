Feature: SDCheckout
In order to be able to buy items
As a loged in user  
I want to be able to pay for a product

@CheckoutStepOne
Scenario: Checkout
	Given I am have selected a product
	When I click on the checkout button
	Then I should see the Checkout page

@CheckoutStepTwo
Scenario: Checkout2
	Given I am on the checkout page
	When I fill the required field
	And I press continue
	Then I should be on the confirmation page

@CheckoutStepTwo
Scenario: CheckoutFinal
	Given I am on the confirmation page
	When I press finish
	Then I should see that my order has been dispatched