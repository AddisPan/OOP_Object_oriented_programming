package Comparable;

public class TestInterface{
	public static void main(String[] args) {
		ComparableRec rec1=new ComparableRec(6,8);
		ComparableRec rec2=new ComparableRec(5,9);
		System.out.println(Max.max(rec1,rec2));
	}
}