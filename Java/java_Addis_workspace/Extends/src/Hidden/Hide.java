package Hidden;

public class Hide{
	public static void main(String[] args){
		Subclass sub=new Subclass();
		System.out.println(sub.x + " " + sub.y + " " + sub.z);
		System.out.println(sub.method());
		Base base=(Subclass)sub;
		System.out.println(base.x + " " + base.y + " " + base.z);
		System.out.println(base.method());
	}
}
class Base{
	int x=1;
	static int y=2;
	int z=3;
	int method() {
		return x;
	}
}
class Subclass extends Base{
	int x=4;
	int y=5;
	static int z=6;
	int method() {
		return x;
	}
}