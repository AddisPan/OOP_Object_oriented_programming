package MathArithmetic;

import java.util.Scanner;

public class BMI {
	public static void main(String[] args) {
		System.out.println("Please key your height(m)");
		Scanner h = new Scanner(System.in);
		double height = h.nextDouble();

		System.out.println("Please key your weight");
		Scanner w = new Scanner(System.in);
		int weight = w.nextInt();
		
		double BMI;
		BMI = weight / (height * height);
		System.out.println("Your BMI is " + BMI);

//		if (BMI < 20)
//			System.out.println("BMI是過輕");
//		else if (BMI < 23)
//			System.out.println("BMI是標準");
//		else
//			System.out.println("BMI是過重");
		System.out.println( (BMI<20) ? "Light" : ( (BMI<23) ? "Normal" : "Fat") );
	}
}
