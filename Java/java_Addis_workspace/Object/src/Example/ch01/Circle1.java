package Example.ch01;

public class Circle1 extends Shape1{
	public double r;
	public Circle1(double r){
		this.r=r;
	}
	public double area(){
		return r*r*Math.PI;
	}
}