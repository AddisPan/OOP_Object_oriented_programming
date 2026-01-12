import java.io.ObjectInputStream;
import java.io.FileInputStream;
import java.io.EOFException;
import java.io.IOException;
import java.io.FileNotFoundException;
public class BinaryEOF{
    public static void main(String[] args){
        try{
            ObjectInputStream inputStream =
              new ObjectInputStream(new FileInputStream("Binary.dat"));
            int number;
            System.out.println("從Binary.dat二進位檔案讀取資料");
            try{
                while (true){
                    number = inputStream.readInt( );
                    System.out.print(number+" ");
                }
            }catch(EOFException e){
                System.out.println("最後一行了");
            }
            inputStream.close( );
        }catch(FileNotFoundException e){
            System.out.println("無法找到Binary.dat檔案");
        }catch(IOException e){
            System.out.println("無法從Binary.dat輸入檔案");
        }
    }
}

