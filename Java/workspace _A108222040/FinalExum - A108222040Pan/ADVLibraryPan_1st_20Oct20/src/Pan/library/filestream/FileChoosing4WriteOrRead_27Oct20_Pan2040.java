package Pan.library.filestream;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.JFrame;

public class FileChoosing4WriteOrRead_27Oct20_Pan2040 extends JFrame {

	public ObjectInputStream inputO;
	public ObjectOutputStream outputO;
	public String filePath = "./filePath";
	public boolean isOPEN_FILE_OK = false;
	public boolean isCANCEL_OPTION = false;
	public boolean isDirectory = false;
	public boolean writeOn = false, readOn = false;
	File fileName = null;
	public int result = JFileChooser.APPROVE_OPTION; //i.e.0

	public FileChoosing4WriteOrRead_27Oct20_Pan2040(boolean _writeOn, boolean _readOn) {
		writeOn = _writeOn;
		readOn = _readOn;
	}

	public FileChoosing4WriteOrRead_27Oct20_Pan2040(boolean _isDirectory) {
		isDirectory = _isDirectory;
	}

	public File chooseFile(String _filePath, String titleOnDialogBox) {
		isOPEN_FILE_OK = false;
		
		// display file dialog, so user can choose file to open
		JFileChooser fileChooser = new JFileChooser(_filePath);
		fileChooser.setFileSelectionMode(JFileChooser.FILES_AND_DIRECTORIES);
		fileChooser.setDialogTitle(titleOnDialogBox);
		result = fileChooser.showSaveDialog(this);

		// if user clicked Cancel button on dialog, return
		if (result == JFileChooser.CANCEL_OPTION) {
			JOptionPane.showMessageDialog(this, "You just clicked on cancel _option", "cancel _optione",
					JOptionPane.INFORMATION_MESSAGE);
			isCANCEL_OPTION = true;
			fileName = null;
			return null;
		}

		if (isDirectory)
			fileName = fileChooser.getCurrentDirectory();// get all files in the selected directory

		else 
			fileName = fileChooser.getSelectedFile().getAbsoluteFile(); // get selected file

		JOptionPane.showMessageDialog(this, "file name" + fileName.getName());
		isOPEN_FILE_OK = true;
		return fileName;
	} // end method chooseFile

	public void chooseOpenFile2ReadOrWrite(String _filePath, String titleOnDialogBox) {
		isOPEN_FILE_OK = false;
		
		//Create directory now to make sure it will be created if not existed.
		File d = new File(_filePath);
		d.mkdirs();
		
		// display file dialog so user can select file to open
		JFileChooser fileChooser = new JFileChooser(_filePath);
		fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);

		fileChooser.setDialogTitle(titleOnDialogBox);
		result = fileChooser.showOpenDialog(this);

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
					outputO = new ObjectOutputStream(new FileOutputStream(fileName));

				if (readOn)
					inputO = new ObjectInputStream(new FileInputStream(fileName));

				isOPEN_FILE_OK = true;
			}

			// process exceptions opening file
			catch (IOException ioException) {
				JOptionPane.showMessageDialog(this, "Error Opening File", "Error", JOptionPane.ERROR_MESSAGE);
			}

		} // end else

	} // end method chooseOpenFile2ReadOrWrite

	public void closeFile() {
		if (outputO != null || inputO != null) {
			// close file
			try {
				if (writeOn)
					outputO.close();
				if (readOn)
					inputO.close();
			}

			// process exceptions from closing file
			catch (IOException ioException) {
				JOptionPane.showMessageDialog(this, "Error closing file", "Error", JOptionPane.ERROR_MESSAGE);
				System.exit(1);
			}
		} else {
			JOptionPane.showMessageDialog(this, "no file open", "Window Close", JOptionPane.INFORMATION_MESSAGE);
		}
	} // end method closeFile
}//end class FileChoosing
