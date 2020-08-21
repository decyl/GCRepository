Feature: Create Employee

@post
Scenario Outline: Create employee
	When I create a new employee (<Name>,<Salary>,<Age>)
	Then the system should return a valid object with <Status>
	And response should contain valid <Name>

Examples: 
	| Name  | Salary | Age | Status |
	| Ala B | 25.78  | 23  | success|









