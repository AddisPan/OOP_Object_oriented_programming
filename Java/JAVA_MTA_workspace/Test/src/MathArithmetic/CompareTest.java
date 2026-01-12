package MathArithmetic;

import java.util.Scanner;

public class CompareTest {

	public static void main(String[] args) {
		System.out.println("Please key number");
		Scanner number = new Scanner(System.in);
		int x = Integer.parseInt(args[0]);
		int y = Integer.parseInt(args[1]);
		int z = Integer.parseInt(args[2]);
		int max, min;
		max		=x > y ? x: y;
		min		=x < y ? x: y;
		max		=z > max ? z:max;
		min		=z < max ? z:min;
		System.out.println("Max:"+max+",Min:"+min);
	}

}
