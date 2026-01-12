package Comparable;

public class Rectangle extends GeometricObject{
	private double width;
	private double height;
	public Rectangle(double width, double height) {
		this.width=width;
		this.height=height;
	}
	public double getWidth() {
		return width;
	}
	public void setWidth(double width) {
		this.width=width;
	}
	public double getHeight() {
		return height;
	}
	public void setHeight(double height) {
		this.height=height;
	}
	public double findArea() {
		return width * height;
	}
	public String toString() {
		return "[¯x§Î] ¼e = " + width + ".°ª = " + height;
	}
}