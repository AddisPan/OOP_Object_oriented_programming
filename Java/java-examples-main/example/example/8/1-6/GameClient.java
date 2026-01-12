import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.LineBorder;
import java.io.*;
import java.net.*;
public class GameClient extends JApplet implements Runnable,InterfaceConstants{
  private boolean myTurn = false;
  private char myToken = ' ';
  private char otherToken = ' ';
  private Cell[][] cell =  new Cell[3][3];
  private JLabel JTitle = new JLabel();
  private JLabel JStatus= new JLabel();
  private int rowSelected;
  private int columnSelected;
  private DataInputStream fromServer;
  private DataOutputStream toServer;
  private boolean continueToPlay = true;
  private boolean waiting = true;
  private boolean isStandAlone = false;
  private String host = "localhost";
  public void init() {
    JPanel PCell = new JPanel();
    PCell.setLayout(new GridLayout(3, 3, 0, 0));
    for (int i = 0; i < 3; i++){
      for (int j = 0; j < 3; j++){
        PCell.add(cell[i][j] = new Cell(i, j));
      }
    }
    PCell.setBorder(new LineBorder(Color.black, 1));
    JTitle.setHorizontalAlignment(JLabel.CENTER);
    JTitle.setFont(new Font("標楷體", Font.BOLD, 18));
    JTitle.setBorder(new LineBorder(Color.BLUE, 1));
    JStatus.setBorder(new LineBorder(Color.BLUE, 1));
    this.getContentPane().add(JTitle, BorderLayout.NORTH);
    this.getContentPane().add(PCell, BorderLayout.CENTER);
    this.getContentPane().add(JStatus, BorderLayout.SOUTH);
    connectToServer();
  }

  private void connectToServer() {
    try {
      Socket socket;
      if (isStandAlone)
        socket = new Socket(host, 9000);
      else
        socket = new Socket(getCodeBase().getHost(), 9000);
      fromServer = new DataInputStream(socket.getInputStream());
      toServer = new DataOutputStream(socket.getOutputStream());
    }
    catch (Exception ex) {
      System.err.println(ex);
    }
    Thread thread = new Thread(this);
    thread.start();
  }

  public void run() {
    try {
      int player = fromServer.readInt();
      if (player == PLAYER1) {
        myToken = 'X';
        otherToken = 'O';
        JTitle.setText("玩家1,使用'X'");
        JStatus.setText("要兩個人玩,等待玩家2加入");
        fromServer.readInt();
        JStatus.setText("玩家2加入,玩家1先下手");
        myTurn = true;
      }
      else if (player == PLAYER2) {
        myToken = 'O';
        otherToken = 'X';
        JTitle.setText("玩家2,使用'O'");
        JStatus.setText("遊戲開始,玩家1先玩");
      }
      while (continueToPlay) {
        if (player == PLAYER1) {
          waitForPlayerAction(); 
          sendMove(); 
          receiveInfoFromServer(); 
        }
        else if (player == PLAYER2) {
          receiveInfoFromServer(); 
          waitForPlayerAction(); 
          sendMove();
        }
      }
    }
    catch (Exception ex) {
    }
  }
  private void waitForPlayerAction() throws InterruptedException {
    while (waiting) {
      Thread.sleep(100);
    }
    waiting = true;
  }
  private void sendMove() throws IOException {
    toServer.writeInt(rowSelected); 
    toServer.writeInt(columnSelected);
  }
  private void receiveInfoFromServer() throws IOException {
    int status = fromServer.readInt();
    if (status == PLAYER1_WON) {
      continueToPlay = false;
      if (myToken == 'X') {
        JStatus.setText("不用看,一定我贏了!");
      }else if (myToken == 'O') {
        JStatus.setText("下一次,你不要拜在我手上!");
        receiveMove();
      }
    }else if (status == PLAYER2_WON) {
      continueToPlay = false;
      if (myToken == 'O') {
        JStatus.setText("耶,我贏了(O)!");
      }else if (myToken == 'X') {
        JStatus.setText("輸了,我真笨!");
        receiveMove();
      }
    }else if (status == EQUAL) {
      continueToPlay = false;
      JStatus.setText("遊戲結束,平手!");
      if (myToken == 'O') {
        receiveMove();
      }
    }else {
      receiveMove();
      JStatus.setText("換我了");
      myTurn = true; 
    }
  }
  private void receiveMove() throws IOException {
    int row = fromServer.readInt();
    int column = fromServer.readInt();
    cell[row][column].setToken(otherToken);
  }
  private class Cell extends JPanel implements MouseListener {
    private int row;
    private int column;
    private char token = ' ';
    public Cell(int row, int column) {
      this.row = row;
      this.column = column;
      setBorder(new LineBorder(Color.black, 1)); 
      addMouseListener(this);  
    }
    public char getToken() {
      return token;
    }
    public void setToken(char c) {
      token = c;
      repaint();
    }
    protected void paintComponent(Graphics g) {
      super.paintComponent(g);

      if (token == 'X') {
        g.drawLine(10, 10, getWidth() - 10, getHeight() - 10);
        g.drawLine(getWidth() - 10, 10, 10, getHeight() - 10);
      }
      else if (token == 'O') {
        g.drawOval(10, 10, getWidth() - 20, getHeight() - 20);
      }
    }
    public void mouseClicked(MouseEvent e) {
      if ((token == ' ') && myTurn) {
        setToken(myToken); 
        myTurn = false;
        rowSelected = row;
        columnSelected = column;
        JStatus.setText("等待另一位玩家移動");
        waiting = false; 
      }
    }
    public void mousePressed(MouseEvent e) {
      // 實作 java.awt.event.MouseListener 方法;
    }
    public void mouseReleased(MouseEvent e) {
    }
    public void mouseEntered(MouseEvent e) {
    }
    public void mouseExited(MouseEvent e) {
    }
  }
  public static void main(String[] args) {
    JFrame frame = new JFrame("圈叉遊戲使用者端");
    GameClient applet = new GameClient();
    applet.isStandAlone = true;
    if (args.length == 1) applet.host = args[0];
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(300, 300);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
}


