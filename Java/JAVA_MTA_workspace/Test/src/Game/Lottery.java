package Game;

import java.util.Arrays;
import java.util.Scanner;

public class Lottery {

	int n;
	public Lottery(int nb) {
		this.n = nb;
	}
	
	public void result() {
		Scanner input = new Scanner(System.in);
		int [] lot = new int[input.nextInt()];
		for (int i = 0; i < lot.length; i++) {
			int temp = (int) (Math.random() * 49 + 1);
			Arrays.sort(lot);
			if(Arrays.binarySearch(lot, temp) < 0 ) {
				lot[i]=temp;
				System.out.println(lot[i]);
			}else {
				i--;
			}
		}
	}
	
//	public static void main(String[] args) {
//		
//		Scanner input = new Scanner(System.in);
//		int [] lot = new int[input.nextInt()];
//		for (int i = 0; i < lot.length; i++) {
//			int temp = (int) (Math.random() * 49 + 1);
//			Arrays.sort(lot);
//			if(Arrays.binarySearch(lot, temp) < 0 ) {
//				lot[i]=temp;
//				System.out.println(lot[i]);
//			}else {
//				i--;
//			}
//		}
//	}
}