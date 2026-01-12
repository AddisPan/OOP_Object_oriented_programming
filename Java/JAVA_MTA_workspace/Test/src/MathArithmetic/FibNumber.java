package MathArithmetic;

import java.util.Scanner;

public class FibNumber {
	public static void main(String[] args) {
		int a=1, b=1, c;
		Scanner input = new Scanner(System.in);
		
		System.out.print("num1:");
		int n = input.nextInt();
		
		System.out.print(a + " " + b);
		
		for (int i = 2; i < n; i++)
		{
			c = a + b; // the third result = the second result + the first result
			System.out.print(" " + c); // print result
			a = b; // a move next b
			b = c; // b move next c
		}
	}
}
