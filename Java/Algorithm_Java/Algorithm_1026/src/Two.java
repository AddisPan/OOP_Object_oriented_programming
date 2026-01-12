import java.util.Scanner;

public class Two {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.print("num1:");
		double n = input.nextDouble();
		System.out.print(Two(n));
	}

	public static double Two(double n) {
		double f;
		if (n == 1)
			return 1;
		f = Math.pow(-2, n/2);
		return f;
	}
}
