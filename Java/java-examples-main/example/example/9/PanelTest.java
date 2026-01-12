import javax.swing.JFrame;
import javax.swing.JPanel;
import java.awt.Container;
import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.FlowLayout;
import java.awt.Color;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
public class PanelTest extends JFrame implements ActionListener
{
    public static final int WIDTH = 300;
    public static final int HEIGHT = 100;
    private JPanel greenPanel;
    private JPanel grayPanel;
    private JPanel yellowPanel;
    private JPanel biggerPanel;
    public static void main(String[] args)
    {
        PanelTest panel = new PanelTest( );
        panel.setVisible(true);
    }
    public PanelTest( )
    {
        super("面板Panel");
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        contentPane.setLayout(new BorderLayout( ));
        biggerPanel = new JPanel( );
        biggerPanel.setLayout(new GridLayout(1, 3));
        greenPanel = new JPanel( );
        greenPanel.setBackground(Color.LIGHT_GRAY);
        biggerPanel.add(greenPanel);
        grayPanel = new JPanel( );
        grayPanel.setBackground(Color.LIGHT_GRAY);
        biggerPanel.add(grayPanel);
        yellowPanel = new JPanel( );
        yellowPanel.setBackground(Color.LIGHT_GRAY);
        biggerPanel.add(yellowPanel);
        contentPane.add(biggerPanel, BorderLayout.CENTER);
        JPanel buttonPanel = new JPanel( );
        buttonPanel.setBackground(Color.LIGHT_GRAY);
        buttonPanel.setLayout(new FlowLayout( ));
        JButton greenButton = new JButton("綠色");
        greenButton.setBackground(Color.GREEN);
        greenButton.addActionListener(this);
        buttonPanel.add(greenButton);
        JButton grayButton = new JButton("灰色");
        grayButton.setBackground(Color.GRAY);
        grayButton.addActionListener(this);
        buttonPanel.add(grayButton);
        JButton yellowButton = new JButton("黃色");
        yellowButton.setBackground(Color.YELLOW);
        yellowButton.addActionListener(this);
        buttonPanel.add(yellowButton);        
        JButton clearButton = new JButton("清除");
        clearButton.setBackground(Color.RED);
        clearButton.addActionListener(this);
        buttonPanel.add(clearButton);
        contentPane.add(buttonPanel, BorderLayout.SOUTH);
    }
    public void actionPerformed(ActionEvent e)
    {
        String buttonString = e.getActionCommand( );
        if (buttonString.equals("綠色"))
            greenPanel.setBackground(Color.GREEN);
        else if (buttonString.equals("灰色"))
            grayPanel.setBackground(Color.GRAY);
        else if (buttonString.equals("黃色"))
            yellowPanel.setBackground(Color.YELLOW);
        else if (buttonString.equals("清除")){
            greenPanel.setBackground(Color.LIGHT_GRAY);
            grayPanel.setBackground(Color.LIGHT_GRAY);
            yellowPanel.setBackground(Color.LIGHT_GRAY);
        }else
            System.out.println("Unexpected error.");
    }
}
