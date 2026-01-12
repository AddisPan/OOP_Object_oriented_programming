import javax.swing.JFrame;
import javax.swing.JButton;
public class Swing1Test
{
    public static final int WIDTH = 200; 
    public static final int HEIGHT = 100;
    public static void main(String[] args)
    {
        JFrame Frame1 = new JFrame( );
        Frame1.setSize(WIDTH, HEIGHT);
        Frame1.setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
        JButton endButton = new JButton("µ²§ôµ{¦¡");
        EndListener buttonEar = new EndListener( );
        endButton.addActionListener(buttonEar);
        Frame1.getContentPane( ).add(endButton);
        Frame1.setVisible(true);
    }
}

