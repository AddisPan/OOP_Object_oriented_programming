import java.awt.Graphics;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.JApplet;
public class ImageApplet extends JApplet 
{
   private ImageIcon image1; 
   private Image image2;   
   public void init()
   {
   	  image1 = new ImageIcon( "good.jpg" );
      image2 = this.getImage( getDocumentBase(), "background.jpg" );      
   } 
   public void paint( Graphics g )
   {
      super.paint( g );
      g.drawImage( image2, 0, 0, getWidth(), getHeight(), this );
      image1.paintIcon( this, g, 180, 100 );
   } 
} 