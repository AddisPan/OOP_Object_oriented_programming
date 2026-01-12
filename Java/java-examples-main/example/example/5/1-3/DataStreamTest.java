import java.io.*;
public class DataStreamTest{
   public static void main(String[] args) throws IOException{
         DataOutputStream outputStream =
             new DataOutputStream(new FileOutputStream("tmp.dat"));
         outputStream.writeUTF("Mary");
         outputStream.writeDouble(55.5);
         outputStream.writeUTF("Justin");
         outputStream.writeDouble(99.9);
         outputStream.close();
         DataInputStream inputStream=
         		new DataInputStream(new FileInputStream("tmp.dat"));
	     	 System.out.println(inputStream.readUTF()+":"+inputStream.readDouble());
	     	 System.out.println(inputStream.readUTF()+":"+inputStream.readDouble());
	     	 inputStream.close();
   }
}

