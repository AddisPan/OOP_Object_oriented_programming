package MathArithmetic;

import java.util.Scanner;

public class MaxMin {
	double max,min;
	
	public MaxMin(double a, double b) {
		this.max = a;
		this.min = b;
	}
	
	public void result() {

		Scanner input = new Scanner(System.in);
		System.out.println("num1:");
		double num1 = input.nextDouble();
		
		System.out.println("num2:");
		double num2 = input.nextDouble();
		
		System.out.println("num3:");
		double num3 = input.nextDouble();
		if(num1 > num2) {
			if(num1 > num3) {
				max = num1;
				if(num2 > num3) {
					min = num3;
				}else {
					min = num2;
				}
			}else {
				max = num3;
				min = num2;
			}
		}else if(num2 > num3) {
			max = num2;
			if(num1 > num3) {
				min = num3;
			}else {
				min = num1;
			}
		}else {
			max = num3;
			min = num1;
		}
		
		System.out.println("max:"+max);
		System.out.println("min:"+min);
	}
}
