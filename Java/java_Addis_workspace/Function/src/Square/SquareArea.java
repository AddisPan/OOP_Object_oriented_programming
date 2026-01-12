package Square;

public class SquareArea{
	public static void main(String[] args){
		double j=area(5);
		System.out.println("正方形的面積:"+j);
	}
	public static double area(double a){
		double result;
		result=a*a;
		return result;
	}
}