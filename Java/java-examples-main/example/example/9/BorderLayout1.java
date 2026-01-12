import javax.swing.JFrame;
import javax.swing.JLabel;
import java.awt.Container;
import java.awt.BorderLayout;
public class BorderLayout1 extends JFrame
{
    public static final int WIDTH = 300;
    public static final int HEIGHT = 300;
    public BorderLayout1( )
    {
        super("示範佈置邊界" );
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        contentPane.setLayout(new BorderLayout( ));
        JLabel labelNorth = new JLabel("            標籤NORTH");
        contentPane.add(labelNorth, BorderLayout.NORTH); 
        JLabel labelCenter = new JLabel("           標籤CENTER");
        contentPane.add(labelCenter, BorderLayout.CENTER); 
        JLabel labelSouth = new JLabel("            標籤SOUTH");
        contentPane.add(labelSouth, BorderLayout.SOUTH); 
        JLabel labelWest = new JLabel("標籤WEST");
        contentPane.add(labelWest, BorderLayout.WEST); 
        JLabel labelEast = new JLabel("標籤EAST");
        contentPane.add(labelEast, BorderLayout.EAST); 
    }
}
