package MathArithmetic;

import java.util.Scanner;

public class Triangle2 {

	public static void main(String[] args) {
		String a = "";
		Scanner input = new Scanner(System.in);

		System.out.println("number of triangle:");
		int n = input.nextInt();

		for (int y = 1; y <= n; y++) {
			
			for (int x = n - 1; x >= y; x--) {
				System.out.print(" ");
			}
			
			for (int star = 1; star <= y; star++) {
				System.out.print("* ");
			}
			System.out.println("");
		}
	}

}
