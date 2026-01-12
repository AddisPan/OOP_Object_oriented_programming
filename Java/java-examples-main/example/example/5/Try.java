import java.io.IOException;
public class Try{
  public static void main(String[] args) {
    int[] x = {9, 3, 0};              
    try {
      System.out.println("在main()中第一個區塊");
      System.out.println("result = " + divide(x,0));  
      x[1] = 0;                                  
      System.out.println("result = " + divide(x,0));  
      x[1] = 1;                                  
      System.out.println("result = " + divide(x,1));  
    } catch(ArithmeticException e) {
      System.out.println("在main()中算術例外");
    } catch(ArrayIndexOutOfBoundsException e) {
      System.out.println("在main()中索引超出範圍");
    }
    System.out.println("Outside first try block in main()");
    System.out.println("\n請輸入Enter來離開");
    try {
      System.out.println("在main()中第二個區塊");
      System.in.read();                          
      return;
    } catch(IOException e) {           
      System.out.println("I/O exception caught in main()");
    } finally {                                 
      System.out.println("在main()函數中第二個try的finally區塊");
    }
    System.out.println("在main()函數中第二個try區塊後的執行程式碼");
  }

  public static int divide(int[] array, int index) {
    try {
      System.out.println("\n在divide()函數中第一個try區塊");
      array[index + 2] = array[index]/array[index + 1];
      System.out.println("在divide()函數中第一個try區塊尾巴的程式");
      return array[index + 2];
    } catch(ArithmeticException e) {
      System.out.println("在divide()函數中算術例外被抓到");
    } catch(ArrayIndexOutOfBoundsException e) {
      System.out.println("在divide()函數中索引超過範圍");
    } finally {
      System.out.println("在divide()函數中的finally區塊");
    }
    System.out.println("在divide()函數中try區塊後的執行程式碼");
    return array[index + 2];
  }
}
