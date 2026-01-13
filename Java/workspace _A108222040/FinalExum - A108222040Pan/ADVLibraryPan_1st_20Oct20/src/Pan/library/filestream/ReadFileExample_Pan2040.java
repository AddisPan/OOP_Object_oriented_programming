package Pan.library.filestream;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

import javax.swing.JFileChooser;
import javax.swing.JOptionPane;

import Pan.library.enummenu.FileStramType_MenuOption_Pan2040;

import javax.swing.JFrame;

public class ReadFileExample_Pan2040 extends JFrame {

	public String stringContent = "";
	public boolean useJPane = true;
	public boolean useSimpleOne = false;
	public static String filePath = "./testData";
	
	public static void main(String[] args) {
//		File file = new File("./testData/test.txt");
//		ReadFileExample_Pan2040 readfile = new ReadFileExample_Pan2040(file);
		try {
			main2(args);
		} catch (FileNotFoundException | NullPointerException e) {
			e.printStackTrace();
		}
	}
	
	public static void main2(String[] args) throws FileNotFoundException, NullPointerException {
		OpenFileRecord_Pan2040 openfile = new OpenFileRecord_Pan2040(FileStramType_MenuOption_Pan2040.STANDARD_BASED.getValue(), OpenFileRecord_Pan2040.GUI_MODE, true);
		File file = OpenFileRecord_Pan2040.getfile(filePath, true);
//		File file = new File("./testData/test.txt");
		ReadFileExample_Pan2040 readfile = new ReadFileExample_Pan2040(file);
	}
	
	public ReadFileExample_Pan2040(File file) throws NullPointerException
	{
		FileInputStream fis = null;
		try {
			fis = new FileInputStream(file);
			
			System.out.println("Total file size to read (in bytes) :"
					+ fis.available());
			
			int content;
			while ((content = fis.read()) != -1) {
				System.out.print((char) content);
				stringContent += (char) content;
			}
			
		} catch (IOException | NullPointerException e) {
			JOptionPane.showMessageDialog(null, e.getMessage(), "Re=choose file.",
					JOptionPane.INFORMATION_MESSAGE);
		} finally {
			try {
				if (fis != null)
					fis.close();
			} catch (IOException ex) {
				JOptionPane.showMessageDialog(null, ex.getMessage(), "Re=choose file.",
						JOptionPane.INFORMATION_MESSAGE);
			}
		}
	}// end ReadFileExample_Pan2040
}
