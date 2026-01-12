package Clone;

public class TestClone{
	public static void main(String[] args){
		int a1[] = {1,2,3,4,5};
		int a2[] = (int[])a1.clone();
		System.out.println("使用Clone複製的陣列="+(a1==a2));
		a1[0]=a1[0]+1;
		for(int i=0;i<a2.length;i++){
			System.out.print("a1:"+a1[i]+" ");
		}
		System.out.println("");
		for(int i=0;i<a2.length;i++){
			System.out.print("a2:"+a2[i]+" ");
		}
		System.out.println();
	}
}