package Value;

public class PassByValue{
	public static void main(String[] args){
		int a=5;
		int[] b=new int[6];
		b[0]=899;
		im(a,b);
		System.out.println("a的值是"+a);
		System.out.println("b[0]的值是"+b[0]);
	}
	public static void im(int number1,int[] number2){
		number1=8;
		number2[0]=9;
	}
}