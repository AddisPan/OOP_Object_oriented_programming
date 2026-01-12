package MathArithmetic;

import java.util.Scanner;

class Student{
	String name;
	int number;
	
	int luckynumber = (int) (Math.random() * 99 + 1);
	
	Student(String n, int nm, int l){
		name = n;
		number = nm;
		luckynumber = l;
	}
	void show() {
		System.out.println("同學名字：" + name);
		System.out.println("同學座號：" + number);
		System.out.println("幸運號碼：" + luckynumber);
	}
}

public class Object {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		Student[] s1 = new Student[n];
		s1 [0] = new Student("王小明", 46, 6);
		s1 [1] = new Student("王大明", 26, 23);
		for (Student s11 : s1)
			s11.show();
	}

}
