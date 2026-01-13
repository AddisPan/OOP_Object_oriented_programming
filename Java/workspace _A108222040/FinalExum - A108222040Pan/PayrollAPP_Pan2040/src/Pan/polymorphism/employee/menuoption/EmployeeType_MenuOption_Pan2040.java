package Pan.polymorphism.employee.menuoption;

public enum EmployeeType_MenuOption_Pan2040 {
	// declare contents of enum type
	BaseEmployee(0, "Base-Employee"), 
	SalariedEmployee(1, "Salaried-Employee"), 
	HourlyEmployee(2, "Hourly-Employee"),
	CommissionEmployee(3, "Commission-Employee"), 
	BasePlusCommissionEmployee(4, "BasePlusCommission-Employee"),
	Quit(5, "Quit");

	private final int value; // current menu option
	private final String employeeType; // current menu option

	// constructor
	EmployeeType_MenuOption_Pan2040(int valueOption,String optionType) {
		value = valueOption;
		employeeType = optionType;
	}
	
	public int getValue()
	{
		return value;
	}
	
	public String getEmployeeType()
	{
		return employeeType;
	}
}