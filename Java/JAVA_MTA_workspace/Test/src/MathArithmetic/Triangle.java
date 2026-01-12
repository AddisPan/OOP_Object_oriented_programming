package MathArithmetic;

import java.util.Scanner;

public class Triangle {

	public static void main(String[] args) {
		String a = "";
		Scanner input = new Scanner(System.in);

		System.out.println("number of triangle:");
		int n = input.nextInt();

		for (int i = 0; i < n; i++) {
			System.out.println(a=a+"*"+" ");
		}
	}

}
