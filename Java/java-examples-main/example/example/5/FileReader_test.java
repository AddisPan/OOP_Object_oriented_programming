import java.io.*;

public class FileReader_test {
  public static void main(String[] args) {
    FileReader input = null;
    try {
      input = new FileReader("test.txt");
      int code;
      while ((code = input.read()) != -1)
        System.out.print((char)code);
    }catch (FileNotFoundException e1) {
      System.out.println("檔案text.txt不存在");
    }catch (IOException e1) {
      e1.printStackTrace();
    }finally {
      try {
        input.close();
      }
      catch (IOException e1) {
        e1.printStackTrace();
      }
    }
  }
}
