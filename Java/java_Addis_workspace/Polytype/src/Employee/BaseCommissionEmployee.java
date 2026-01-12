package Employee;

import java.lang.Object;

public class BaseCommissionEmployee extends CommissionEmployee{
	private double baseSalary;
	public BaseCommissionEmployee(String employee_name, String id,
								  double sales, double rate, double salary) {
		super(employee_name,id,sales,salary);
		setBaseSalary(salary);
	}
	public void setBaseSalary(double salary) {
		if(salary < 0) {
			baseSalary=0;
		}else{
			baseSalary=salary;
		}
	}
	public double getBaseSalary() {
		return baseSalary;
	}
	public double earnings() {
		return getBaseSalary()+super.earnings();
	}
	public String toString() {
		return String.format("%s%s%s: %.2f", "¦³©³Á~", super.toString(),
				"©³Á~",getBaseSalary());
	}
}