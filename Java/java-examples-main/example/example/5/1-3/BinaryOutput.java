import java.io.ObjectOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;
public class BinaryOutput{
   public static void main(String[] args){
      try{
         ObjectOutputStream outputStream =
             new ObjectOutputStream(new FileOutputStream("Binary.dat"));
         int i;
         for (i = 0; i < 258; i++)
             outputStream.writeInt(i);
         System.out.println("寫到Binary.dat位元檔案.");
         outputStream.close( );
      }catch(IOException e){
         System.out.println("輸出有問題");
      }
   }
}

