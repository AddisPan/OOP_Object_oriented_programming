import java.awt.*;
import java.awt.geom.*;
import javax.swing.*;
public class DrawFill
{  
   public static void main(String[] args)
   {  
      FillFrame frame = new FillFrame();
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      frame.setVisible(true);
   }
}
class FillPanel extends JPanel
{  
   public void paintComponent(Graphics g)
   {  
      super.paintComponent(g);
      Graphics2D g2 = (Graphics2D) g;
      double leftX = 30;
      double topY = 50;
      double width = 180;
      double height = 150;
      Rectangle2D rect = new Rectangle2D.Double(leftX, topY, width, height);
      g2.setPaint(Color.YELLOW);
      g2.fill(rect);
      Ellipse2D ellipse = new Ellipse2D.Double();
      ellipse.setFrame(rect);
      g2.setPaint(new Color(0,  0, 255));
      g2.fill(ellipse);
   }
}
class FillFrame extends JFrame
{
   public static final int DEFAULT_WIDTH = 250;
   public static final int DEFAULT_HEIGHT = 250; 
   public FillFrame()
   {
      setTitle("Ã¸¹Ï¶ñº¡");
      setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);
      FillPanel panel = new FillPanel();
      add(panel);
   } 
}


