import java.util.Date;
public class Asset{
	private double interest;
	private int years;
	private double amount;
	private java.util.Date depositeDate;
	public Asset(){
		this(1.05,3,2000000);
	}
	public Asset(double interest,int years,double amount){
		this.interest=interest;
		this.years=years;
		this.amount=amount;
		depositeDate=new java.util.Date();
	}
	public double getinterest(){
		return interest;
	}
	public int getyear(){
		return years;
	}
	public void setyears(int years){
		this.years=years;
	}
	public double getamount(){
		return amount;
	}
	public void setamount(double amount){
		this.amount=amount;
	}
	public java.util.Date getdepositeDate(){
		return depositeDate;
	}
	public double payment(){
		return amount*(Math.pow((1+interest/100),years));
	}
}