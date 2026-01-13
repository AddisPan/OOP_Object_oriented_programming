package Pan.polymorphism.employee.btncontroller;

import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.NoSuchElementException;

import javax.swing.JButton;
import javax.swing.JDesktopPane;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

import com.sun.corba.se.spi.activation._ActivatorImplBase;

import Pan.library.enummenu.Btns4UniversalProcess_MenuOp_Image_Pan2040;
import Pan.polymorphism.employee.earningbook.EmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.frame.EmployeeBaseJFrame_Pan2040_V4;
import Pan.polymorphism.employee.helper.Helper4SuperEmployeeBase_Pan2040;
import jdk.nashorn.api.scripting.AbstractJSObject;

public class BtnController4SuperEmployeeBase_Pan2040 {

	EmployeeBaseJFrame_Pan2040_V4 frameEmployee;
	Helper4SuperEmployeeBase_Pan2040 helper;

	public boolean checkBasicProfile = false; // file is null or number

	public JButton[] optionButtons; // button
	Btns4UniversalProcess_MenuOp_Image_Pan2040[] btnChoicesEnums; // button text

	public File fileWrite = null, fileRead = null; // write file or read file
	private String filePath = "./filePath"; // file in folder(name filePath)

	public static BtnController4SuperEmployeeBase_Pan2040 btnController;
	public static Helper4SuperEmployeeBase_Pan2040 helperEmployee;
	private static String employeeType;
	public EmployeeBaseBook_Pan2040 employeeBook;
	
	JDesktopPane theDesktop;

	public BtnController4SuperEmployeeBase_Pan2040(EmployeeBaseJFrame_Pan2040_V4 _frameEmployee, JDesktopPane _theDesktop) {
		// constrcter enter
		frameEmployee = _frameEmployee;

		optionButtons = frameEmployee.optionButtons;
		btnChoicesEnums = frameEmployee.basicChoices;
		helper = EmployeeBaseJFrame_Pan2040_V4.helper4Employee;// no this thing in Frame
		employeeBook = frameEmployee.employeeBook;// same as above
		
		theDesktop = _theDesktop;
	}

	public void addActionListenerOnButtons() {
		for (int task = 0; task < optionButtons.length; ++task) {
			optionButtons[task].addActionListener(new ButtonHandlerBySwitch());
		}
	}

	private class ButtonHandlerBySwitch implements ActionListener {
		private String taskChoiceType_S;
		private Btns4UniversalProcess_MenuOp_Image_Pan2040 btnChoice;

		public void actionPerformed(ActionEvent event) {
			taskChoiceType_S = event.getActionCommand();
			JOptionPane.showMessageDialog(null,taskChoiceType_S);

			for (int i = 0; i < optionButtons.length; i++) {
				if (btnChoicesEnums[i].getButtonType() == taskChoiceType_S) {
					btnChoice = btnChoicesEnums[i];
					break;
				}
			}

			try {
				switchChoices(btnChoice);
			} catch (FileNotFoundException e) {
				e.printStackTrace();
				JOptionPane.showMessageDialog(null,e.getMessage());
			}
		} // end actionPerformed
	}// end class BHBS

	public void switchChoices(Btns4UniversalProcess_MenuOp_Image_Pan2040 choiceEnum) throws FileNotFoundException {
		switch (choiceEnum) { // all enum type
		case Set_Profile:
			clickBtnToSetProfile();
			break;
		case Process_Data:
			clickBtnToCalculateProcessAll();
			break;
		case Refresh:
			refreshJFrame();
			break;
		case Output_Results:
			outputFinalReport();
			break;
		case Clear_Record:
			clearRecordTextFields();
			break;
		case Clear_Profile_and_Results:
			clearProfileAndResults();
			break;
		case OpenFile:
			openfile();
			break;
		case ReadFile:
			readfile();
			JOptionPane.showMessageDialog(null, "123");
			break;
		case PieChartDemo:
			showPieChartOfWageDistribution();
			break;
		case Exit:
			exitAppInQuestion();
		default:
			break;
		}
	}

	public void clickBtnToSetProfile() {
		if (helper.isReadFile) {
			JOptionPane.showMessageDialog(null, "Please re-input data.", "GUI needs to be Refleshed !",
					JOptionPane.INFORMATION_MESSAGE);
			refreshJFrame();
		} else {
			helper.prepareBasicProfileUsingCheck();
			checkBasicProfile = helper.checkProfile;

			JOptionPane.showMessageDialog(null, "checkBasicProfile=" + helper.checkProfile);

			if (checkBasicProfile) {
				helper.enableProfileTextBoxs(false);
				setProfile();
				JOptionPane.showMessageDialog(null, "Start Inputting Record", "Basic-Profile OK!",
						JOptionPane.INFORMATION_MESSAGE);
			}
		}
	}

	public void setProfile() {
		frameEmployee.btnOpenFile.setEnabled(true);
		frameEmployee.btnCalculate.setEnabled(false);
		employeeBook = frameEmployee.setBasics2StartBookingEmployee();
	}

	public void clickBtnToCalculateProcessAll() {
		if (checkBasicProfile) {
			helper.processAndShowWageRecordUsingCheck();
		}
	}

	public void refreshJFrame() {
		helper.refreshJFrame();
	}

	public void outputFinalReport() {
		helper.outputFinalReport();
	}

	public void clearRecordTextFields() {
		helper.clearRecordTextFields();
	}

	public void clearProfileAndResults() {
		helper.clearProfileAndResults();
	}

	public void openfile() throws NullPointerException {
		try {
			helper.openFile(filePath);
		} catch (FileNotFoundException e) {
			JOptionPane.showMessageDialog(null, e.getMessage(), "FileNotFoundException",
					JOptionPane.INFORMATION_MESSAGE);
		} catch (NullPointerException e) {
			e.printStackTrace();

			JOptionPane.showMessageDialog(null, e.getMessage(), "NullPointerException",
					JOptionPane.INFORMATION_MESSAGE);
		} catch (IOException e) {
			JOptionPane.showMessageDialog(null, "     The Basic Profile\ndidn't saved as needed!", "No profile Saved",
					JOptionPane.ERROR_MESSAGE);
		}
	}

	public void readfile() {
		try {
			if (helper.isCreateFile || helper.isReadFile) {
				refreshJFrame();
				helper.isCreateFile = false;
			} else
				helper.readFile();
		} catch (ClassNotFoundException | IOException | NoSuchElementException | NullPointerException
				| ClassCastException | IllegalArgumentException | ArrayIndexOutOfBoundsException e) {
			JOptionPane.showMessageDialog(null, e.getMessage() + "\n" + e.toString() + "\n"
					+ "\n                    ClassNotFoundException" + "\n                           IOException"
					+ "\n                    NoSuchElementException" + "\n                    IllegalArgumentException"
					+ "\n                      NullPointerException" + "\n                       ClassCastException"
					+ "\n                 ArrayIndexOutOfBoundsException", "Maybe Re-Open Another File to Read?",
					JOptionPane.INFORMATION_MESSAGE);
		}
	}// end readFile()

	public void showPieChartOfWageDistribution() {
		helper.RunPieChart3DFX();
	}

	public void exitAppInQuestion() {
		helper.exitAppinQuestion();
	}// end exitAppInQuestion

	public static void main(String[] args) {
		employeeType = "SuperBase Employee Emplyee (by Pan2040)";
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					EmployeeBaseJFrame_Pan2040_V4 frame = new EmployeeBaseJFrame_Pan2040_V4(employeeType);
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
}
