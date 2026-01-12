package Exum;

public class EnumGrade{
	enum Grade {A,B,C,D,E}
	public static void main(String[] args){
		Grade student1, student2, student3;
		student1=Grade.A;
		student2=Grade.B;
		student3=student1;
		System.out.println("student1的成績:"+student1);
		System.out.println("student1 ordinal:"+student1.ordinal());
		System.out.println("student1 name:"+student1.name());
		System.out.println("student2的成績:"+student2);
		System.out.println("student2 ordinal:"+student2.ordinal());
		System.out.println("student2 name:"+student2.name());
	}
}