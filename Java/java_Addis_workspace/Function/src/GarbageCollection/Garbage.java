package GarbageCollection;

public class Garbage{
	public static void main(String[] args){
		{
			if(true){
				String str1=new String("大家好");
				System.out.println(str1);
			}
			String str2=new String("大家好");
			str2=null;
			System.out.println(str2);
		}
	}
}