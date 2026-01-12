import java.awt.*;
import java.util.*;
import java.awt.event.*;
import javax.swing.JApplet;
import javax.swing.JPanel;
import javax.swing.Timer;
public class AppletCanvas extends JApplet implements ActionListener{
	private final static int REC_WIDTH=50;
	private final static int REC_HEIGHT=50;
	private final static int DELAY=100;
	private final static int MAX_MOVE=20;
	private Timer timer;
	private Canvas canvas;
	private Random random;
	private int x,y;
	public void init(){
		Container contentPane=getContentPane();
		canvas=new Canvas();
		contentPane.add(canvas);
		contentPane.validate();
		random=new Random();
		timer=new Timer(DELAY,this);
		x=(canvas.getWidth()-REC_WIDTH)/2;
		y=(canvas.getHeight()-REC_HEIGHT)/2;
		canvas.repaint();
	}
	public void start(){
		timer.start();
	}
	public void stop(){
		timer.stop();
	}
	public void actionPerformed(ActionEvent e){
		if(random.nextBoolean()){
			x=x+random.nextInt(MAX_MOVE);
		}else{
			x=x-random.nextInt(MAX_MOVE);
		}
		if(random.nextBoolean()){
			y=y+random.nextInt(MAX_MOVE);
		}else{
			y=y-random.nextInt(MAX_MOVE);
		}
		canvas.repaint();
	}
	private class Canvas extends JPanel{
		public void paint(Graphics g){
			super.paint(g);
			g.drawRect(x+200,y+200,REC_WIDTH-1,REC_HEIGHT-1);
			g.setColor(Color.YELLOW);
			g.fillRect(x+201,y+201,REC_WIDTH-2,REC_HEIGHT-2);
		}
	}
}