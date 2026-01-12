package Test;

import Game.Lottery;
import MathArithmetic.GCD;
import MathArithmetic.MaxMin;
import MathArithmetic.MaxMin2;

public class Menu {

	public static void main(String[] args) {
		MaxMin n = new MaxMin(16,18);
		n.result();
		
		MaxMin2 n2 = new MaxMin2(16,18);
		n2.result();
		
//		Lottery l = new Lottery(5);
//		l.result();
	}

}
