package MathArithmetic;

import java.util.Scanner;

public class Mix3 {

	public static void main(String[] args) {
//		for (int k = 1; k <= 3; k++) {
//			for (int i = 1; i <= 9; i++) {
//				for (int j = 1 + (k - 1) * 3; j <= k * 3; j++) {
//					System.out.print(i + "*" + j + "=" + i * j + "\t");
//				}
//				System.out.println("");
//			}
//			System.out.println("-----------------------");
//		}
		
		
		Scanner input = new Scanner(System.in);

		System.out.print("num1:");
		int n = input.nextInt();
		
		for (int k = 0; k <= 1; k++) {
			for (int i = 1; i <= 9; i++) {
				for (int j = 1+(k*n); j <= n+(k*(9-n)); j++) {
					System.out.print(i + "*" + j + "=" + i * j + "\t");
				}
				System.out.println("");
			}
			System.out.println("-----------------------");
		}
	}
}
