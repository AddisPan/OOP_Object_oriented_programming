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
public class MenuTest extends JFrame implements ActionListener
{
    public static final int WIDTH = 300;
    public static final int HEIGHT = 150;
    private JPanel YellowPanel,GreenPanel;
    public static void main(String[] args)
    {
        MenuTest Menu1 = new MenuTest( );
        Menu1.setVisible(true);
    }
    public MenuTest( )
    {
        super("示範選單");
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        contentPane.setLayout(new GridLayout(1, 2));
        YellowPanel = new JPanel( );
        YellowPanel.setBackground(Color.WHITE);
        contentPane.add(YellowPanel);
        GreenPanel = new JPanel( );
        GreenPanel.setBackground(Color.WHITE);
        contentPane.add(GreenPanel);
        JMenu colorMenu = new JMenu("增加色彩");
        JMenuItem YellowChoice = new JMenuItem("黃色");
        YellowChoice.addActionListener(this);
        colorMenu.add(YellowChoice);
        JMenuItem GreenChoice = new JMenuItem("綠色");
        GreenChoice.addActionListener(this);
        colorMenu.add(GreenChoice);
        JMenuBar bar = new JMenuBar( );
        bar.add(colorMenu);
        setJMenuBar(bar);
    }
    public void actionPerformed(ActionEvent e)
    {
        String buttonString = e.getActionCommand( );

        if (buttonString.equals("黃色"))
            YellowPanel.setBackground(Color.YELLOW);
        else if (buttonString.equals("綠色"))
            GreenPanel.setBackground(Color.GREEN);
        else
            System.out.println("Unexpected error.");
    }
}
