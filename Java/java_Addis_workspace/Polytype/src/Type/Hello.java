package Type;

public class Hello{
	public static void main(String[] args) {
		Object[] myObject=new Object[5];
		test(new Rectangle(1,1));
		test(new Circle(1));
		myObject[0]=new Rectangle(1,1);
		myObject[1]=new Circle(1);
		myObject[2]=new Triangle(1,1);
		for(int i=0;i<=2;i++) {
			test2(myObject[i]);
		}
		for(int i=0;i<=2;i++) {
			try {
				test3((Circle)myObject[i]);
			}catch(ClassCastException e) {
				System.out.println("ClassCastException");
			}catch(Exception e1) {
				e1.printStackTrace();
			}
		}
	}
	public static void test(Shape x) {
		System.out.println(x.getClass());
		System.out.println(x instanceof Shape);
		System.out.println(x instanceof Rectangle);
		System.out.println(x instanceof Circle);
		System.out.println(x instanceof Triangle);
		System.out.println(x instanceof Object);
	}
	public static void test2(Object x) {
		System.out.println(x.getClass());
		System.out.println(x instanceof Shape);
		System.out.println(x instanceof Rectangle);
		System.out.println(x instanceof Object);
	}
	public static void test3(Circle x) {
		System.out.println(x.getClass());
		System.out.println(x instanceof Shape);
		System.out.println(x instanceof Circle);
		System.out.println(x instanceof Object);
	}
}