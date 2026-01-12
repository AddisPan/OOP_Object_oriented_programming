package Comparable;
public abstract class GeometricObject{
	private String color = "white";
	private boolean filled;
	protected GeometricObject() {
	}
	public abstract double findArea(); 
}