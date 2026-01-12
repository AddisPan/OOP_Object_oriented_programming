public class MyLinkedList extends MyAbstractList {
  private Node first, last;
  public MyLinkedList() {
  }
  public MyLinkedList(Object[] objects) {
    super(objects);
  }
  public Object getFirst() {
    if (size == 0){ 
    	return null;
    }else{
    	return first.element;
    }
  }
  public Object getLast() {
    if (size == 0){
    	 return null;
    }else{
    	 return last.element;
    }
  }
  public void addFirst(Object o) {
    Node newNode = new Node(o);
    newNode.next = first;
    first = newNode;
    size++;
    if (last == null){
      last = first;
    }
  }
  public void addLast(Object o) {
    if (last == null) {
      first = last = new Node(o);
    }else {
      last.next = new Node(o);
      last = last.next;
    }
    size++;
  }
  public void add(int index, Object o) {
    if (index == 0) addFirst(o);
    else if (index >= size) addLast(o);
    else {
      Node current = first;
      for (int i = 1; i < index; i++)
        current = current.next;
      Node temp = current.next;
      current.next = new Node(o);
      (current.next).next = temp;
      size++;
    }
  }
  public Object removeFirst() {
    if (size == 0) return null;
    else {
      Node temp = first;
      first = first.next;
      size--;
      return temp.element;
    }
  }
  public Object removeLast() {
    return null;
  }
  public Object remove(int index) {
    if ((index < 0) || (index >= size)){
    	return null;
    }else if (index == 0){
    	return removeFirst();
    }else if (index == size - 1){ 
    	return removeLast();
    }else{
      Node previous = first;
      for (int i = 1; i < index; i++) {
        previous = previous.next;
      }
      Node current = previous.next;
      previous.next = current.next;
      size--;
      return current.element;
    }
  }
  public String toString() {
    StringBuffer result = new StringBuffer("");
    Node current = first;
    for (int i = 0; i < size; i++) {
      result.append(current.element);
      current = current.next;
      if (current != null){
        result.append("  "); 
      }
    }
    return result.toString();
  }
  public void clear() {
    first = last = null;
  }
  public boolean contains(Object o) {
    return true;
  }
  public Object get(int index) {
    return null;
  }
  public int indexOf(Object o) {
    return 0;
  }
  public int lastIndexOf(Object o) {
    return 0;
  }
  public boolean remove(Object o) {
    return true;
  }
  public Object set(int index, Object o) {
    return null;
  }
  private class Node {
    Object element;
    Node next;
    public Node(Object o) {
      element = o;
    }
  }
}
