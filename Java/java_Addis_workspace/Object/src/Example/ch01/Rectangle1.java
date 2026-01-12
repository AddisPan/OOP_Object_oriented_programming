package Example.ch01;

public class Rectangle1 extends Shape1{
	public double width;
	public double height;
	public Rectangle1(double width, double height){
		this.width=width;
		this.height=height;
	}
	public double area(){
		return width*height;
	}
}