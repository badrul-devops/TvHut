Feature: User Login
  As a registered user
  I want to be able to log in to the website
  So that I can access my account

  Scenario: Verify that an user can  log in with valid email and password
    Given the user is on the login page
    When the user enters valid login credentials
    And clicks the login button
    Then the user should be logged in successfully

  Scenario: Verify that an user can't  log in with invalid email and password
    Given the user is on the login page
    When the user enters invalid login credentials
    And clicks the login button
    Then an error message should be displayed
    And the user should not be logged in

  Scenario: Verify that an user can't  log in with valid email and invalid password
    Given the user is on the login page
    When the user enters invalid login credentials
    And clicks the login button
    Then an error message should be displayed
    And the user should not be logged in

  Scenario: Verify that an user can't  log in with invalid email and invalid password
    Given the user is on the login page
    When the user enters invalid login credentials
    And clicks the login button
    Then an error message should be displayed
    And the user should not be logged in