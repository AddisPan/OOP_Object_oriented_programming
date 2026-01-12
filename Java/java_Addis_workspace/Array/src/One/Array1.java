package One;

import java.util.Scanner;

public class Array1{
	public static void main(String[] args){
		final int TOTAL=8;
		int [] numbers=new int[TOTAL];
		Scanner scan=new Scanner(System.in);
		for(int i=0;i<numbers.length;i++){
			System.out.println("請輸入一個整數:");
			numbers[i]=scan.nextInt();
		}
		int min=numbers[0];
		for(int i=1;i<numbers.length;i++){
			if(min>numbers[i]) {
				min=numbers[i];
			}
		}
		String output="陣列numbers的元素是:";
		for(int i=0;i<numbers.length;i++){
			output=output+numbers[i]+" ";
		}
		System.out.println(output);
		System.out.println("陣列元素最小的值是"+min);
	}
}