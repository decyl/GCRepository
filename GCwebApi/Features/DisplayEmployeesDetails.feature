Feature: DisplayEmployeesDetails


@get
Scenario Outline: Display All employees
	When I use Get all employee data API
	Then the system should return a valid object with <Status>
	And response should contain records in specific first and last employee from the list with a valid (<Name>,<Salary>,<Age>,<Id>)

Examples: 
	| Name          | Salary  | Age | Id   | Status |
	| Tiger Nixon   | 320800  | 61  | 1    | success|
	| Doris Wilder  | 85600   | 23  | 24   | success|

@get
Scenario Outline: Display one employee with an specific Id
	When I use Get a single employee data API for a user with an <Id>
	Then the system should return a valid object with <Status>
	And response should contain single record with a valid (<Name>,<Salary>,<Age>,<Id>)

Examples: 
	| Name          | Salary  | Age | Id   | Status |
	| Garrett Winters   | 170750  | 63  | 2    | success|