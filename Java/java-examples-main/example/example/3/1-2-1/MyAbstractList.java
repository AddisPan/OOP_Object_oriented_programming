public abstract class MyAbstractList implements MyList {
  protected int size;
  protected MyAbstractList() {
  }
  protected MyAbstractList(Object[] objects) {
    for (int i = 0; i < objects.length; i++)
      this.add(objects[i]);
  }
  public void add(Object o) {
    add(size, o);
  }
  public boolean isEmpty() {
    return size == 0;
  }
  public int size() {
    return size;
  }
}