import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Container;
import java.awt.BorderLayout;
import java.awt.Graphics;
import java.awt.Color;
import java.awt.Font;
public class DrawStringTest extends JFrame  implements ActionListener
{
    public static final int WIDTH = 380;
    public static final int HEIGHT = 100;
    public static final int X_START = 20;
    public static final int Y_START = 55;
    public static final int POINT_SIZE = 18;
    public static final int POINT_SIZE1 = 20;

    private String theText = "這是新細明體";
    private Color penColor = Color.BLACK;
    private Font fontObject = new Font("新細明體", Font.PLAIN, POINT_SIZE);
    public static void main(String[] args)
    {
        DrawStringTest frame1 = new DrawStringTest( );
        frame1.setVisible(true);
    }
    public DrawStringTest( )
    {
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setTitle("繪製字串");
        Container contentPane = getContentPane( );
        contentPane.setBackground(Color.WHITE);
        contentPane.setLayout(new BorderLayout( ));
        JPanel buttonPanel = new JPanel( );
        buttonPanel.setBackground(Color.ORANGE);
        buttonPanel.setLayout(new BorderLayout( ));
        JButton theButton = new JButton("按鈕");
        theButton.addActionListener(this);
        buttonPanel.add(theButton, BorderLayout.CENTER);
        contentPane.add(buttonPanel, BorderLayout.SOUTH);
    }
    public void paint(Graphics g)
    {
        super.paint(g);
        g.setFont(fontObject);
        g.setColor(penColor);
        g.drawString(theText, X_START, Y_START);
    }
    public void actionPerformed(ActionEvent e)
    {
        penColor = Color.BLUE;
        fontObject =new Font("標楷體", Font.BOLD, POINT_SIZE);
        theText = "1-5FONTS和drawString()方法,標楷體";
        repaint( );
    }
}


