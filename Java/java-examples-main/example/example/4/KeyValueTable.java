import java.util.*;
public class KeyValueTable<Key,Value>{
	private LinkedList<Key> keys;
	private LinkedList<Value> values;
	public KeyValueTable(){
		keys=new LinkedList<Key>();
		values=new LinkedList<Value>();
	}
	public void add(Key key,Value value){
		int i=keys.indexOf(key);
		if(i==-1){
			keys.add(key);
			values.add(value);
		}else{
			values.set(i,value);
		}
	}
	public Value lookUp(Key key){
		int i=keys.indexOf(key);
		if(i!=-1){
			return values.get(i);		
		}else{
			return null;
		}
	}
}

