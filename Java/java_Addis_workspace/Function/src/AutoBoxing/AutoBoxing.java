package AutoBoxing;

import java.lang.Integer;

public class AutoBoxing{
	public static void main(String[] args){
		Integer grade1;
		int n1=88;
		grade1=n1;
		System.out.println(grade1);
		Integer grade2=Integer.valueOf(88);
		int n2;
		n2=grade2;
		System.out.println(n2);
	}
}