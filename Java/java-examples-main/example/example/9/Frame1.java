import javax.swing.JFrame;
import javax.swing.JButton;

public class Frame1 extends JFrame
{
    public static final int WIDTH = 200; 
    public static final int HEIGHT = 100;
    public Frame1( )
    {
        super( );
        setSize(WIDTH, HEIGHT);
        setTitle("第一個Frmae");
        setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
        JButton endButton = new JButton("結束程式");
        endButton.addActionListener(new EndListener( ));
        getContentPane( ).add(endButton);
    }
}
