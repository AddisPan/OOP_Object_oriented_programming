import java.io.RandomAccessFile;
import java.io.IOException;
import java.io.FileNotFoundException;
public class TestRandomAccess{
  public static void main(String[] args){
     try{
         RandomAccessFile ioStream =
           new RandomAccessFile("bytedata.dat", "rw");
         System.out.println("寫入三個bytes到bytedata.dat檔案中");
         ioStream.writeByte(1);
         ioStream.writeByte(2);
         ioStream.writeByte(3);
         System.out.println("檔案的長度是= "+ ioStream.length( ));
         System.out.println("檔案指標的位置是在"+ ioStream.getFilePointer( ));
         System.out.println("移動檔案指標到位置為1的地方.");
         ioStream.seek(1);
         byte oneByte = ioStream.readByte( );
         System.out.println("位置為1的資料是" + oneByte);
         oneByte = ioStream.readByte( );
         System.out.println("位置為2的資料是" + oneByte);
         System.out.println("我們現在將指標移動位置1的地方並且更改該資料");
         ioStream.seek(1);
         ioStream.writeByte(9);
         ioStream.seek(1);
         oneByte = ioStream.readByte( );
         System.out.println("現在位置1的資料是" + oneByte);
         System.out.println("我們現在到檔案尾巴,並且寫入雙精度的數值");
         ioStream.seek(ioStream.length( ));
         ioStream.writeDouble(55.55);
         System.out.println("現在檔案的長度是 = "+ ioStream.length( ));
         System.out.println("回到位置3");
         ioStream.seek(3);
         double oneDouble = ioStream.readDouble( );
         System.out.println("位置3雙精度浮點數的數值為" + oneDouble);
         ioStream.close( );
     }catch(FileNotFoundException e){
         System.out.println("打開檔案有問題");
     }catch(IOException e){
         System.out.println("輸入/輸出有問題");
     }System.out.println("程式結束");
  }
}
 

