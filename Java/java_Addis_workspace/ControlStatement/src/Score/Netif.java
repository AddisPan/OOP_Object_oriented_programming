package Score;

import java.util.Scanner;   //可以從鍵盤輸入

public class Netif{
	public static void main(String[] args){
		Scanner myObj = new Scanner(System.in);
		System.out.println("請輸入數字,多重選擇");
		String score = myObj.nextLine();
		int score1 = Integer.parseInt(score);
		if(score1>90){
			System.out.println("A級");
		}else if((score1>80) && (score1<=89)){
			System.out.println("B級");
		}else if((score1>70) && (score1<=79)){
			System.out.println("C級");
		}else if((score1>60) && (score1<=69)){
			System.out.println("D級");
		}else{
			System.out.println("F級");
		}
	}
}