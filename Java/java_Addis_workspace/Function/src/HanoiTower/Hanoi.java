package HanoiTower;

import java.util.Scanner;

public class Hanoi{
	public static void main(String[] args){
		int n;
		Scanner scan=new Scanner(System.in);
		System.out.println("河內塔移動盤子問題");
		System.out.println("請輸入盤個數(整數n):");
		n=scan.nextInt();
		System.out.println("盤子在河內塔移動過程:");
		move(n,'A','B','C');
	}
	public static void move(int n, char from, char to, char aux){
		if(n==1){
			System.out.println("移動盤子"+n+"從"+from+"塔到"+to+"塔");
		}else{
			move(n-1,from,aux,to);
			System.out.println("移動盤子"+n+"從"+from+"塔到"+to+"塔");
			move(n-1,aux,to,from);
		}
	}
}