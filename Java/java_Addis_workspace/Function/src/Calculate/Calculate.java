package Calculate;

import java.util.Scanner;

public class Calculate{
	public static void main(String[] args){
		double pay,n,yr_rate;
		Scanner scan=new Scanner(System.in);
		System.out.println("定期存款,複利法計算本利合");
		System.out.println("請輸入本金:");
		pay=scan.nextDouble();
		System.out.println("請輸入年利率:");
		yr_rate=scan.nextDouble();
		System.out.println("請輸入幾年後:");
		n=scan.nextDouble();
		System.out.println("本利合"+finance(pay,n,yr_rate));
	}
	public static double finance(double pay ,double n ,double yr_rate){
		for(int i=1;i<=n;i++){
			pay=pay*(1+yr_rate/100);
		}
		return pay;
	}
}