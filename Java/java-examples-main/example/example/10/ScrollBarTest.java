import javax.swing.JFrame;
import javax.swing.JTextArea;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JScrollPane;
import java.awt.Container;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Color;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
public class ScrollBarTest extends JFrame implements ActionListener
{
    public static final int WIDTH = 500,HEIGHT=300,LINES=8,CHAR_PER_LINE=8;
    private JTextArea Jt1;
    private String test1,test2;
    public static void main(String[] args)
    {
        ScrollBarTest sb1 = new ScrollBarTest( );
        sb1.setVisible(true);
    }
    public ScrollBarTest( )
    {
        super("Scroll Bars捲軸測試");
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        JPanel buttonPanel = new JPanel( );
        buttonPanel.setBackground(Color.LIGHT_GRAY);
        buttonPanel.setLayout(new FlowLayout( ));
        JButton test1Button = new JButton("儲存test1"); 
        test1Button.addActionListener(this);
        buttonPanel.add(test1Button);  
        JButton test2Button = new JButton("儲存test2"); 
        test2Button.addActionListener(this);
        buttonPanel.add(test2Button);
        JButton clearButton = new JButton("清除"); 
        clearButton.addActionListener(this);
        buttonPanel.add(clearButton); 
        JButton get1Button = new JButton("顯示test1"); 
        get1Button.addActionListener(this);
        buttonPanel.add(get1Button);
        JButton get2Button = new JButton("顯示test2"); 
        get2Button.addActionListener(this);
        buttonPanel.add(get2Button);
        contentPane.add(buttonPanel, BorderLayout.SOUTH);
        JPanel textPanel = new JPanel( ); 
        textPanel.setBackground(Color.BLUE);
        Jt1 = new JTextArea(LINES, CHAR_PER_LINE);
        Jt1.setBackground(Color.WHITE);
        JScrollPane SText = new JScrollPane(Jt1);
        SText.setHorizontalScrollBarPolicy(
                    JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
        SText.setVerticalScrollBarPolicy(
                    JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
        textPanel.add(SText);
        contentPane.add(textPanel, BorderLayout.CENTER);
    }
    public void actionPerformed(ActionEvent e)
    {
        String actionCommand = e.getActionCommand( );
        if (actionCommand.equals("儲存test1"))
            test1 = Jt1.getText( );
        else if (actionCommand.equals("儲存test2"))
            test2 = Jt1.getText( );
        else if (actionCommand.equals("清除"))
            Jt1.setText("");
        else if (actionCommand.equals("顯示test1"))
            Jt1.setText(test1);
        else if (actionCommand.equals("顯示test2"))
            Jt1.setText(test2);
        else
            Jt1.setText("Error in memo interface");
     } 
}

 