package Test;

import java.util.Scanner;
import java.util.Arrays;

public class Test7 {

	public static void main(String[] args) {
//		// TODO Auto-generated method stub
//		Scanner input = new Scanner(System.in);
//		int[] lotto = new int[input.nextInt()];
//		for(int i=0;i<lotto.length;i++) {
//			int temp = (int)(Math.random()*49+1);
//			Arrays.sort(lotto);
//			if(Arrays.binarySearch(lotto, temp)<0) {
//				lotto[i]=temp;
//				System.out.println(lotto[i]);
//			}else {
//				i--;
//			}
//		}
		int a = 5;
		int b = 8;
		int total = add(a,b);
		System.out.println(a);
		System.out.println(b);
		System.out.println(total);
	}
	
	public static int add(int a, int b) {
		a = a - 2;
		b = b - 2;
		return a+b;
	}
}