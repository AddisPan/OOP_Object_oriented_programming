import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.ImageIcon;
public class ButtonTest extends JFrame  {
  public static void main(String[] args) {
    JFrame frame = new ButtonTest();
    frame.setTitle("按鈕物件");
    frame.setSize(300, 200);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
  public ButtonTest() {
    ImageIcon image1 = new ImageIcon("image1.gif");
    ImageIcon image2 = new ImageIcon("image2.gif");
    ImageIcon image3 = new ImageIcon("image3.gif");
    JButton b1 = new JButton("請按我", image1);
    b1.setPressedIcon(image2);
    b1.setRolloverIcon(image3);
    getContentPane().add(b1);
  }
}

