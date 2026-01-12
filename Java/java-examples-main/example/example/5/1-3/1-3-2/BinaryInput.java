import java.io.ObjectInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.FileNotFoundException;
public class BinaryInput{
  public static void main(String[] args){
     try{
         ObjectInputStream inputStream = 
           new ObjectInputStream(new FileInputStream("Binary.dat"));
         System.out.println("從Binary.dat二進位檔案讀取資料");
         int n1 = inputStream.readInt( );
         System.out.println("從檔案讀取資料:");
         System.out.println(n1);
         inputStream.close( );
     }catch(FileNotFoundException e){
         System.out.println("不能找到Binary.dat檔案");
     }catch(IOException e){
         System.out.println("例外發生,無法從Binary.dat讀入");
     }
     System.out.println("結束程式");
  }
}


