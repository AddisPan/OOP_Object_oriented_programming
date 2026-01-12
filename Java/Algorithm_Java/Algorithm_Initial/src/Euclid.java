import java.util.Scanner;

public class Euclid {
	public static void main(String[] args) {
		int m, n, r, counter=0;
		Scanner input = new Scanner(System.in);
		System.out.println("Please number1¡G");
		m = input.nextInt();
		System.out.println("Please number2¡G");
		n = input.nextInt();
		while (n != 0) {
			r = m % n;
			counter++;
			m = n;
			n= r;
			counter++;
		}
		System.out.println("Result¡G" + m);
		System.out.println("Times¡G" + counter);
	}
}
