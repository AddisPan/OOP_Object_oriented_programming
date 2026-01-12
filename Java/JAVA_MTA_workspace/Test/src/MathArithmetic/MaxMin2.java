package MathArithmetic;

public class MaxMin2 {
double max,min;
	
	public MaxMin2(double a, double b) {
		this.max = a;
		this.min = b;
	}
	
	public void result() {
		if (max > min) {
			System.out.println("Max¡G" + max);
			System.out.println("Min¡G" + min);
		} else {
			System.out.println("Max¡G" + min);
			System.out.println("Min¡G" + max);
		}
	}
}
