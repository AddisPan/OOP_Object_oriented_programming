import java.io.*;
import java.net.*;
import javax.swing.*;
import java.awt.*;
import java.util.Date;
public class GameServer extends JFrame implements InterfaceConstants {
  public static void main(String[] args) {
    GameServer frame = new GameServer();
  }
  public GameServer() {
    JTextArea GameLog = new JTextArea();
    JScrollPane ScrollPane = new JScrollPane(GameLog);
    getContentPane().add(ScrollPane, BorderLayout.CENTER);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setSize(500, 300);
    setTitle("遊戲伺服器");
    setVisible(true);
    try {
      ServerSocket serverSocket = new ServerSocket(9000);
      GameLog.append(new Date() +":伺服器啟動在ServerSocket連接埠9000\n");
      int sessionNo = 1;
      while (true) {
        GameLog.append(new Date() +
              ": 等待使用者來參加這個session " + sessionNo + '\n');
        Socket player1 = serverSocket.accept();
        GameLog.append(new Date() + ": 使用者1參加這個session " +
          sessionNo + '\n');
        GameLog.append("使用者1的IP位置" +
          player1.getInetAddress().getHostAddress() + '\n');
        new DataOutputStream(
          player1.getOutputStream()).writeInt(PLAYER1);
        Socket player2 = serverSocket.accept();
        GameLog.append(new Date() +
          ": 使用者二參加這個session " + sessionNo + '\n');
        GameLog.append("使用者二的IP位置" +
          player2.getInetAddress().getHostAddress() + '\n');
        new DataOutputStream(
          player2.getOutputStream()).writeInt(PLAYER2);
        GameLog.append(new Date() + ": 從這個session啟動執行緒" +
          sessionNo++ + '\n');
        HandleASession thread = new HandleASession(player1, player2);
        thread.start();
      }
    }
    catch(IOException ex) {
      System.err.println(ex);
    }
  }
}
class HandleASession extends Thread implements InterfaceConstants {
  private Socket player1;
  private Socket player2;
  private char[][] cell =  new char[3][3];
  private DataInputStream fromPlayer1;
  private DataOutputStream toPlayer1;
  private DataInputStream fromPlayer2;
  private DataOutputStream toPlayer2;
  private boolean continueToPlay = true;
  public HandleASession(Socket player1, Socket player2) {
    this.player1 = player1;
    this.player2 = player2;
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
        cell[i][j] = ' ';
  }
  public void run() {
    try {
      DataInputStream fromPlayer1 = new DataInputStream(
        player1.getInputStream());
      DataOutputStream toPlayer1 = new DataOutputStream(
        player1.getOutputStream());
      DataInputStream fromPlayer2 = new DataInputStream(
        player2.getInputStream());
      DataOutputStream toPlayer2 = new DataOutputStream(
        player2.getOutputStream());
      toPlayer1.writeInt(1);
      while (true) {
        int row = fromPlayer1.readInt();
        int column = fromPlayer1.readInt();
        cell[row][column] = 'X';
        if (isWon('X')) {
          toPlayer1.writeInt(PLAYER1_WON);
          toPlayer2.writeInt(PLAYER1_WON);
          sendMove(toPlayer2, row, column);
          break; 
        }else if (isFull()) { 
          toPlayer1.writeInt(EQUAL);
          toPlayer2.writeInt(EQUAL);
          sendMove(toPlayer2, row, column);
          break;
        }else {
          toPlayer2.writeInt(CONTINUE);
          sendMove(toPlayer2, row, column);
       }
        row = fromPlayer2.readInt();
        column = fromPlayer2.readInt();
        cell[row][column] = 'O';
        if (isWon('O')) {
          toPlayer1.writeInt(PLAYER2_WON);
          toPlayer2.writeInt(PLAYER2_WON);
          sendMove(toPlayer1, row, column);
          break;
        }else {
          toPlayer1.writeInt(CONTINUE);
          sendMove(toPlayer1, row, column);
        }
      }
    }
    catch(IOException ex) {
      System.err.println(ex);
    }
  }

  private void sendMove(DataOutputStream out, int row, int column)
      throws IOException {
    out.writeInt(row);
    out.writeInt(column); 
  }
  private boolean isFull() {
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
        if (cell[i][j] == ' ')
          return false; 
    return true;
  }
  private boolean isWon(char token) {
    for (int i = 0; i < 3; i++)
      if ((cell[i][0] == token)
          && (cell[i][1] == token)
          && (cell[i][2] == token)) {
        return true;
      }

    for (int j = 0; j < 3; j++)
      if ((cell[0][j] == token)
          && (cell[1][j] == token)
          && (cell[2][j] == token)) {
        return true;
      }

    if ((cell[0][0] == token)
        && (cell[1][1] == token)
        && (cell[2][2] == token)) {
      return true;
    }
    if ((cell[0][2] == token)
        && (cell[1][1] == token)
        && (cell[2][0] == token)) {
      return true;
    }
    return false;
  }
}
