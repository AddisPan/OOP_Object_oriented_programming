package Hidden;

class Father{
	static String greeting() {return "早安你好";}
	String name() {return "黃小名";}
}
class Child extends Father{
	static String greeting() {return "Hello";}
	String name() {return "陳太太";}
}
class TestHidden{
	public static void main(String[] args){
		Father s=new Child();
		System.out.println(s.greeting()+", "+s.name());
	}
}