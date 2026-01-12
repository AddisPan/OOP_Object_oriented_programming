import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.Container;
import java.awt.GridLayout;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Color;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
public class TextFieldTest extends JFrame implements ActionListener
{
    public static final int WIDTH = 300;
    public static final int HEIGHT = 200;
    public static final int NUMBER_OF_CHAR = 30;
    private JTextField name;
    public static void main(String[] args)
    {
        TextFieldTest Text1 = new TextFieldTest( );
        Text1.setVisible(true);
    }
    public TextFieldTest( )
    {
        super("文字欄位測試");
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container content = getContentPane( );
        content.setLayout(new GridLayout(2, 1));        
        JPanel namePanel = new JPanel( ); 
        namePanel.setLayout(new BorderLayout( ));
        namePanel.setBackground(Color.GREEN); 
        name = new JTextField(NUMBER_OF_CHAR);
        namePanel.add(name, BorderLayout.SOUTH);
        JLabel nameLabel = new JLabel("在這裡輸入你的名子:");
        namePanel.add(nameLabel, BorderLayout.CENTER);
        content.add(namePanel);
        JPanel buttonPanel = new JPanel( );
        buttonPanel.setLayout(new FlowLayout( ));
        buttonPanel.setBackground(Color.YELLOW); 
        JButton actionButton = new JButton("按下去"); 
        actionButton.addActionListener(this);
        buttonPanel.add(actionButton);
        JButton clearButton = new JButton("清除"); 
        clearButton.addActionListener(this);
        buttonPanel.add(clearButton); 
        content.add(buttonPanel);
    }
    public void actionPerformed(ActionEvent e) 
    {
        String actionCommand = e.getActionCommand( );

        if (actionCommand.equals("按下去"))
            name.setText("哈囉"+name.getText()+"你好");
        else if (actionCommand.equals("清除"))
            name.setText("");
        else
            name.setText("Unexpected error.");
    } 
}


