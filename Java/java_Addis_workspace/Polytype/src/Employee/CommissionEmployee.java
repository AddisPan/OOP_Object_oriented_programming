package Employee;

import java.lang.Object;

public class CommissionEmployee{
	private String name;
	private String id_number;
	private double sales_total;
	private double rate_commission;
	public CommissionEmployee(String employee_name,
			String id, double sales, double rate) {
		name=employee_name;
		id_number=id;
		setGross_sales(sales);
		setrate_commission(rate);
	}
	public void setName(String name) {
		name=name;
	}
	public String getName() {
		return name;
	}
	
	public void setid(String id) {
		id_number=id;
	}
	public String getid() {
		return id_number;
	}	
	
	public void setGross_sales(double sales) {
		if(sales < 0) {
			sales_total=0;
		}else{
			sales_total=sales;
		}
	}
	public double getGross_sales() {
		return sales_total;
	}
	
	public void setrate_commission(double rate) {
		if(rate < 0) {
			rate_commission=0;
		}else{
			rate_commission=rate;
		}
	}
	public double getrate_commission() {
		return rate_commission;
	}
	public double earnings() {
		return getrate_commission()*getGross_sales();
	}
	public String toString() {
		return String.format("%s: %s\n%s: %s\n%s: %.2f\n%s:%.2f\n", 
				"員工姓名", getName(), "身分編號", getid(), "業績",
				getGross_sales(), "傭金比率", getrate_commission());
	}
}