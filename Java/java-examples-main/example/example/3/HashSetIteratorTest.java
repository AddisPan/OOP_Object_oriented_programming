import java.util.HashSet;
import java.util.Iterator;
public class HashSetIteratorTest{
    public static void main(String[] args){
        HashSet s = new HashSet( );
        s.add("PHP&MySQL徹底研究");
        s.add("Flash MX2004徹底研究");
        s.add("Linux Fedora徹底研究");
        System.out.println("這集合包含:");
        Iterator i = s.iterator( );
        while (i.hasNext( )){
            System.out.println(i.next( ));
	}
        i.remove( );
        System.out.println( );
        System.out.println("刪除一個之後:");
        i = s.iterator( );
        while (i.hasNext( )){
            System.out.println(i.next( ));
	}
    }
}
