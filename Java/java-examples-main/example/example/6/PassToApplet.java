import javax.swing.*;
public class PassToApplet extends JApplet {
  public void init() {
    String message = getParameter("String1");
    int x = Integer.parseInt(getParameter("X"));
    int y = Integer.parseInt(getParameter("Y"));
    MyPanel Panel1 = new MyPanel(message);
    Panel1.setXCoordinate(x);
    Panel1.setYCoordinate(y);
    getContentPane().add(Panel1);
  }
}