package Pan.library.filestream;

import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

import Pan.library.components.listDialog.ListDialog_Pan2040;
import Pan.library.enummenu.FileStramType_MenuOption_Pan2040;

public class Choice4FileStreamType_Pan2040{

	final static String[] filestreamTypes = { FileStramType_MenuOption_Pan2040.BYTE_BASED.getOptionType(),
			FileStramType_MenuOption_Pan2040.STANDARD_BASED.getOptionType(), FileStramType_MenuOption_Pan2040.EXIT.getOptionType() };
	//enum -> array
	public static boolean isSucess = false;
	
	static public FileStramType_MenuOption_Pan2040 decideWhichFileStreamType_JList(ImageIcon icon) {
		String choice = ListDialog_Pan2040.showDialog(null, null, "Menu of FILE STREAMS-TYPE",
				"Chooser for File-Stream Type", filestreamTypes, filestreamTypes[0], "CHARACTER_BASED", icon);	
		if (choice == FileStramType_MenuOption_Pan2040.BYTE_BASED.getOptionType())
			return FileStramType_MenuOption_Pan2040.BYTE_BASED;
		else if (choice == FileStramType_MenuOption_Pan2040.STANDARD_BASED.getOptionType())
			return FileStramType_MenuOption_Pan2040.STANDARD_BASED;
		if (choice == FileStramType_MenuOption_Pan2040.EXIT.getOptionType())
			System.exit(1);
		return null;
	}// end FileStramType_MenuOption_Pan2040 decideWhichFileStreamType_JList
	
	static public FileStramType_MenuOption_Pan2040 decideWhichFileStreamType(ImageIcon icon, boolean isJOptionPaneUsed) {
		String choice = null;
		
		if (isJOptionPaneUsed)
			choice = (String) JOptionPane.showInputDialog(null, "what is you choice:", "choce for filestream-type",
					JOptionPane.QUESTION_MESSAGE, icon, filestreamTypes, filestreamTypes[0]);
		else
			choice = ListDialog_Pan2040.showDialog(null, null, "MENU of FILE STREAMS-TYPE: ",
					"Chooser for File-Stream Type", filestreamTypes, filestreamTypes[0], "CHARACTER_BASED", icon);
		
		if (choice == FileStramType_MenuOption_Pan2040.BYTE_BASED.getOptionType())
			return FileStramType_MenuOption_Pan2040.BYTE_BASED;
		else if (choice == FileStramType_MenuOption_Pan2040.STANDARD_BASED.getOptionType())
			return FileStramType_MenuOption_Pan2040.STANDARD_BASED;
		if (choice == FileStramType_MenuOption_Pan2040.EXIT.getOptionType())
			System.exit(1);
		
		return null;
	}// end FileStramType_MenuOption_Pan2040 decideWhichFileStreamType
	
	static public FileStramType_MenuOption_Pan2040 runFileStreamTypeChooser(ImageIcon icon, boolean isJOptionPaneUsed) {
		FileStramType_MenuOption_Pan2040 streamType_MenuOption;
		streamType_MenuOption = Choice4FileStreamType_Pan2040.decideWhichFileStreamType(icon, isJOptionPaneUsed);
		
		if (streamType_MenuOption != null) {
			isSucess = true;
			return streamType_MenuOption;
		} else {
			JOptionPane.showMessageDialog(null, "you just cancel the action!");
			isSucess = false;
			return null;
		}
	}// end FileStramType_MenuOption_Pan2040 runFileStreamTypeChooser
}
