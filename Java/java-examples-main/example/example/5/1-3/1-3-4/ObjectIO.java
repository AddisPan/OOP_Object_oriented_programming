import java.io.ObjectOutputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.FileNotFoundException;
public class ObjectIO{
   public static void main(String[] args){
      try{
          ObjectOutputStream outputStream =
             new ObjectOutputStream(new FileOutputStream("datafile.dat"));
          MyClass oneObject = new MyClass(1, 'B');
          MyClass anotherObject = new MyClass(2, 'C');
          outputStream.writeObject(oneObject);
          outputStream.writeObject(anotherObject);
          outputStream.close( );
          System.out.println("將資料送到檔案中");
      }
      catch(IOException e){
         System.out.println("檔案輸出的問題");
      }
        System.out.println("重新打開檔案和顯示資料");
      try{
          ObjectInputStream inputStream = 
            new ObjectInputStream(new FileInputStream("datafile.dat"));
          MyClass One = (MyClass)inputStream.readObject( );
          MyClass Two = (MyClass)inputStream.readObject( );
          System.out.println("從datafile.dat二進位檔讀取資料");
          System.out.println(One);
          System.out.println(Two);
      }catch(FileNotFoundException e){
          System.out.println("無法打開二進位datafile.dat檔案");
      }catch(ClassNotFoundException e){
          System.out.println("檔案無法找到");
      }catch(IOException e){
          System.out.println("檔案輸入的問題");
      }
      System.out.println("程式結束");
   }
}

 