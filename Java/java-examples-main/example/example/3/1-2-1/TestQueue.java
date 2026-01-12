public class TestQueue {
  public static void main(String[] args) {
    MyQueue qu = new MyQueue();
    System.out.println("佇列新增元素前");
    qu.enqueue("1"); 
    System.out.println("佇列新增元素1後"+qu); 
    qu.enqueue("2"); 
    System.out.println("佇列新增元素2後"+qu); 
    qu.enqueue("3"); 
    System.out.println("佇列新增元素3後"+qu); 
    qu.enqueue("4"); 
    System.out.println("佇列新增元素4後"+qu); 
    qu.enqueue("5");
    System.out.println("佇列新增元素5後"+qu);    
    qu.dequeue();
    System.out.println("元素被刪除"+qu);
    qu.dequeue();
    System.out.println("元素被刪除"+qu);
    qu.dequeue();
    System.out.println("元素被刪除"+qu);
  }
}