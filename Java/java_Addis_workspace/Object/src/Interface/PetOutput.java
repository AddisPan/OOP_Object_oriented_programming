package Interface;

interface A{
	public void drink();
}
interface B{
	public void eat();
}
public interface PetOutput extends A,B{
	void sound();
}