Feature: LogIn

Verify user able to LogIn to Application

@userLogIn
Scenario: Verify User LogIn
	Given Navigate to LogInPage(BrowserType, Url)
	When  Verify user is On LogInPage
	Then  Enetr the username(userName)
	And  Enter the Password(usrPassword)
	Then   Click on LogIn Button 
