class Animal{
	public void Sound() {
		System.out.println("The animal makes a sound");
	}
}

class Dog extends Animal{
	public void Sound() {	//覆寫父類別的Sound()
		super.Sound();		//呼叫父類別的sound()
		System.out.println("The dogs says: 旺旺");
	}
}
public class SuperClass{
	public static void main(String[] args) {
		Animal myDog=new Dog();	//Create a Dog object
		myDog.Sound();
	}
}