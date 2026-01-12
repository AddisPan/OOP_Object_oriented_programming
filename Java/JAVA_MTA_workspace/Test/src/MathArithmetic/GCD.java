package MathArithmetic;

import java.util.Scanner;

public class GCD {

	int a,b;
	public GCD(int a1, int b1) {
		this.a = a1;
		this.b = b1;
	}
	public static int gcd(int a, int b) {
		if (a % b == 0)
			return b;
		else
			return gcd(b, a%b);
	}
	
	public void result() {
//		Scanner input = new Scanner(System.in);
//		int num1 = input.nextInt();
//		int num2 = input.nextInt();
		int result = gcd(a, b);
		System.out.println(result);
	}
	
//	public static void main(String[] args) {
//		Scanner input = new Scanner(System.in);
//		int num1 = input.nextInt();
//		int num2 = input.nextInt();
//		int result = gcd(num1, num2);
//		System.out.println(result);
//	}

}
