package Trace;

public class ExceptionScope{
	public void level1() {
		System.out.println("Level 1 開始呼叫");
		try {
			int x=5, y=0;
			int result = x / y;
		}catch (ArithmeticException problem) {
			System.out.println();
			System.out.println("例外訊息是:"+ problem.getMessage());
			System.out.println();
			System.out.println("堆疊追蹤呼叫");
			problem.printStackTrace();
			System.out.println();
		}
		
		System.out.println("Level 1 結束");
	}
}