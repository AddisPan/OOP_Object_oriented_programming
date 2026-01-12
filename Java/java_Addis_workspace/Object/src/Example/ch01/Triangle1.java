package Example.ch01;

public class Triangle1 extends Shape1{
	public double bottom;
	public double height;
	public Triangle1(double bottom, double height){
		this.bottom=bottom;
		this.height=height;
	}
	public double area(){
		return (bottom*height/2);
	}
}