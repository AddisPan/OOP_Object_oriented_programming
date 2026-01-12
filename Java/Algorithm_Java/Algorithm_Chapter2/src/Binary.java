import java.util.Scanner;

public class Binary {
	public static void main(String[] args) {
		int count = 1, n = 0, b = 0;
		String result = "";
		Scanner in = new Scanner(System.in);
		System.out.println("Please enter a number:");
		n = in.nextInt();
		System.out.println("Please enter a base(進制2):");
		b = in.nextInt();
		result = number(n, b);
		System.out.println("二進制值：" + result);
		while (n > 1) {
			count += 1;
			n = n / 2;
		}
		System.out.println("位元數：" + count);	
	}

	public static String number(int a, int b) {
		String ss = "";
		int n = 0;
		while (a > 0) {
			n = (a % b);
			ss += n;
			a /= b;
		}
		StringBuilder ssn = new StringBuilder(ss);
		ss = ssn.reverse().toString();
		return ss;
	}
}
