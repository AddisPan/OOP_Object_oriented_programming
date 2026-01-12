import java.io.PrintWriter;
import java.io.FileOutputStream;
import java.io.FileNotFoundException;
public class TextFileOutput
{
    public static void main(String[] args)
    {
        PrintWriter outputStream = null;
        try
        {
        	
            outputStream = 
                 new PrintWriter(new FileOutputStream("output.txt"));
        }
        catch(FileNotFoundException e)
        {
            System.out.println("無法打開output.txt檔");
            System.exit(0);
        }
        System.out.println("寫到檔案的內容");
        System.out.println("歡迎大家來討論多媒體,資料庫,程式設計");
        System.out.println("RedHat Linux Fedora電子書下載大本營");
        outputStream.println("歡迎大家來討論多媒體,資料庫,程式設計");
        outputStream.println("RedHat Linux Fedora電子書下載大本營");
        outputStream.close( );
        System.out.println("程式結束");
    }
}



