package Overriding;

public class DogOverriding extends AnimalOverriding{
	private String name;
	private String breed;
	public DogOverriding(String dogname){
		super("Dog_overriding");
		name=dogname;
		breed="不知道品種";
	}
	public DogOverriding(String dogname, String dogbreed){
		super("Dog");
		name=dogname;
		breed=dogbreed;
	}
	public String toString(){
		return "這是一隻"+breed+",它的名子是"+name;
	}
}