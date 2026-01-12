package Operator;

public class Operators{
	public static void main(String[] args) {
		int a=10, b=5, c=1, result;
		result = a-++c-++b;			//++c -> 2 ++b -> 6 ; 10-2-6=2
		
		System.out.println(result);
	}
}