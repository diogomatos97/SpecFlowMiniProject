Feature: SDLogin
In order to be able to buy items
As a registered user  
I want to be able to sign in to my account

@login
Scenario: Invalid password
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "four"
	When I click the login button
	Then I should see an alert containing the error message "Username and password do not match"

@login
Scenario: Valid password
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the login button
	Then I should be on the products page