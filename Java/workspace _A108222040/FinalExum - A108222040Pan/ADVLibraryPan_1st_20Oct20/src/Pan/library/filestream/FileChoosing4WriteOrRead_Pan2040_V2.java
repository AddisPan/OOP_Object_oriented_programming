package Pan.library.filestream;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.OutputStreamWriter;
import java.util.Formatter;
import java.util.Scanner;

import javax.swing.JFileChooser;
import javax.swing.JOptionPane;

import Pan.library.enummenu.FileStramType_MenuOption_Pan2040;

public class FileChoosing4WriteOrRead_Pan2040_V2 extends FileChoosing4WriteOrRead_27Oct20_Pan2040 {
	boolean isDEBUG_ON = false;

	// Binary-Based File using Object
//	public ObjectInputStream inputO;
//	public ObjectOutputStream outputO;

	// File using text base
	public Scanner inputT; // input text from a file
	public Formatter outputT; // output text to a file

	// Character-Based File
	public BufferedReader br_Reader = null;
	public BufferedWriter br_Writer = null;

//	public String filePath = "./filePath";
//	public boolean isOPEN_FILE_OK = false;
//	public boolean isCANCEL_OPTION = false;
//	public boolean isDirectory = false;
//	public static boolean writeOn = false;
//	public static boolean readOn = false;
//	File fileName = null;
//	public int result;

	private int Stream_Based = FileStramType_MenuOption_Pan2040.BYTE_BASED.getValue();

	public FileChoosing4WriteOrRead_Pan2040_V2(boolean _writeOn, boolean _readOn, int _streamBased) {
		super(_writeOn, _readOn);
		Stream_Based = _streamBased;
	}

	public FileChoosing4WriteOrRead_Pan2040_V2(boolean _writeOn, boolean _readOn, int _streamBased, String _filePath) {
		super(_writeOn, _readOn);
		Stream_Based = _streamBased;

		filePath = _filePath;
		File d = new File(filePath);

		// Create directory now.
		d.mkdirs();
	}// allow user to specify file name

//	public File chooseFile(String _filePath) {//, String titleOnDialogBox
//		
//		isOPEN_FILE_OK = false;
//		
//		// display file dialog, so user can choose file to open
//		JFileChooser fileChooser = new JFileChooser(_filePath);
////		fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
//		fileChooser.setFileSelectionMode(JFileChooser.FILES_AND_DIRECTORIES);
//
////		fileChooser.setDialogTitle(titleOnDialogBox);
//		result = fileChooser.showSaveDialog(this);
//		File fileName = null;
//		// if user clicked Cancel button on dialog, return
//		if (result == JFileChooser.CANCEL_OPTION) {
//			JOptionPane.showMessageDialog(this, "You just clicked on cancel _option", "cancel _optione",JOptionPane.INFORMATION_MESSAGE);
//			isCANCEL_OPTION = true;
//			fileName = null;
//			return null;
//		}
//
//		fileName = isDirectory == true ? fileChooser.getCurrentDirectory()
//				: fileChooser.getSelectedFile().getAbsoluteFile();// get all files in the selected directory
//		
//		JOptionPane.showMessageDialog(this, "file name" + fileName.getName());
//		isOPEN_FILE_OK = true;
//		return fileName;
//	} // end method chooseFile

	/*
	 * enable user to select file to open _filePath titleOnDialogBox reminder
	 */
	public void chooseOpenFile2ReadOrWrite(String _filePath, String titleOnDialogBox, String reminder) {
		isOPEN_FILE_OK = false;

		// Create directory now to make sure it will be created if not existed
		File d = new File(filePath);
		d.mkdirs();

		// display file dialog so user can select file to open
		JFileChooser fileChooser = new JFileChooser(_filePath);
		fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
		fileChooser.setDialogTitle(titleOnDialogBox);
		int result = fileChooser.showOpenDialog(this);

		// if user clicked Cancel button on dialog, return
		if (result == JFileChooser.CANCEL_OPTION) {
			JOptionPane.showMessageDialog(this, "You just clicked on cancel _option", "cancel _optione",
					JOptionPane.INFORMATION_MESSAGE);
			isCANCEL_OPTION = true;
			fileName = null;
			return;
		}

		// obtain selected file
		fileName = fileChooser.getSelectedFile();

		// display error if file name invalid
		if (fileName == null || fileName.getName().equals(""))
			JOptionPane.showMessageDialog(this, "Invalid File Name", "Invalid File Name", JOptionPane.ERROR_MESSAGE);

		else {

			// open file
			try {
				if (writeOn)
					if (Stream_Based == FileStramType_MenuOption_Pan2040.BYTE_BASED.getValue())
						outputO = new ObjectOutputStream(new FileOutputStream(fileName));
					else if (Stream_Based == FileStramType_MenuOption_Pan2040.STANDARD_BASED.getValue())
						outputT = new Formatter(fileName.getAbsoluteFile());// open the file
					else {
						br_Writer = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(fileName)));
					}

				if (readOn)
					if (Stream_Based == FileStramType_MenuOption_Pan2040.BYTE_BASED.getValue())
						inputO = new ObjectInputStream(new FileInputStream(fileName));
					else if (Stream_Based == FileStramType_MenuOption_Pan2040.STANDARD_BASED.getValue())
						inputT = new Scanner(fileName.getAbsoluteFile());
					else
						br_Reader = new BufferedReader(new InputStreamReader(new FileInputStream(fileName)));
				if (isDEBUG_ON)
					JOptionPane.showMessageDialog(this, "Open file:" + fileName, reminder,
							JOptionPane.INFORMATION_MESSAGE);
				isOPEN_FILE_OK = true;
			}

