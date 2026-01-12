package Factorial;

import java.util.Scanner;

public class Factorial{
	public static void main(String[] args){
		double m,n;
		Scanner scan=new Scanner(System.in);
		System.out.println("n!運算");
		System.out.println("請輸入整數n:");
		n=scan.nextDouble();
		System.out.println(n+"!的值是"+factorial(n));
	}
	public static double factorial(double n){
		double ans;
		if(n==0){
			ans=1;
		}else{
			ans=n*factorial(n-1);
		}
		return ans;
	}
}