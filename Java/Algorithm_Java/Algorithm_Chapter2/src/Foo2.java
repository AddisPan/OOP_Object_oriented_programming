import java.util.Arrays;
import java.util.Scanner;

public class Foo2 {

	public static void main(String[] args) {
		int val = 100, sumgreater = 0, sumless = 0, n, result;
		Scanner in = new Scanner(System.in);
		System.out.println("Please enter a number:(3¥H¤W)");
		n = in.nextInt();
		int[] A = new int[n-1];
		for (int i = 0; i < A.length; i++) {
			int temp = (int) (Math.random() * 1000 + 1);
			A[i] = temp;
			System.out.println(A[i]);
		}

		for (int j = 0; j < n - 1; j++) {
			if (A[j] > val)
				sumgreater = A[j];
			if (A[j] < val)
				sumless = A[j];
		}
		result = sumgreater - sumless;
		System.out.print("Answer¡G" + result);
	}

}
