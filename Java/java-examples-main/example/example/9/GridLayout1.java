import javax.swing.JFrame;
import javax.swing.JLabel;
import java.awt.Container;
import java.awt.GridLayout;
public class GridLayout1 extends JFrame
{
    public static final int WIDTH = 400;
    public static final int HEIGHT = 200;
    public static void main(String[] args)
    {
        GridLayout1 Grid = new GridLayout1(2, 4);
        Grid.setVisible(true);
    }
    public GridLayout1(int rows, int columns )
    {
        super( );
        setSize(WIDTH, HEIGHT);
        setTitle("示範佈置格子");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = getContentPane( );
        contentPane.setLayout(new GridLayout(rows, columns ));
        JLabel label1 = new JLabel("第一個標籤");
        contentPane.add(label1);
        JLabel label2 = new JLabel("第二個標籤");
        contentPane.add(label2);
        JLabel label3 = new JLabel("第三個標籤");
        contentPane.add(label3);
        JLabel label4 = new JLabel("第四個標籤");
        contentPane.add(label4);
        JLabel label5 = new JLabel("第五個標籤");
        contentPane.add(label5);
        JLabel label6 = new JLabel("第六個標籤");
        contentPane.add(label6);
        JLabel label7 = new JLabel("第七個標籤");
        contentPane.add(label7);
        JLabel label8 = new JLabel("第八個標籤");
        contentPane.add(label8);
    }
}
