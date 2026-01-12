package Type;

public class Triangle extends Shape{
	public double bottom;
	public double height;
	public Triangle(double bottom, double height){
		this.bottom=bottom;
		this.height=height;
	}
	public double area(){
		return (bottom*height/2);
	}
}