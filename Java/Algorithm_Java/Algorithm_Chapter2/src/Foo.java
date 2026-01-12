import java.util.Scanner;

public class Foo {

	public static void main(String[] args) {
		double sum = 0, n, count = 0, a, b;
		Scanner in = new Scanner(System.in);
		System.out.println("Please enter a number:");
		n = in.nextDouble();
		if(n > 0) {
			for(double i = 1; i <= n; i++) {
				a = number(i);
				b = i / a;
				sum = sum + b;
				count++;
			}
			System.out.println("Sum¡G" + sum);
			System.out.println("Times¡G" + count);
		}
	}
	
	public static double number(double n) {
		double a= 1;
		for(double i = 1; i <= n;i++) {
			a=a*i;
		}
		return a;
	}
}
