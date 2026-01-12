package Test;

public class Test9 {

	public static void main(String[] args) {
//		double dNum = 1.7E308;
//		float fNum;
//		int iNum = 64;
//		char letter;
//		
//		letter = (char)iNum;
//		iNum = (int)dNum;
////		fNum = 89.99;
//		dNum = fNum;
		
		System.out.println(fee('A'));
		int a = fee('T');
		System.out.println(a);
		System.out.println(fee('C'));
		System.out.println(fee('B'));
	}
	
	public static int fee(char model) {
		 int price = 0;
		 switch (model) {
		 case 'A':
		 price = 50;
		 break;
		 case 'T':
		 price = 20;
		 case 'C':
		 price = 5;
		 break;
		 default:
		 price = 100;
		 break;
		 }
		 return price;
		 }

}
