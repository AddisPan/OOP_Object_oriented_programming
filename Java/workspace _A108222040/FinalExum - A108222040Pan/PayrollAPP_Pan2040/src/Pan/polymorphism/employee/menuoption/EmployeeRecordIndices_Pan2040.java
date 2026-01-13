package Pan.polymorphism.employee.menuoption;
// Fig. 15.7: MenuOption.java
// enum type for the credit-inquiry program's options.
public enum EmployeeRecordIndices_Pan2040 {
	// declare contents of enum type
	COMPANY_NAME     (0, "Company name"), 
	EMPLOYEE_NO      (1, "No of Employees"), 
	SSN              (2, "SSN"),
	FIRST_NAME       (3, "First Name"), 
	LAST_NAME        (4, "Last Name"),
	WEEKLY_SALARY    (5, "Weekly S."),
	HOURLY_WAGE      (6, "Hourly W."),
	HOURS_WORKED     (7, "Work Hours"),
	GROSS_SALES      (8, "G. Sales"),
	Commission_RATE  (9, "C. Rate"),
	Base_SALARY      (10, "Base Salary"),
	EARINGS          (11, "Earings"),
	Employ_COUNTER   (12, "Employee Counter"),
	LOWEST_EARINGS   (13, "Lowest E."),
	HIGHEST_EARINGS  (14, "Highest E."),
	AVERAGE_EARINGS  (15, "Average E."),
	WAGE_LEVEL       (16, "Wage Level"),
	INDEX_COLOR      (17, "Index Color"),
	EXTRA_HOURS_RATE (18, "Rate_EH"),
	MAX_WORKED_HOURS (168, "Max Worked-Hours");

   private final int value; // current menu option
   private final String recordIndexType; // current menu option

    // constructor
	EmployeeRecordIndices_Pan2040(int valueOption,String optionT) {
		value = valueOption;
		recordIndexType = optionT;
	}
	
	public int getValue()
	{
		return value;
	}
	
	public String getRecordIndexType()
	{
		return recordIndexType;
	}
} 