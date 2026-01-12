package Overriding;

public class TestOverriding{
	public static void main(String[] args){
		DogOverriding littledog1=new DogOverriding("小黃");
		DogOverriding littledog2=new DogOverriding("小黑","台灣土狗");
		System.out.println(littledog1);
		System.out.println(littledog2);
	}
}