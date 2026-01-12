import java.awt.*;
import java.awt.geom.*;
import javax.swing.*;
public class Draw2
{  
   public static void main(String[] args)
   {  
      DrawFrame frame = new DrawFrame();
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      frame.setVisible(true);
   }
}
class DrawPanel extends JPanel
{  
   public void paint(Graphics g)
   {  
      super.paint(g);
      Graphics2D g2 = (Graphics2D) g;
      double leftX = 100;
      double topY = 100;
      double width = 200;
      double height = 150;
      Rectangle2D rect = new Rectangle2D.Double(leftX, topY, width, height);
      g2.draw(rect);
      Ellipse2D ellipse = new Ellipse2D.Double();
      ellipse.setFrame(rect);
      g2.draw(ellipse);
      g2.draw(new Line2D.Double(leftX+width, topY, leftX, topY + height));
      double centerX = rect.getCenterX();
      double centerY = rect.getCenterY();
      double radius = 150;
      Ellipse2D circle = new Ellipse2D.Double();
      circle.setFrameFromCenter(centerX, centerY, centerX + radius,
                                                       centerY + radius);
      g2.draw(circle);
   }
}
class DrawFrame extends JFrame
{
   public static final int WIDTH1 = 380;
   public static final int HEIGHT1 = 380; 
   public DrawFrame()
   {
      setTitle("Ã¸»s¹Ï§Î");
      setSize(WIDTH1, HEIGHT1);
      DrawPanel panel = new DrawPanel();
      add(panel);
   } 
}

