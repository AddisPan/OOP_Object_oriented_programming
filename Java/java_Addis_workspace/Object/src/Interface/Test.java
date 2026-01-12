package Interface;

public class Test{
	public static void main(String[] args){
		Dog littledog1=new Dog("¤p¶À");
		Dog littledog2=new Dog("¤p¶Â");
		System.out.println(littledog1);
		littledog1.sound();
		System.out.println(littledog2);
		littledog2.sound();
	}
}