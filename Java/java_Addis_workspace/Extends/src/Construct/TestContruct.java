package Construct;

class AA{
	double x1;
	public AA(){
		System.out.println("在AA()的x1="+x1);
		x1=5;
		System.out.println("AA的建構子AA()");
	}
	public AA(double x){
		System.out.println("在AA(double x)的x1="+x1);
		x1=x;
		System.out.println("AA的建構子AA(double x)");
	}
}

class BB extends AA{
	double x2;
	public BB(){
		x2=5;
		System.out.println("BB的建構子BB()");
	}
	public BB(double x){
		super(x);
		x2=9*x;
		System.out.println("BB的建構子BB(double x)");
	}
}

class CC extends BB{
	double x3;
	public CC(){
		x3=5;
		System.out.println("CC的建構子CC()");
	}
	public CC(double x){
		super(x);
		this.x3=8*x1;
		System.out.println("CC的建構子CC(double x)");
	}
	public CC(double x, double y){
		this.x3=x*y;
		System.out.println("CC的建構子CC(double x, double y)");
	}
}

class TestConstuct{
	public static void main(String[] args){
		CC sub1=new CC();
		System.out.println("這是CC型態sub1物件的CC()建構子");
		System.out.println("sub1.x1="+sub1.x1);
		System.out.println("sub1.x2="+sub1.x2);
		System.out.println("sub1.x3="+sub1.x3);
		System.out.println("檢查sub1物件");
		checkType(sub1);
		System.out.println("------------------");
		CC sub2=new CC(100.001);
		System.out.println("這是CC型態sub2物件的CC(double x)建構子");
		System.out.println("sub1.x1="+sub2.x1);
		System.out.println("sub1.x2="+sub2.x2);
		System.out.println("sub1.x3="+sub2.x3);
		System.out.println("檢查sub2物件");
		checkType(sub2);
		System.out.println("------------------");
		CC sub3=new CC(1000,5);
		System.out.println("這是CC型態sub3物件的CC(double x, double y)建構子");
		System.out.println("sub1.x1="+sub3.x1);
		System.out.println("sub1.x2="+sub3.x2);
		System.out.println("sub1.x3="+sub3.x3);
		System.out.println("檢查sub3物件");
		checkType(sub3);
	}
	public static void checkType(Object sub) {
		if(sub instanceof AA){
			System.out.println("物件內有AA類別的實體物件");
		}else{
			System.out.println("物件內沒有AA類別的實體物件");
		}
		if(sub instanceof BB){
			System.out.println("物件內有BB類別的實體物件");
		}else{
			System.out.println("物件內沒有BB類別的實體物件");
		}
	}
}
