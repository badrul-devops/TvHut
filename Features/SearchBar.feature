Feature: Search Bar Functionality

  Scenario: Verify there if is a search bar in the webpage
    When I am on the main page
    And I search for the search bar
    Then I should see search bar
