package NumericType;

public class ForceNumericType{
	public static void main(String[] args) {
		byte i=30;
		long s=i*5+3;
		double t=i*5.5+s/3;						//i,s轉型為double
			System.out.println(i);
		System.out.println(s);
		System.out.println((int)t);				//強制轉型->int
	}
}