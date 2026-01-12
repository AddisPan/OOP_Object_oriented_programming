import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileNotFoundException;
import java.io.IOException;
public class TextFileInput{
    public static void main(String[] args){
       try{
           BufferedReader inputStream = 
                          new BufferedReader(new FileReader("test.txt"));
           String line = inputStream.readLine( );
           System.out.println("讀取第一行:");
           System.out.println(line);        
           line = inputStream.readLine( );
           System.out.println("讀取第二行:");
           System.out.println(line); 
           line = inputStream.readLine( );
           System.out.println("讀取第三行:");
           System.out.println(line); 
           inputStream.close( );
       }catch(FileNotFoundException e){
           System.out.println("找不到或打不開test.txt的檔案");           
       }catch(IOException e){
           System.out.println("無法讀取test.txt.");
       }
    }
}



