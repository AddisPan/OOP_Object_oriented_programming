package Test;

import java.util.Scanner;

public class Test5 {
	public static void main(String[] args) {
//		System.out.println("Please key number");
//		Scanner number = new Scanner(System.in);
//		int n = number.nextInt();
//		
//		System.out.println(n);
		
//		Scanner input = new Scanner(System.in);
//		double max,min;
//		
//		System.out.println("num1:");
//		double num1 = input.nextDouble();
//		
//		System.out.println("num2:");
//		double num2 = input.nextDouble();
//		
//		System.out.println("num3:");
//		double num3 = input.nextDouble();
//
//		if(num1 > num2) {
//			if(num1 > num3) {
//				max = num1;
//				if(num2 > num3) {
//					min = num3;
//				}else {
//					min = num2;
//				}
//			}else {
//				max = num3;
//				min = num2;
//			}
//		}else if(num2 > num3) {
//			max = num2;
//			if(num1 > num3) {
//				min = num3;
//			}else {
//				min = num1;
//			}
//		}else {
//			max = num3;
//			min = num1;
//		}
//		
//		System.out.println("max:"+max);
//		System.out.println("min:"+min);
		
		int maxX = 10;
		int maxY = 15;
		for (int x = 0, y = 0; (x < maxX) && (y < maxY); x++, y = x * 2)
		{
		System.out.println(" x < 10 : " + x + ", y < 15 : " + y);
		}
	}
}
