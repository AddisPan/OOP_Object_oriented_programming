package Test;

public class Test4 {

	public static void main(String[] args) {
//		try {
//			int x = 1 / 0;
//			System.out.println("try");
//		} catch (ArithmeticException ex) {
//			System.out.println("catch ArithmeticException");
//		} catch (Exception ex) {
//			System.out.println("catch Exception");
//		} finally {
//			System.out.println("finally");
//		}
		
		String a = "30";
		Double.valueOf(a);
		System.out.println(a);
		Double.parseDouble(a);
		System.out.println(a);
		
		int number = 10;
		String text1=""+number;
		System.out.println(text1);
		String text2=String.valueOf(number);
		System.out.println(text2);
		double dNum = 2.667;
		int iNum = 0;
		iNum = (int)dNum;
		System.out.println(iNum);
		String stringValue = "true";
		Boolean booleanValue=Boolean.parseBoolean(stringValue);
	}

}
