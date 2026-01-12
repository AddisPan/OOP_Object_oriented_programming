package While;

public class BreakJava{
	public static void main(String[] args){
		int i=0;
		outer:                                //outer標籤
		while(true){
			++i;
			inner:							  //inner標籤
			switch(i){
			case 1:
				System.out.println("At1");
				break outer;
			case 2:
				System.out.println("At2");
				break inner;
			default:
				break;
			}
		}
		i=0;
		outer1:								  //outer1標籤
		while(true){
			++i;
			inner1:							  //inner1標籤
			switch(i){
			case 5:
				System.out.println("At5");
				break inner1;
			case 10:
				System.out.println("At10");
				break outer1;
			default:
				break;
			}
		}
	}
}