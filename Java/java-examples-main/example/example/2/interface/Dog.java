public class Dog extends Animal implements PetOutput {
	private String name;
	public Dog(String aName){
		super("Dog");
		name=aName;
	}
	public String toString(){
		return "³o¬O¤@°¦"+name;
	}
	public void sound(){
		System.out.println("©ô©ô");
	}
}