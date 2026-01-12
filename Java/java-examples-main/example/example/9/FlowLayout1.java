import javax.swing.JFrame;
import javax.swing.JLabel;
import java.awt.Container;
import java.awt.FlowLayout;
public class FlowLayout1 extends JFrame
{
    public static final int WIDTH = 300;
    public static final int HEIGHT = 100;
    public FlowLayout1( )
    {
        super("•‹Ωd∂∂ß«ßG∏m" );
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        contentPane.setLayout(new FlowLayout( ));
        JLabel label1 = new JLabel("º–≈“1");
        contentPane.add(label1); 
        JLabel label2 = new JLabel("º–≈“2");
        contentPane.add(label2); 
        JLabel label3 = new JLabel("º–≈“3");
        contentPane.add(label3); 
 
    }
}
