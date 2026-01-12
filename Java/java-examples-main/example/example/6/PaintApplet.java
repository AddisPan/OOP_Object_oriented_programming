import java.awt.Graphics;       
import javax.swing.JApplet;    
import javax.swing.JOptionPane; 
public class PaintApplet extends JApplet 
{
   private double s; 
   public void init()
   {
      String x,y; 
      double n1,n2; 
      x = JOptionPane.showInputDialog("請輸入第一個數" );
      y = JOptionPane.showInputDialog("請輸入第二個數");
      n1 = Double.parseDouble( x ); 
      n2 = Double.parseDouble( y );
      s = n1 + n2; 
   } 
   public void paint( Graphics g )
   {
      super.paint( g ); 
      g.drawRect( 20, 20, 250, 50 );
      g.drawString( "總合是 " + s, 30, 30 );
   } 
} 
