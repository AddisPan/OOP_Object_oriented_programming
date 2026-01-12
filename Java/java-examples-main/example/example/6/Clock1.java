import javax.swing.*;
import java.awt.*;
import java.util.*;
import java.text.*;

public class Clock1 extends JApplet implements Runnable{
	private final static int TEXT_SIZE=58;
	private final static int DELAY=2000;
	private Container contentPane;
	private JTextField text;
	private Thread timer;
	public void init(){
		contentPane =getContentPane();
		text=new JTextField(TEXT_SIZE);
		contentPane.add(text);
	}
	public void start(){
		timer=new Thread(this);
		timer.start();	
	}
	public void stop(){
		timer=null;
	}	
	public void run(){
		Date currentTime;
		SimpleDateFormat formatter=new 
		              SimpleDateFormat("yyyy.MM.dd G '®É¶¡' hh:mm:ss ");
		while(true){
			currentTime=new Date();
			text.setText(formatter.format(currentTime));
			try{
				Thread.currentThread().sleep(DELAY);
			}catch(InterruptedException e){
			}			
		}
	}
}