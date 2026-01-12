package MathArithmetic;

import java.util.Scanner;

public class ArrayFib {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		long [] fib = new long[input.nextInt()];
		long a=1,b=1,c=2;
		
		fib[0]=fib[1]=1;
		
		for (int i = 2; i < fib.length; i++)
		{
			fib[i] = fib[i-1] + fib[i-2]; // the third result = the second result + the first result
			System.out.println(fib[i]); // print result
		}

	}

}
