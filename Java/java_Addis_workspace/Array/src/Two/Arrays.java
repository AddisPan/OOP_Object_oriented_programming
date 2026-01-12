package Two;

public class Arrays{
	public static void main(String[] args){
		int[][] a=new int[2][5];
		a[0][0]=1;
		a[0][1]=2;
		a[0][2]=3;
		a[0][3]=4;
		a[0][4]=5;
		a[1][0]=6;
		a[1][1]=7;
		a[1][2]=8;
		a[1][3]=9;
		a[1][4]=10;
		String output="°}¦Caªº¤¸¯À¬O";
		for(int i=0;i<=a.length-1;i++){
			for(int j=0;j<=a[i].length-1;j++){
				output=output+a[i][j]+" ";
			}
		}
		System.out.println(output);
	}
}