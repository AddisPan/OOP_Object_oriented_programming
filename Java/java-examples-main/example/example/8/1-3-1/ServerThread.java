import java.io.*;
import java.net.*;
import java.util.*;
import java.awt.*;
import javax.swing.*;

public class ServerThread extends JFrame {
  private JTextArea TextArea1 = new JTextArea();
  public static void main(String[] args) {
    new ServerThread();
  }
  public ServerThread() {
    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(new JScrollPane(TextArea1), BorderLayout.CENTER);
    setTitle("多執行緒伺服器");
    setSize(300, 200);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setVisible(true); 
    try {
      ServerSocket serverSocket = new ServerSocket(9000);
      TextArea1.append("多執行緒伺服器開始" + new Date() + '\n');
      int clientNo = 1;
      while (true) {
        Socket socket = serverSocket.accept();
        TextArea1.append("開始執行執行緒"+clientNo+"在"+new Date()+'\n');
        InetAddress inetAddress = socket.getInetAddress();
        TextArea1.append("使用者 "+clientNo+"的名稱是"
          + inetAddress.getHostName() + "\n");
        TextArea1.append("使用者"+clientNo+"的IP位置"
          + inetAddress.getHostAddress() + "\n");
        HandleAClient thread = new HandleAClient(socket);
        thread.start();
        clientNo++;
      }
    }
    catch(IOException ex) {
      System.err.println(ex);
    }
  }
  class HandleAClient extends Thread {
    private Socket socket;
    public HandleAClient(Socket socket) {
      this.socket = socket;
    }

    public void run() {
      try {
        DataInputStream inputFromClient = new DataInputStream(
          socket.getInputStream());
        DataOutputStream outputToClient = new DataOutputStream(
          socket.getOutputStream());
        while (true) {
          double radius = inputFromClient.readDouble();
          double area = radius * radius * Math.PI;
          outputToClient.writeDouble(area);
          TextArea1.append("使用者端輸入的半徑" +
            radius + '\n');
          TextArea1.append("圓的面積" + area + '\n');
        }
      }catch(IOException e) {
        System.err.println(e);
      }
    }
  }
}

