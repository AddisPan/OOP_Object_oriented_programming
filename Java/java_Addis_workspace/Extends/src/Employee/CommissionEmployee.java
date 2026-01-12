package Employee;

import java.lang.Object;

public class CommissionEmployee extends Object{
	private String name;
	private String idNumber;
	private double salesTotal;
	private double rateCommission;
	public CommissionEmployee(String employeeName, String id, double sales, double rate){
		name=employeeName;
		idNumber=id;
		setGrossSales(sales);
		setrateCommission(rate);
	}
	public void setName(String name){
		name=name;
	}
	public String getName(){
		return name;
	}
	public void setid(String id){
		idNumber=id;
	}
	public String getid(){
		return idNumber;
	}
	public void setGrossSales(double sales){
		if(sales<0){
			salesTotal=0;
		} else {
			salesTotal=sales;
		}
	}
	public double getGrossSales(){
		return salesTotal;
	}
	public void setrateCommission(double rate){
		if(rate<0){
			rateCommission=0;
		} else {
			rateCommission=rate;
		}
	}
	public double getrateCommission(){
		return rateCommission;
	}
	public double earnings(){
		return rateCommission*salesTotal;
	}
	@Override	//改寫Object類別的toString()
	public String toString(){
		return String.format("%s: %s\n%s: %s\n%s: %.2f\n%s:%.2f", "員工姓名"
				,name, "身分編號", idNumber, "業績",  salesTotal,
				 "佣金比率", rateCommission);
	}
}