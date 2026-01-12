import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.BorderLayout;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.io.IOException;
import javax.swing.*;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import java.net.SocketException;
import javax.swing.SwingUtilities;
public class UDPClient extends JFrame 
{
   private JTextField Text_Field; 
   private JTextArea AreaDisplay; 
   private DatagramSocket UDPsocket; 
   public static void main(	String args[] )
   {
	  UDPClient	UDP	= new UDPClient(); 
	  UDP.setDefaultCloseOperation(	JFrame.EXIT_ON_CLOSE );
	  UDP.waitForPackets(); 
   } 
   public UDPClient(){
	  super( "使用者端,使用UDP協定廣播傳輸" );
	  MListener	ML=new MListener();
	  Text_Field = new JTextField("");
	  JLabel labelwest=new JLabel("請在上面輸入資料");
	  Text_Field = new JTextField();
	  Text_Field.addActionListener(ML);
	  add( labelwest, BorderLayout.WEST); 
	  add( Text_Field, BorderLayout.NORTH );
	  AreaDisplay =	new	JTextArea();
	  add( new JScrollPane(	AreaDisplay	), BorderLayout.CENTER );
	  setSize( 300,	300	); 
	  setVisible( true ); 
	  try {
		 UDPsocket	= new DatagramSocket();
	  }catch ( SocketException socketException ){
		 socketException.printStackTrace();
		 System.exit( 1 );
	  } 
   } 
   public void waitForPackets()
   {
	  while	( true ) 
	  {
		 try{
			byte data[]	= new byte[	100	]; 
			DatagramPacket receivePacket = new DatagramPacket( 
			   data, data.length );
			UDPsocket.receive(	receivePacket ); 
			displayMessage(	"\n接收封包:" + 
			   "\n從主機: " + receivePacket.getAddress() + 
			   "\n主機連接埠: " + receivePacket.getPort() + 
			   "\n資料長度: "	+ receivePacket.getLength() + 
			   "\n包含:\n\t" + new String( receivePacket.getData(), 
				  0, receivePacket.getLength() ) );
		 } catch ( IOException exception ){
			displayMessage(	exception.toString() + "\n" );
			exception.printStackTrace();
		 } 
	  } 
   } 
   private void	displayMessage(	final String messageToDisplay )
   {
	  SwingUtilities.invokeLater(
		 new Runnable()
		 {
			public void	run() 
			{
			   AreaDisplay.append( messageToDisplay );
			} 
		 }  
	  ); 
   } 
   public class	MListener implements ActionListener{
	 public	void actionPerformed( ActionEvent event ){
	   try{
		 String message = event.getActionCommand();
		 AreaDisplay.append( "傳送的封包訊息:" +message + "\n" );

		 byte data[] =	message.getBytes(); 
		 DatagramPacket sendPacket	= new DatagramPacket( data, 
			    data.length, InetAddress.getLocalHost(), 9000 );
         	 UDPsocket.send( sendPacket ); 
		 AreaDisplay.append( "封包傳送\n" );
		 AreaDisplay.setCaretPosition( 
		 AreaDisplay.getText().length() );
	   }catch (	IOException	ioException ){
	     	 displayMessage( ioException.toString() + "\n" );
		 ioException.printStackTrace();
	   } 
	 }		
   }
} 

