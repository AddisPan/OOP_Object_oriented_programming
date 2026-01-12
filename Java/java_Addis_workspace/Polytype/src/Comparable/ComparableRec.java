package Comparable;

public class ComparableRec extends Rectangle implements Comparable{
	public ComparableRec(double width, double height){
		super(width,height);
	}
	public int compareTo(Object ob) {
		if(findArea() > ((ComparableRec)ob).findArea()) {
			return 1;
		}else if(findArea() < ((ComparableRec)ob).findArea()){
			return -1;
		}else {
			return 0;
		}
	}
}