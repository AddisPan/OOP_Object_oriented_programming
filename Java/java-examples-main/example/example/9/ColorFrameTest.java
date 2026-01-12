import java.awt.Color;
public class ColorFrameTest
{
    public static void main(String[] args) 
    {
        ColorFrame f1 = new ColorFrame( );
        f1.setVisible(true);
        ColorFrame f2 = new ColorFrame(Color.WHITE);
        f2.setVisible(true);
        ColorFrame f3 = new ColorFrame(Color.ORANGE);
        f3.setVisible(true);
    }
}
