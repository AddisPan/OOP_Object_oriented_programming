package While;

public class WhileBreak{
	public static void main(String[] args){
		int a=20;
		while(a<25){
			if(a==23){
				break;
			}
			System.out.println("迴圈變數的a值為"+a);
			a++;
		}
	}
}