			// process exceptions opening file
			catch (IOException ioException) {
				JOptionPane.showMessageDialog(this, "Error Opening File", "Error", JOptionPane.ERROR_MESSAGE);
			}

		} // end else

	} // end method chooseOpenFile2ReadOrWrite

	public void OpenFile2Write(String reminder) {
		isOPEN_FILE_OK = false;

		// display error if file name invalid
		if (fileName == null || fileName.getName().equals("")) // OK
		{
			JOptionPane.showMessageDialog(this, "Invalid File Name", "Invalid File Name", JOptionPane.ERROR_MESSAGE);
		} else {
			// open file
			try {
				if (Stream_Based == FileStramType_MenuOption_Pan2040.BYTE_BASED.getValue())
					outputO = new ObjectOutputStream(new FileOutputStream(fileName));
				else if (Stream_Based == FileStramType_MenuOption_Pan2040.STANDARD_BASED.getValue())
					outputT = new Formatter(fileName.getAbsoluteFile());// open the file
				else {
					br_Writer = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(fileName)));
				}

				if (isDEBUG_ON)
					JOptionPane.showMessageDialog(this, "Open file:" + fileName, reminder,
							JOptionPane.INFORMATION_MESSAGE);
				isOPEN_FILE_OK = true;
			} // process exceptions opening file
			catch (IOException ioException) {
				JOptionPane.showMessageDialog(this, "Error Opening File", "Error", JOptionPane.ERROR_MESSAGE);
			} // end try-catch
		} // end else
	}// end OpenFile2Write

	public void OpenFile2Read(String reminder) {
		isOPEN_FILE_OK = false;

		// display error if file name invalid
		if (fileName == null || fileName.getName().equals("")) // OK
		{
			JOptionPane.showMessageDialog(this, "Invalid File Name", "Invalid File Name", JOptionPane.ERROR_MESSAGE);
		} else {
			// open file
			try {
				if (Stream_Based == FileStramType_MenuOption_Pan2040.BYTE_BASED.getValue())
					inputO = new ObjectInputStream(new FileInputStream(fileName));
				else if (Stream_Based == FileStramType_MenuOption_Pan2040.STANDARD_BASED.getValue())
					inputT = new Scanner(fileName.getAbsoluteFile());
				else
					br_Reader = new BufferedReader(new InputStreamReader(new FileInputStream(fileName)));

				if (isDEBUG_ON)
					JOptionPane.showMessageDialog(this, "Open file:" + fileName, reminder,
							JOptionPane.INFORMATION_MESSAGE);
				isOPEN_FILE_OK = true;
			} // process exceptions opening file
			catch (IOException ioException) {
				JOptionPane.showMessageDialog(this, "Error Opening File", "Error", JOptionPane.ERROR_MESSAGE);
			} // end try-catch
		} // end else
	}// end OpenFile2Read

	@Override
	public void closeFile() {
		if ((outputO != null || inputO != null) || outputT != null || inputT != null
				|| (br_Writer != null || br_Reader != null)) {
			// close file
			try {
				if (writeOn) {
					if (Stream_Based == FileStramType_MenuOption_Pan2040.BYTE_BASED.getValue())
						outputO.close();
					else if (Stream_Based == FileStramType_MenuOption_Pan2040.CHARACTER_BASED.getValue())
						br_Writer.close();
					else
						outputT.close();
				}
				
				if (readOn)  {
					if (Stream_Based == FileStramType_MenuOption_Pan2040.BYTE_BASED.getValue())
						inputO.close();
					else if (Stream_Based == FileStramType_MenuOption_Pan2040.CHARACTER_BASED.getValue())
						br_Reader.close();
					else
						inputT.close();
				}
			}
			
			// process exceptions from closing file
			catch (IOException ioException) {
				JOptionPane.showMessageDialog(this, "Error closing file", "Error", JOptionPane.ERROR_MESSAGE);
//				System.exit(1);
			}
		} else {
			JOptionPane.showMessageDialog(this, "no file open", "Window Close", JOptionPane.INFORMATION_MESSAGE);
		}
	} // end method closeFile
}//end class FileChoosing4WriteOrRead_Pan2040_V2
