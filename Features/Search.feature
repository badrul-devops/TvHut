Feature: Searching for electronic goods
Scenario: Verify that user can search any product from the search bar

Given the user is on the homepage
When the user enters Router in the search bar
And clicks the search button
Then the user should see a list of Router