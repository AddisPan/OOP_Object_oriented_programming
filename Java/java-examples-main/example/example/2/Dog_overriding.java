public class Dog_overriding extends Animal_overriding{
	private String name;
	private String breed;
	public Dog_overriding(String dogname){
		super("Dog_overriding");
		name=dogname;
		breed="不知道品種";
	}
	public Dog_overriding(String dogname,String dogbreed){
		super("Dog");
		name=dogname;
		breed=dogbreed;
	}
	public String toString(){
		return "這是一隻"+breed+",它的名子是"+name;
	}
}