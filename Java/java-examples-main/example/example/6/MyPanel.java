import java.awt.Graphics;
import javax.swing.JPanel;
public class MyPanel extends JPanel {
  private String message = "¦n­ÓJava";
  private int xCoordinate = 20;
  private int yCoordinate = 20;
  public MyPanel() {
  }
  public MyPanel(String message) {
    this.message = message;
  }
  public String getMessage() {
    return message;
  }
  public void setMessage(String message) {
    this.message = message;
    repaint();
  }
  protected void paintComponent(Graphics g) {
    super.paintComponent(g);
    g.drawString(message, xCoordinate, yCoordinate);
  }
  public int getXCoordinate() {
    return xCoordinate;
  }
  public void setXCoordinate(int x) {
    this.xCoordinate = x;
    repaint();
  }
  public int getYCoordinate() {
    return yCoordinate;
  }
  public void setYCoordinate(int y) {
    this.yCoordinate = y;
    repaint();
  }
}
