import javax.swing.JFrame;
import javax.swing.JPanel;
import java.awt.Container;
import java.awt.GridLayout;
import java.awt.Color;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import javax.swing.JMenuBar;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
public class InnerListeners extends JFrame
{
    public static final int WIDTH = 300;
    public static final int HEIGHT = 150;
    private JPanel greenPanel,yellowPanel;
    public static void main(String[] args)
    {
        InnerListeners Menu1 = new InnerListeners( );
        Menu1.setVisible(true);
    }
    public InnerListeners( )
    {
        super("示範選單");
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        contentPane.setLayout(new GridLayout(1, 2));
        greenPanel = new JPanel( );
        greenPanel.setBackground(Color.LIGHT_GRAY);
        contentPane.add(greenPanel);
        yellowPanel = new JPanel( );
        yellowPanel.setBackground(Color.LIGHT_GRAY);
        contentPane.add(yellowPanel);
        JMenu colorMenu = new JMenu("增加色彩");
        JMenuItem GreenChoice = new JMenuItem("綠色");
        GreenChoice.addActionListener(new GreenListener( ));
        colorMenu.add(GreenChoice);
        JMenuItem YellowChoice = new JMenuItem("黃色");
        YellowChoice.addActionListener(new YellowListener( ));
        colorMenu.add(YellowChoice);
        JMenuBar bar = new JMenuBar( );
        bar.add(colorMenu);
        setJMenuBar(bar);
    }
    private class GreenListener implements ActionListener
    {
        public void actionPerformed(ActionEvent e)
        {
            greenPanel.setBackground(Color.GREEN);
        }
    } 
    private class YellowListener implements ActionListener
    {
        public void actionPerformed(ActionEvent e)
        {
            yellowPanel.setBackground(Color.YELLOW);
        }
    }
}
