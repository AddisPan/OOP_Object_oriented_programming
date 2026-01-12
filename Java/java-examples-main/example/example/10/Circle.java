import javax.swing.JFrame;
import java.awt.Graphics;
import java.awt.Color;
public class Circle extends JFrame
{
    public static final int WINDOW_WIDTH = 300;
    public static final int WINDOW_HEIGHT = 300;
    public static final int Circle_DIAMETER = 150;
    public static final int X_Circle = 100;
    public static final int Y_Circle = 100;
    public static final int LINE_WIDTH = 150;
    public static final int X_LINE = X_Circle ;
    public static final int Y_LINE = Y_Circle + 75;
    public static void main(String[] args)
    {
        Circle drawing = new Circle( );
        drawing.setVisible(true);
    }
    public Circle( )
    {
        super("Ã¸»s¹Ï§Î");
        setSize( WINDOW_WIDTH, WINDOW_HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        getContentPane( ).setBackground(Color.white);
    }
    public void paint(Graphics g)
    {
        super.paint(g);
        g.drawOval(X_Circle, Y_Circle, Circle_DIAMETER, Circle_DIAMETER);
        g.drawLine(X_LINE, Y_LINE, X_LINE + LINE_WIDTH, Y_LINE);
        g.drawLine(175, 100, 175 , 250);
    }
}
