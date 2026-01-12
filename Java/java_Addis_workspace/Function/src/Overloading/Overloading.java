package Overloading;

public class Overloading{
	public static void main(String[] args){
		Overloading ov=new Overloading();
		ov.max(1.5,2.222);
		ov.max(3,2);
	}
	public static void max(double a, double b){
		if(a>b)
			System.out.println("硂琌疊翴计"+a);
		else
			System.out.println("硂琌疊翴计"+b);
	}
	
	public static void max(int a, int b){
		if(a>b)
			System.out.println("硂琌疊翴计"+a);
		else
			System.out.println("硂琌疊翴计"+b);
	}
}