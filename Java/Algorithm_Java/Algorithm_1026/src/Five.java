import java.util.Scanner;

public class Five {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.print("num1:");
		double n = input.nextDouble();
		System.out.print(Five(n));
	}

	public static double Five(double n) {
		double f, g;
		if (n == 1)
			return 1;
		f = Math.pow(n, 1/5);
		g = Math.pow(n, f);
		return g;
	}
}
