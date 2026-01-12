package Test;

public class Test10 {
	int x = 25;

	public static void main(String[] args) {
		Test10 app = new Test10();
		{
			int x = 5;
		}
		{
			int x = 10;
		}

		int x = 100;
		System.out.println(x);
		System.out.println(app.x);
	}

	public Test10() {
		int x = 1;
		System.out.println(x);
	}
}
