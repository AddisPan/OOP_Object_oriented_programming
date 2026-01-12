package Multiply;

import java.util.Scanner;

public class Multiply{
	public static void main(String[] args){
		double m,n;
		Scanner scan=new Scanner(System.in);
		System.out.println("m*n乘法運算");
		System.out.println("請輸入m");
		m=scan.nextDouble();
		System.out.println("請輸入整數n");
		n=scan.nextDouble();
		System.out.println("m*n="+multiply(m,n));
	}
	public static double multiply(double m,double n){
		double ans;
		if(n==1){
			ans=m;
		}else{
			ans=m+multiply(m,n-1);
		}
		return ans;
	}
}