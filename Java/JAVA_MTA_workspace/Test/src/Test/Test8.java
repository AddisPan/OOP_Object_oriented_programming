package Test;

public class Test8 {
	public static void main(String[] args) {
//		if(true) {
//			int num = 1;
//			if (num > 0) {
//				num++;
//			}
//		}
//		int num = 1;
//		addOne(num);
//		num = num - 1;
//		System.out.println(num);

//		int a = 5;
//		double b = 3.5;
//		int c = 33;
//		float d = 0.5f;
//		short e = 22;
//
//		System.out.println(a+=4%2+e); 
//		System.out.println(b/=10*2); 
//		System.out.println(c%=e*2+1); 
//		System.out.println(d*=2+6%7); 
//		
//		System.out.println(negativeSquare(8));
		System.out.println(args[0]);
	}

	public static void addOne(int num) {
		num = num + 1;
	}

	public static int negativeSquare(int number) {
		return -(number ^ 2);
	}

	public void traverse(String[][] board) {
		for (int x = 0; x < board.length; x++)
			for (int y = 0; y < board[x].length; y++)
				System.out.println(board[x][y]);
	}

}
