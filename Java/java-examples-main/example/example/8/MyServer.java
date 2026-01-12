import java.awt.*;
import java.net.*;
import java.io.*;
import javax.swing.*;
import java.util.*;
public class MyServer extends JFrame {
  private JTextArea TextArea1 = new JTextArea();
  public static void main(String[] args) {
    new MyServer();
  }
  public MyServer() {
    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(new JScrollPane(TextArea1), BorderLayout.CENTER);
    setTitle("伺服器端");
    setSize(200, 200);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setVisible(true); 
    try {
      ServerSocket serverSocket = new ServerSocket(9000);
      TextArea1.append("伺服器開始日期" + new Date() + '\n');
      Socket socket = serverSocket.accept();
      DataInputStream inputFromClient = new DataInputStream(
        socket.getInputStream());
      DataOutputStream outputToClient = new DataOutputStream(
        socket.getOutputStream());
      while (true) {
        double radius = inputFromClient.readDouble();
        double area = radius * radius * Math.PI;
        outputToClient.writeDouble(area);
        TextArea1.append("從使用者端接收的半徑是: " + radius + '\n');
        TextArea1.append("面積: " + area + '\n');
      }
    }catch(IOException ex) {
      System.err.println(ex);
    }
  }
}
