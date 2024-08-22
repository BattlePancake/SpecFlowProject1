Feature: V

@TearDown
Scenario: Open Page and fill the fields
	Given Open page https://app.qase.io/login
	When Fill 1testprojectv1@gmail.com into the Email field
	And Fill ewq1edc2esz3W! into the Password field
	When Click on Sign In Button
	And Click on Profile Icon
	And Click on Profile Link
	Then Check that Your First Name is correct