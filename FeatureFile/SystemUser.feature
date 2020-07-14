Feature: SystemUser
	As the administrator of Orange Hrm page,
	I would like to add new user to system user page

@mytag
Scenario: Add new user

	Given I  login to Orange Hrm page administration
	And I have navigated to System User page
	Then I should be able to add new user successfiully.



