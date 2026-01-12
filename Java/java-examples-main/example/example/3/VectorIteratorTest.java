import java.util.Vector;
import java.util.Iterator;
public class VectorIteratorTest{
	public static void main(String[] args){
		Vector words=new Vector(10);
		words.add("大家好");
		words.add("今天又是美好的一天");
		words.add("高高興興的");
		System.out.println("Vector的字串包含:");
		Iterator i=words.iterator();
		while(i.hasNext()){
			System.out.println(i.next());
		}
		i.remove();
		System.out.println();		
		System.out.println("Vector的字串現在包含:");
		i=words.iterator();
		while(i.hasNext()){
			System.out.println(i.next());
		}
	}
}

