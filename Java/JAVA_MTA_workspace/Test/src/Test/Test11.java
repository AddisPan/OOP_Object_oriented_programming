package Test;

public class Test11 {
	static int count = 0;
	int i = 0;

	public void change() {
		while (i < 5) {
			i++;
			count++;
		}
	}

	public static void main(String[] args) {
//		Test11 c1 = new Test11();
//		Test11 c2 = new Test11();
//		c1.change();
//		System.out.println(c1.count);
//		c2.change();
//		System.out.println(c2.count);
//		System.out.println(c1.count);
//		System.out.print(c1.count + "¡G" + c2.count);
		double pi = Math.PI; // 3.141593
		System.out.format("Pi is %.3f%n", pi);
		System.out.format("Pi is %.0f%n", pi);
		System.out.format("Pi is %09f%n", pi);

	}

}
