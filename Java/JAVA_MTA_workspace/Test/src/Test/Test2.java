package Test;
 
public class Test2 {

	public static void main(String[] args) {
		byte int_i = Byte.MAX_VALUE;
		byte int_a = 126;
		
		System.out.println("int_i " + int_i++);
		System.out.println("int_i " + int_i++);
		System.out.println("int_i " + int_i++);
		System.out.println(int_a + 10);
		
		int_a = (byte) (int_a + 3);
		System.out.println(int_a);
	}

}
