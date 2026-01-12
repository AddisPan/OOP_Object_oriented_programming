import java.util.Vector;
public class VectorTest{
	public static void main(String[] args){
		Vector words=new Vector(10);
		words.add("大家好");
		words.add("今天又是美好的一天");
		words.add("高高興興的");
		System.out.println("Vector的字串包含:");
		System.out.println();
		int index;
		int vectorSize=words.size();
		for(index=0;index<vectorSize;index++){
			System.out.println(words.get(index));
		}
		System.out.println();
		String oldElement=(String)words.set(1,"Hello JAVA我來了");
		System.out.println("\""+oldElement+"\"被取代成"
		                                +"\""+words.get(1)+"\"\n");
		System.out.println("Vector的字串現在包含:");
		vectorSize=words.size();
		for(index=0;index<vectorSize;index++){
			System.out.println(words.get(index));
		}		
	}
}

