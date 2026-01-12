import java.io.*;
public class FileWriter_test {
  public static void main(String[] args) throws IOException {
    FileWriter output = new FileWriter("good.txt", true);
    output.write("這是要輸出的字");
    output.close();
  }
}
