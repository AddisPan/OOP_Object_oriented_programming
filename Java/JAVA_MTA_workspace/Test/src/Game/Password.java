package Game;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Password {

	public void result() {

	}

	public static void main(String[] args) {
		int password, guess, left = 1, right = 100, n, counter = 0;
		Scanner input = new Scanner(System.in);

		password = (int) (Math.random() * 100 + 1);
		System.out.println(password);

		while (true) {
			System.out.println("Left:" + left + " " + "Right:" + right + " " + counter);
			System.out.println("number of password:");
			int n1 = -1;
			try {
				n1 = input.nextInt();
			} catch (Exception e) {
				System.out.println("input error");
				input.next();
			}
			counter++;

			if (n1 == password) {
				System.out.println("You got it!" + " " + counter);
				break;
			} else {
				if (n1 < left || n1 > right) {
					System.out.println("Error");
				} else {
					if (n1 > password)
						right = n1;
					else
						left = n1;
				}
			}
		}
	}

}
