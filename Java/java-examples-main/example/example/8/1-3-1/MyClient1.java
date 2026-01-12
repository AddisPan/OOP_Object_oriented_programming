import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.net.*;
import javax.swing.*;
import java.util.*;
public class MyClient1 extends JFrame implements ActionListener {
  private JTextField Text = new JTextField();
  private JTextArea TextArea1 = new JTextArea();
  private DataOutputStream ToServer;
  private DataInputStream FromServer;
  public static void main(String[] args) {
    new MyClient1();
  }
  public MyClient1() {
    JPanel Panel1 = new JPanel();
    Panel1.setLayout(new BorderLayout());
    Panel1.add(new JLabel("請輸入半徑"), BorderLayout.EAST);
    Panel1.add(Text, BorderLayout.CENTER);
    Text.setHorizontalAlignment(JTextField.RIGHT);
    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(Panel1, BorderLayout.SOUTH);
    getContentPane().add(new JScrollPane(TextArea1), BorderLayout.CENTER);
    Text.addActionListener(this); 
    setTitle("使用者端");
    setSize(200, 200);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setVisible(true); 
    try {
      Socket socket = new Socket("localhost", 9000);
      //Socket socket = new Socket("10.112.88.164", 9000);
      FromServer = new DataInputStream(socket.getInputStream());
      ToServer =  new DataOutputStream(socket.getOutputStream());
    }catch (IOException ex) {
      TextArea1.append(ex.toString() + '\n');
    }
  }
  public void actionPerformed(ActionEvent e) {
    String actionCommand = e.getActionCommand();
    if (e.getSource() instanceof JTextField) {
      try {
        double radius = Double.parseDouble(Text.getText().trim());
        ToServer.writeDouble(radius);
        ToServer.flush();
        double area = FromServer.readDouble();
        TextArea1.append("半徑是" + radius + "\n");
        TextArea1.append("從伺服器接收到的面積是"+ area + '\n');
      }catch (IOException ex) {
        System.err.println(ex);
      }
    }
  }
}