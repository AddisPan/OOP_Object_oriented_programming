import java.io.ObjectOutputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.FileNotFoundException;
public class ArrayIO{
    public static void main(String[] args){
        MyClass[] a = new MyClass[2];
        a[0] = new MyClass(0, 'A');
        a[1] = new MyClass(1, 'B');
        try{
            ObjectOutputStream outputStream =
                  new ObjectOutputStream(new FileOutputStream("array.dat"));
            outputStream.writeObject(a);
            outputStream.close( );
        }catch(IOException e)
        {
            System.out.println("無法寫入檔案");
            System.exit(0);
        }
         System.out.println("寫到array.dat的檔案");
        System.out.println("重新打開和顯示二進位array.dat檔");
        MyClass[] b = null;
        try{
            ObjectInputStream inputStream =
                 new ObjectInputStream(
                      new FileInputStream("array.dat"));
           b = (MyClass[])inputStream.readObject( );
           inputStream.close( );
        }catch(FileNotFoundException e){
            System.out.println("無法找到array.dat的檔案");
            System.exit(0);
        }
        catch(ClassNotFoundException e){
            System.out.println("檔案輸入的問題");
            System.exit(0);
        }catch(IOException e){
            System.out.println("檔案輸入的問題");
            System.exit(0);
        }
        System.out.println("從檔案讀取的陣列");
        int i;
        for (i = 0; i < b.length; i++)
            System.out.println(b[i]);
        System.out.println("程式結束");
    }
}



