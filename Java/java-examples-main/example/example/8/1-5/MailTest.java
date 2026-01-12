import java.awt.*;
import java.awt.event.*;
import java.util.*;
import java.net.*;
import java.io.*;
import javax.swing.*;
import java.awt.*;
public class MailTest
{  
   public static void main(String[] args)
   {  
      JFrame gui = new MailFrame();
      gui.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      gui.setVisible(true);
   }
}
class MailFrame extends JFrame
{  
   private Scanner in;
   private PrintWriter output;
   private JTextField from;
   private JTextField to;
   private JTextField smtpServer;
   private JTextArea message;
   private JTextArea textArea;
   public static final int DEFAULT_WIDTH = 350;
   public static final int DEFAULT_HEIGHT = 550; 
   public MailFrame()
   {  
      setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);
      setTitle("郵件");
      setLayout(new GridBagLayout());
      add(new JLabel("寄件者:"), new GFrame(0, 0).setFill(GFrame.HORIZONTAL));
      from = new JTextField(20);
      add(from, new GFrame(1, 0).setFill(GFrame.HORIZONTAL).setWeight(100, 0));
      add(new JLabel("收件者:"), new GFrame(0, 1).setFill(GFrame.HORIZONTAL));
      to = new JTextField(20);
      add(to, new GFrame(1, 1).setFill(GFrame.HORIZONTAL).setWeight(100, 0));
      add(new JLabel("SMTP 伺服器:"), new GFrame(0, 2).setFill(GFrame.HORIZONTAL));
      smtpServer = new JTextField(20);
      add(smtpServer, new GFrame(1, 2).setFill(GFrame.HORIZONTAL).setWeight(100, 0)); 
      message = new JTextArea();
      add(new JScrollPane(message), 
                   new GFrame(0, 3, 2, 1).setFill(GFrame.BOTH).setWeight(100, 100));
      textArea = new JTextArea();
      add(new JScrollPane(textArea), 
                   new GFrame(0, 4, 2, 1).setFill(GFrame.BOTH).setWeight(150, 100));
      JPanel buttonPanel = new JPanel();
      add(buttonPanel, new GFrame(0, 5, 2, 1));
      JButton sendButton = new JButton("傳送");
      buttonPanel.add(sendButton);
      sendButton.addActionListener(new
         ActionListener()
         {
            public void actionPerformed(ActionEvent event)
            {  
               new Thread(new 
                  Runnable()
                  {
                     public void run()
                     {   
                        textArea.setText("");
                        sendMail();
                     }
                  }).start();
            }            
         });
   }
   public void sendMail()
   {  
      try
      {  
         Socket s = new Socket(smtpServer.getText(), 25);
         InputStream inStream = s.getInputStream();
         OutputStream outStream = s.getOutputStream();
         in = new Scanner(inStream);         
         output = new PrintWriter(outStream, true );
         String hostName = InetAddress.getLocalHost().getHostName();
         receive();
         send("HELO " + hostName);
         receive();
         send("寄件者: <" + from.getText() + ">");
         receive();
         send("收件者: <" + to.getText() + ">");
         receive();
         send("資料");
         receive();
         send(message.getText());
         send(".");
         receive();
         s.close();
      }
      catch (IOException e)
      {  
         textArea.append("Error: " + e);
      }
   }
   public void send(String s) throws IOException
   {  
      textArea.append(s);
      textArea.append("\n");
      output.print(s.replaceAll("\n", "\r\n"));
      output.print("\r\n");
      output.flush();
   }
   public void receive() throws IOException
   {
      if (in.hasNextLine());
      {
         String line = in.nextLine();
         textArea.append(line);
         textArea.append("\n");
      }
   }   
}

