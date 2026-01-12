import java.util.Scanner;

public class BinRec {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.print("num1:");
		int n = input.nextInt();
		System.out.print(B(n));
	}

	public static int B(int n) {
		if (n == 1)
			return 1;
		return B(n/2) + 1;
	}
}
