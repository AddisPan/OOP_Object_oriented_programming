package Type;

public class Circle extends Shape{
	public double r;
	public Circle(double r){
		this.r=r;
	}
	public double area(){
		return r*r*Math.PI;
	}
}