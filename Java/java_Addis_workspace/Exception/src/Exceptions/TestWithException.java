package Exceptions;

public class TestWithException{
	public static void main(String[] args) {
		try {
			WithException c1 = new WithException(5);
			WithException c2 = new WithException(-5);
			WithException c3 = new WithException(5);
		} catch(IllegalArgumentException e) {
			System.out.println(e);
		}
		System.out.println("成功建立物件:" + 
		  WithException.getNumberOfObjects() + "個");
	}
} 