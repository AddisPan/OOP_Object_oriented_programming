import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Container;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Color;
public class ColorChooserTest extends JFrame
                               implements ActionListener
{
    public static final int WIDTH = 150;
    public static final int HEIGHT = 100;
    private Container contentPane; 
    private Color sampleColor = Color.LIGHT_GRAY;
    public static void main(String[] args)
    {
        ColorChooserTest frame1 = new ColorChooserTest( );
        frame1.setVisible(true);
    }
    public ColorChooserTest( )
    {
        contentPane = getContentPane( );
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        contentPane.setBackground(sampleColor);
        contentPane.setLayout(new BorderLayout( ));
        setTitle("調色盤");
        setSize(WIDTH, HEIGHT);
        JPanel buttonPanel = new JPanel( );
        buttonPanel.setBackground(Color.WHITE);
        buttonPanel.setLayout(new FlowLayout( ));
        JButton chooseButton = new JButton("選取顏色");
        chooseButton.addActionListener(this);
        buttonPanel.add(chooseButton);
        contentPane.add(buttonPanel, BorderLayout.SOUTH);
    }
    public void actionPerformed(ActionEvent e) 
    {
        if (e.getActionCommand( ).equals("選取顏色")){
            sampleColor = 
               JColorChooser.showDialog(this, "調色盤", sampleColor);
            if (sampleColor != null)
                contentPane.setBackground(sampleColor);
        }else 
            System.out.println("Unanticipated Error");
    }
}


