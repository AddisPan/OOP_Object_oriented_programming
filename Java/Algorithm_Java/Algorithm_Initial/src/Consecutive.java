import java.util.Scanner;

public class Consecutive {
	public static void main(String[] args) {
		int m, n, t, counter = 0;
		Scanner input = new Scanner(System.in);
		System.out.println("Please number1¡G");
		m = input.nextInt();
		System.out.println("Please number2¡G");
		n = input.nextInt();
		if (m < n) {
			t = m;
			counter++;
		} else {
			t = n;
			counter++;
		}
		while (m != 0) {
			if (m % t == 0) {
				counter++;
				if (n % t != 0) {
					counter++;
					t = t - 1;
					counter++;
				} else {
					System.out.println("Result¡G" + t);
					break;
				}
			} else {
				t = t - 1;
				counter++;
			}
		}
		System.out.println("Times¡G" + counter);
	}// end main
}
