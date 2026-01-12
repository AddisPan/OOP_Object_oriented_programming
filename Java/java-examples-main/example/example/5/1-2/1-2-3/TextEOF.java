import java.io.BufferedReader;
import java.io.FileReader;
import java.io.PrintWriter;
import java.io.FileOutputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
public class TextEOF{
   public static void main(String[] args){
      try{
         BufferedReader inStream = 
               new BufferedReader(new FileReader("first.txt"));
         PrintWriter outStream = new PrintWriter(
                           new FileOutputStream("second.txt"));
         int count = 0;
         String lineContent = inStream.readLine( );
         while (lineContent != null){
            count++;
            outStream.println(lineContent);
            lineContent = inStream.readLine( );
          }
         inStream.close( );
         outStream.close( );
      }catch(FileNotFoundException e){
         System.out.println("無法開啟檔案");
      }catch(IOException e){
         System.out.println("無法從first.txt開啟檔案");
      }
   }
}
