package Result;

public class ResultArray{
	public static void main(String[] args){
		int[] numbers= {2,5,6,7,3,8,9,13,11,20,18,16,19};
		String output="陣列numbers的元素是";
		for(int i=0;i<numbers.length;i++){
			output=output+numbers[i]+" ";
		}
		System.out.println(output);
		output="陣列numbers1的元素是";
		int[] numbers1=reverse(numbers);
		System.out.println("回傳陣列numbers1元素是:");
		for(int i=0;i<numbers1.length;i++){
			output=output+numbers1[i]+" ";
		}
		System.out.println(output);
	}
	public static int[] reverse(int[] array){
		int[] elements=new int[array.length];
		for(int i=0,j=elements.length-1;i<array.length;i++,j--){
			elements[j]=array[i];
		}
		return elements;
	}
}