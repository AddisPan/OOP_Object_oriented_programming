package Fibonacci;

import java.util.Scanner;

public class Fibonacci{
	public static void main(String[] args){
		double m,n;
		Scanner scan=new Scanner(System.in);
		System.out.println("費式係數運算");
		System.out.println("請輸入整數n:");
		n=scan.nextDouble();
		System.out.println(n+"的費式係數是:"+fib(n));
	}
	public static double fib(double n){
		double ans;
		if(n==0){
			ans=0;
		}else if(n==1){
			ans=1;
		}else{
			ans=fib(n-1)+fib(n-2);
		}
		return ans;
	}
}