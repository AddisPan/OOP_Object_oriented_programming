public class AA{
	public static void main(String[] args){
		A object1=new A();
		A object2=new A();
	}
}
class A{
	public int nu=1;
	private java.util.Date BuiltDate;
	public A(){
		this.nu=1;
		BuiltDate=new java.util.Date();
		System.out.println("我是建構子,新增時間" + BuiltDate);
	}
}