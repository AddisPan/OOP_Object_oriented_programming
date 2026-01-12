import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.SocketException;
import java.awt.BorderLayout;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.SwingUtilities;
public class UDPServer extends JFrame
{
   private JTextArea AreaDisplay;
   private DatagramSocket UDPsocket;
   public static void main( String args[] )
   {
      UDPServer UDPS = new UDPServer();
      UDPS.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
      UDPS.waitForPackets();
   }
   public UDPServer()
   {
      super( "使用UDP協定的伺服器" );
      AreaDisplay = new JTextArea();
      add( new JScrollPane( AreaDisplay ), BorderLayout.CENTER );
      setSize( 300, 300 );
      setVisible( true );
      try {
         UDPsocket = new DatagramSocket( 9000 );
      } catch ( SocketException socketException ){
         socketException.printStackTrace();
         System.exit( 1 );
      }
   }
   public void waitForPackets()
   {
      while ( true )
      {
         try{
            byte data[] = new byte[ 100 ];
            DatagramPacket receivePacket =
               new DatagramPacket( data, data.length );
            UDPsocket.receive( receivePacket );
            displayMessage( "\n封包接收:" +
               "\n從主機: " + receivePacket.getAddress() +
               "\n主機連接埠: " + receivePacket.getPort() +
               "\n資料長度: " + receivePacket.getLength() +
               "\n包含:\n\t" + new String( receivePacket.getData(),
                  0, receivePacket.getLength() ) );
            sendPacketToClient( receivePacket );
         }catch ( IOException ioException )
         {
            displayMessage( ioException.toString() + "\n" );
            ioException.printStackTrace();
         }
      }
   }
   private void sendPacketToClient( DatagramPacket receivePacket )
      throws IOException
   {
      displayMessage( "\n\n回應使用者端的資料" );
      DatagramPacket sendPacket = new DatagramPacket(
         receivePacket.getData(), receivePacket.getLength(),
         receivePacket.getAddress(), receivePacket.getPort() );

      UDPsocket.send( sendPacket );
      displayMessage( "封包傳送\n" );
   }
   private void displayMessage( final String messageToDisplay )
   {
      SwingUtilities.invokeLater(
         new Runnable()
         {
            public void run(){
               AreaDisplay.append( messageToDisplay );
            }
         }
      );
   }
}

