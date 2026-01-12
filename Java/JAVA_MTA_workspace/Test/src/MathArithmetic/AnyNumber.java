package MathArithmetic;

import java.util.Scanner;

public class AnyNumber {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("輸入想要的數字(十進制值)");
		int num1 = input.nextInt();
		System.out.println("輸入想要的進制(2,3,5,8)");
		int num2 = input.nextInt();
		String result = number(num1,num2);
		System.out.println(result);
		
		
//		Scanner input1 = new Scanner(System.in);
//		System.out.println("輸入想要的數字(十進制值)");
//		int num3 = input1.nextInt();
//		System.out.println("輸入想要的進制(2,3,5,8)");
//		int num4 = input1.nextInt();
//		number2(num3,num4);
	}

	public static String number(int a, int b) {
		String ss = "";
		int n = 0;
		while(a > 0) {
		    n = (a%b);
		    ss += n;
			a/=b;
		}
		StringBuilder ssn = new StringBuilder(ss);
		ss = ssn.reverse().toString();
		return ss;
	}
	
	public static void number2(int a, int b) {
		int n = 0;
		if(a < b) {
			System.out.print(a);
		} else {
			number2(a/b, b);
			System.out.print(a%b);
		}
	}
	
}
