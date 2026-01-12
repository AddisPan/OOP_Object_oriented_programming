package Useful;

class Useful extends Object{
	private int id=1235678;
	public int ok=5;
	protected int ok2=8;
	public void f() {
		System.out.println(id);
	};
	public void g() {};
}

interface DesignTest{
	final int good=55555;
	public void f2();
}

class MoreUseful extends Useful implements DesignTest{
	public void f() {
		System.out.println("Hello");
		System.out.println(ok);
	};
	public void f2() {
		System.out.println("Good");
		System.out.println(good);
	};
	public void g() {
		System.out.println("Helloworld");
	};
	public void u() {};
	public void v() {};
	public void w() {};
}

public class RTTI{
	public static void main(String[] args) {
		Useful[] x= {new Useful(),new MoreUseful()};
		x[0].f();
		x[1].g();
		((MoreUseful)x[1]).f2();
		((MoreUseful)x[1]).f();
	}
}