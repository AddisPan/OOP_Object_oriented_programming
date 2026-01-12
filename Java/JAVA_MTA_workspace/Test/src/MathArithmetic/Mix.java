package MathArithmetic;

import java.util.Scanner;

public class Mix {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.print("num1:");
		int n = input.nextInt();

		for (int i = 1; i < n+1; i++) {
			for (int j = 1; j < n+1; j++) {
				System.out.print(i + "*" + j + "=" + i * j + "\t");
			}
			System.out.println("");
		}

		System.out.println("-----------------------");
		

		for (int i = 1; i < 10; i++) {
			for (int j = n+1; j < 10; j++) {
				System.out.print(i + "*" + j + "=" + i * j + "\t");
			}
			System.out.println("");
		}

//		for (int i = 1; i < 10; i++)
//		{
//			for (int j = 1; j < 10; j++) {
//				System.out.print(i + "*" + j + "=" + i*j + "\t");
//			}
//			System.out.println("");
//		}
	}

}
