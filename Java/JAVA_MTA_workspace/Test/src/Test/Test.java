package Test;

import java.util.*;

public class Test {
	public static void main(String[] args) {
		int a, count = 0, sum = 0;
		double avg = 0;
		Scanner in = new Scanner(System.in);
		while (in.hasNext()) {
			if (in.nextLine() != "") {
				a = in.nextInt();
				sum = sum + a;
				count++;
			} else {
				break;
			}
		}
		avg = sum / count;
		System.out.printf("%.2f", avg);
	}
}
