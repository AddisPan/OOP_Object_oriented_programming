package Myexample;

import Example.ch01.Circle1;
import Example.ch01.Rectangle1;
import Example.ch01.Shape1;
import Example.ch01.Triangle1;

public class Test{
	public static void main(String[] args){
		Shape1 s;
		Circle1 c=new Circle1(10);
		Rectangle1 r=new Rectangle1(5,2);
		Triangle1 t=new Triangle1(8,2);
		s=c;
		System.out.println(s.area());
		System.out.println();
		s=r;
		System.out.println(s.area());
		System.out.println();
		s=t;
		System.out.println(s.area());
		System.out.println();
	}
}