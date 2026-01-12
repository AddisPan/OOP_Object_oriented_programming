import java.util.Scanner;

public class TwoN {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.print("num1:");
		int n = input.nextInt();
		System.out.print(f(n));
	}

	public static int f(int n) {
		if (n == 1)
			return 2;
		return 2 * f(n - 1);
	}
}
