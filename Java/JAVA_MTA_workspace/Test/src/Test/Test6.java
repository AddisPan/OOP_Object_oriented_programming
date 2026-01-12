package Test;

public class Test6 {

	public static void main(String[] args) {
//		double r = 0;
//
//		while (r < 0.99d) {
//			r = Math.random(); // Math 類別中提供產生亂數的類別方法
//			System.out.println(r);
//		}

		for (int i = 0; i < 100; i++) {
			if (i == 74)
				break; // Out of for loop
			if (i % 9 != 0)
				continue; // Next iteration
			System.out.println(i);
		}

	}

}
