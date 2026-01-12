package Trace;

public class Trace{
	public static void main(String[] args) {
		ExceptionScope example = new ExceptionScope();
		System.out.println("程式開始");
		example.level1();
		System.out.println("程式結束");
	}
}