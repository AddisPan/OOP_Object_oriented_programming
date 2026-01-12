package Value;

public class ByValue{
	public static void main(String[] args){
		double a=3;
		double b=4;
		double c=5;
		abc(a,b,c);
		System.out.println("a:"+a);
		System.out.println("b:"+b);
		System.out.println("c:"+c);
	}
	public static void abc(double a, double b, double c){
		a++;
		b++;
		c++;
	}
}