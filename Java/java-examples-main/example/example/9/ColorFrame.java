import javax.swing.JFrame;
import javax.swing.JLabel;
import java.awt.Color;
import java.awt.Container;
public class ColorFrame extends JFrame
{
    public static final int WIDTH = 200; 
    public static final int HEIGHT = 100;
    public ColorFrame(Color Co)
    {
        super("No Charge for Color" );
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        contentPane.setBackground(Co);
        JLabel aLabel = new JLabel("¤j®a¦nSwing.");
        contentPane.add(aLabel);
    }
    public ColorFrame( )
    {
        this(Color.GREEN);
    }
}
