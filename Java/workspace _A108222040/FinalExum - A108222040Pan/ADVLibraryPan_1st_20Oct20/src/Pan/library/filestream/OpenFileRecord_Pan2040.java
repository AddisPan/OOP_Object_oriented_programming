package Pan.library.filestream;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Formatter;

import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.SwingConstants;
import javax.swing.UIManager;

import com.sun.nio.sctp.AbstractNotificationHandler;

import javax.swing.JFrame;
import javax.swing.JLabel;

@SuppressWarnings ({"unused" , "serial"})
public class OpenFileRecord_Pan2040{
	public static File FileName;
	public static Formatter output;
	
	public final int Text_BASED = 1, BYE_EASED = 2;
	public int stream_Based = Text_BASED;
	public static final int CONSOLE_MODE = 1;
	public static final int GUI_MODE = 2;
	public int Console_or_GUI_Mode = GUI_MODE;
	
	public static boolean useSimpleOne = false;
	public static boolean useJPane = true;
	public String filePath = "./filePath";
	
	public OpenFileRecord_Pan2040(int _Stream_Based, int _Console_or_GUI_Mode, boolean _useJPane) {
		stream_Based = _Stream_Based;
		Console_or_GUI_Mode = _Console_or_GUI_Mode;
		useJPane = _useJPane;
	}//end OpenFileRecord_Pan2040()
	
	public static File getfile(String _filePath, boolean _useJPane) throws FileNotFoundException, NullPointerException {
		useJPane = _useJPane;
		JFileChooser fileChooser = new JFileChooser(_filePath);
		fileChooser.setFileSelectionMode(JFileChooser.FILES_AND_DIRECTORIES);
		int result = fileChooser.showOpenDialog(null);
		
		if (result == JFileChooser.APPROVE_OPTION) {
			FileName = fileChooser.getSelectedFile().getAbsoluteFile();
		} else {//if user clicked Cancel button on dialog, return
			JOptionPane.showMessageDialog(null,
					"You just mode:\r\n         'CANCEL_ or ERROR_ OPTION'!",
					"No file Chosen. Are you sure?", JOptionPane.INFORMATION_MESSAGE);
			
			return null;
		}
		
		return FileName;
	}// end getfile()
	
	public static void openFile(File _Filename) {
		try {
			output = new Formatter(FileName.getAbsoluteFile());
			JOptionPane.showMessageDialog(null, FileName.getName()); //絕對路徑
		} catch (SecurityException securityException) {
			JOptionPane.showMessageDialog(null, "Write permission denied. Terminaating");
			System.exit(1);
		} catch (FileNotFoundException securityException) {
			JOptionPane.showMessageDialog(null, "Error opening file--> FileNotFoundException");
		}
	}//end openFile
	
	public static void closeFile() {
		if (output != null)
			output.close();
		JOptionPane.showMessageDialog(null, "Close File");
	}//end closeFile()
	
	public static boolean readFile2PreviewContent4ContinueOrNot(JTextArea txtArea, String filePath,
			boolean _useSimpleOne) throws FileNotFoundException {
		boolean isFileNeeded = false;
		String[] YorN = {"Yes", "No"};
		JPanel panel = null;
		
		File fileRead = OpenFileRecord_Pan2040.getfile(filePath, _useSimpleOne);
		if (fileRead != null) {
			ReadFileExample_Pan2040 readFile = new ReadFileExample_Pan2040(fileRead);
			JOptionPane.showMessageDialog(null, readFile.stringContent, "Preview Content in File",
					JOptionPane.INFORMATION_MESSAGE);
			
			txtArea.setText(readFile.stringContent);
			
			if (useJPane)
				panel = getUImanager4JOptionPane(_useSimpleOne);
			
			ImageIcon icon = new ImageIcon("");
			String choice = (String) JOptionPane.showInputDialog(null, (panel == null ? "Your choice" : panel),
					"CONTINE? (YES/NO)", JOptionPane.QUESTION_MESSAGE, icon, YorN, YorN[0]);
			
			if (choice == "Yes") {
				isFileNeeded = true;
			} else if (choice == "No") {
				JOptionPane.showMessageDialog(null, "You need to re-choose file!");
			} else {
				JOptionPane.showMessageDialog(null, "You just cancel the action!");
			}	
		} else {
			JOptionPane.showMessageDialog(null, "No file choosen");
		}
		
		return isFileNeeded;
	}//end readFile2PreviewContent4ContinueOrNot
	
	public static JPanel getUImanager4JOptionPane(boolean _useSimpleOne) {
		JPanel panel = null;
		useSimpleOne = _useSimpleOne;
		if (useSimpleOne) {
			UIManager.put("OptionPane.messageForeground", Color.red);
			UIManager.put("Panel.background", new Color(128, 255, 255));
		} else {
			panel = new JPanel();
			panel.setBackground(new Color(0, 0, 0));
			panel.setSize(new Dimension(250, 240));
			panel.setLayout(null);
			
			JLabel label = new JLabel("what is your choice:)");
			label.setForeground(new Color(255, 0, 255));
			label.setHorizontalAlignment(SwingConstants.LEFT);
			label.setFont(new Font("Arial", Font.BOLD, 14));
			label.setBounds(0, 0, 250, 62);
			panel.add(label);
			
			UIManager.put("OptionPane.minimumSize", new Dimension(270, 240));
			
			UIManager.put("OptionPane.background", Color.red);
			UIManager.getLookAndFeelDefaults().put("Panel.background", new Color(255, 255, 255));
		}
		
		return panel;
	} // end JPanel getUImanager4JOptionPane
}//end class OpenFileRecord_Pan2040()
