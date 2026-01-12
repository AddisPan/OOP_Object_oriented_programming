import javax.swing.JFrame;
import javax.swing.JPanel;
import java.awt.Container;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Color;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.WindowListener;
import java.awt.event.WindowEvent;
public class WindowListenerTest extends JFrame
{
    public static final int WIDTH = 300;
    public static final int HEIGHT = 100; 
    public static final int WIDTH2 = 200; 
    public static final int HEIGHT2 = 100;
    public static void main(String[] args)
    {
        WindowListenerTest Window1 = new WindowListenerTest( );
        Window1.setVisible(true);
    }
    public WindowListenerTest( )
    {
        setSize(WIDTH, HEIGHT);
        setTitle("視窗傾聽者");
        setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
        addWindowListener(new ExitWindowListener( ));
        Container contentPane = getContentPane( );
        contentPane.setBackground(Color.LIGHT_GRAY);
        JLabel aLabel = new JLabel("請按下關閉視窗按鈕.");
        contentPane.add(aLabel);
    }
    private class ExitWindowListener implements WindowListener
    {
        public void windowClosing(WindowEvent e)
        {
            Window1 frame1 = new Window1( );
            frame1.setVisible(true);
        }
        public void windowOpened(WindowEvent e)
        {}
        public void windowActivated(WindowEvent e)
        {}
        public void windowClosed(WindowEvent e)
        {}
        public void windowIconified(WindowEvent e)
        {}
        public void windowDeiconified(WindowEvent e)
        {}        
        public void windowDeactivated(WindowEvent e)
        {}
    } 
    private class Window1 extends JFrame implements ActionListener
    {
        public Window1( )
        {
            setSize(WIDTH2, HEIGHT2);
            Container confirmContent = getContentPane( );
            confirmContent.setBackground(Color.WHITE);
            confirmContent.setLayout(new BorderLayout( ));
            JLabel confirmLabel = new JLabel("你確定要離開?");
            confirmContent.add(confirmLabel, BorderLayout.NORTH);
            JPanel buttonPanel = new JPanel( );
            buttonPanel.setBackground(Color.GREEN);
            buttonPanel.setLayout(new FlowLayout( ));
            JButton exitButton = new JButton("是");
            exitButton.addActionListener(this);
            buttonPanel.add(exitButton);
            JButton cancelButton = new JButton("否");
            cancelButton.addActionListener(this);
            buttonPanel.add(cancelButton);
            confirmContent.add(buttonPanel, BorderLayout.SOUTH);
        }
        public void actionPerformed(ActionEvent e)
        {
            String actionCommand = e.getActionCommand( );
            if (actionCommand.equals("是"))
                System.exit(0);
            else if (actionCommand.equals("否"))
                dispose( );
            else
                System.out.println("Unexpected Error in Confirm Window.");
        }
    } 
}
