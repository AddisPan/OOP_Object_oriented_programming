import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.io.File;
import java.io.PrintWriter;
import java.io.FileOutputStream;
import java.io.FileNotFoundException;
 public class FileClass{
    public static void main(String[] args){
        BufferedReader keyboard = new BufferedReader(
                                   new InputStreamReader(System.in));
        String line = null;
        String fileName = null; 
        try{ 
            System.out.println("現在要儲存檔案");
            System.out.println("儲存這一行的文字:");
            line = keyboard.readLine( ); 
            System.out.println("檔案的名稱:");
            fileName = keyboard.readLine( );
            fileName = fileName.trim( );
            File fileObject = new File(fileName);
            while (fileObject.exists( )){
                System.out.println("這個檔案已經存在了"
                                       + fileName);
                System.out.println("請輸入下一個檔案名稱:");
                fileName = keyboard.readLine( );
                fileName = fileName.trim( );
                fileObject = new File(fileName);
            }
        }catch(IOException e){
            System.out.println("無法從鍵盤讀取檔案");
            System.exit(0);
        } 
        PrintWriter outputStream = null;
        try{
            outputStream = 
                 new PrintWriter(new FileOutputStream(fileName));
        }catch(FileNotFoundException e){
            System.out.println("無法打開檔案" + fileName);
            System.exit(0);
        }
        System.out.println("寫入 \""  + line + "\"");
        System.out.println("到這檔案中"  + fileName);
        outputStream.println(line); 
        outputStream.close( );
        System.out.println("寫入完成");
    }
}
 
