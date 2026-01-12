package Switch;

import java.util.Scanner;

public class SwitchJava{

	public static void main(String[] args){
		Scanner myObj = new Scanner(System.in);
		System.out.println("請輸入1~6數字");
		int score = myObj.nextInt();
		
		switch(score){
		case 1:
		case 2:
			  System.out.println("小寶case1和case2");
			  break;
		case 3:
		case 4:
		case 5:
			  System.out.println("小文case3和case4和case5");
		      break;
		case 6:
			  System.out.println("大寶case6");
		      break;
		default:
			  System.out.println("請輸入其他數字");
		}
	}
}