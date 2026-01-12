package Overloading;

public class OverloadingMax{
	public static void main(String[] args){
		System.out.println("最大值:"+max(5,1));
		System.out.println("最大值:"+max(5.2,1.3));
		System.out.println("最大值:"+max(0.5,1,2.5));
	}
	public static double max(double a, double b){
		if(a>b)
			return a;
		else
			return b;
	}
	public static int max(int a, int b){
		if(a>b)
			return a;
		else
			return b;
	}
	public static double max(double a, double b, double c){
		return max(max(a,b),c);
	}
}