package Pan.polymorphism.employee.btncontroller;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.NoSuchElementException;

import javax.swing.JButton;
import javax.swing.JOptionPane;

import org.omg.CORBA.PRIVATE_MEMBER;

import Pan.library.enummenu.Btns4UniversalProcess_MenuOp_Image_Pan2040;
import Pan.polymorphism.employee.earningbook.EmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.frame.EmployeeBaseJFrame_Pan2040_V4;
import Pan.polymorphism.employee.helper.Helper4SuperEmployeeBase_Pan2040;
//import Yang.library.enummenu.Btns4UniversalProcess_MenuOp;
//import Yang.polymorphism.emploee.frame.EmpolyBaseJFrame_Yang2016;
//import Yang.polymorphism.employee.earningbook.EmployeeBaseBook;
//import Yang.polymorphism.employee.helper.Helper4SuperEmployeeBase;
//import sun.security.provider.JavaKeyStore.CaseExactJKS;

public class BtnController4SuperEmployeeBase {
	EmployeeBaseJFrame_Pan2040_V4 frameEmpolyee;
	Helper4SuperEmployeeBase_Pan2040 helper;
	public EmployeeBaseBook_Pan2040 employeeBook;//employeeBaseBook
	
	public boolean checkBasicProfile = false;
	
	public JButton[] optioButtons;
	Btns4UniversalProcess_MenuOp_Image_Pan2040[] btnChoicesEnums;
	
	public File fileWriteFile = null, fileRead = null;
	private String filePathString = "./filePath";
	
	public  BtnController4SuperEmployeeBase(EmployeeBaseJFrame_Pan2040_V4 _frameEmployee) 
	{
		frameEmpolyee=_frameEmployee;
		
		optioButtons = frameEmpolyee.optionButtons;
		btnChoicesEnums = frameEmpolyee.basicChoices;
		helper = EmployeeBaseJFrame_Pan2040_V4.helper4Employee;
		employeeBook = frameEmpolyee.employeeBook;
	}
	
	public void addActionListenerOnButtons() 
	{
		for (int task = 0; task < optioButtons.length; ++task) {
			optioButtons[task].addActionListener(new ButtonHandlerBySwitch());
		}
	}
	
	private class ButtonHandlerBySwitch implements ActionListener {
		private String taskChoiceType_S;
		private Btns4UniversalProcess_MenuOp_Image_Pan2040 btnChoice;

		public void actionPerformed(ActionEvent event) {
			taskChoiceType_S = event.getActionCommand();
//			JOptionPane.showMessageDialog(null, taskChoiceType_S);
			
			for (int i = 0; i < optioButtons.length; i++) {
				if (btnChoicesEnums[i].getButtonType() == taskChoiceType_S) {
//					JOptionPane.showMessageDialog(null,btnChoicesEnums[i].getButtonType());
					btnChoice = btnChoicesEnums[i];
					break;
				}
			}

			try {
				switchChoices(btnChoice);
			} catch (FileNotFoundException e) {
				e.printStackTrace();
//				JOptionPane.showMessageDialog(null, e.getMessage());
			}
		} // end actionPerformed
	}// end class BHBS
	
	

	public void switchChoices(Btns4UniversalProcess_MenuOp_Image_Pan2040 choiceEnum) throws FileNotFoundException
	{
		switch(choiceEnum){
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
				openFile();
				break;
			case ReadFile:
				readFile();
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
	

	
	public void setProfile() 
	{
		frameEmpolyee.btnOpenFile.setEnabled(true);
		frameEmpolyee.btnCalculate.setEnabled(false);
		employeeBook = frameEmpolyee.setBasics2StartBookingEmployee();
	}
	
	public void clickBtnToSetProfile() 
	{
		if (helper.isReadFile) {
			JOptionPane.showMessageDialog(null, "Please re-input data.", "GUI needs to be Refleshed !",
					JOptionPane.INFORMATION_MESSAGE);
			refreshJFrame();
		}else {
			helper.prepareBasicProfileUsingCheck();
			checkBasicProfile = helper.checkProfile;
			
			JOptionPane.showMessageDialog(null, "checkBasicProfile=" + helper.checkProfile);
			
			if (checkBasicProfile) {
				helper.enableProfileTextBoxs(false);
				setProfile();
				JOptionPane.showMessageDialog(null, "StartInputting Record", "Basic-Profie OK!"
						,JOptionPane.INFORMATION_MESSAGE);
			}
		}
	}
	
	public void clickBtnToCalculateProcessAll() 
	{
		
	}
	
	public void refreshJFrame() 
	{
		helper.refreshJFrame();
	}
	
	public void outputFinalReport() 
	{
		helper.outputFinalReport();
	}
	
	public void clearRecordTextFields() 
	{
		helper.clearRecordTextFields();
	}
	
	public void clearProfileAndResults() 
	{
		helper.clearProfileAndResults();
	}
	
	public void openFile() 
	{
		try {
			helper.openFile(filePathString);
		} catch (FileNotFoundException e) {
			JOptionPane.showMessageDialog(null, e.getMessage(), "FileNotFoundException",
					JOptionPane.INFORMATION_MESSAGE);
		}catch (NullPointerException e) {
			e.printStackTrace();
			
			JOptionPane.showMessageDialog(null, e.getMessage(), "NullPointerException",
					JOptionPane.INFORMATION_MESSAGE);
		}catch (IOException e) {
			e.printStackTrace();
			
			JOptionPane.showMessageDialog(null, "		The Basic Profile\ndid not saved as needed!","No profile Saved",
					JOptionPane.ERROR_MESSAGE);
		}
	}
	
	public void readFile() 
	{
		try {
			if (helper.isCreateFile || helper.isReadFile) {
				refreshJFrame();
				helper.isCreateFile = false;
			}else {
				helper.readFile();
			}
		} catch (/* FileNotFoundException| */ClassNotFoundException | IOException | NoSuchElementException
				| NullPointerException /*| NumberFormatException*/ | ClassCastException | IllegalArgumentException
				| ArrayIndexOutOfBoundsException e) {
			JOptionPane.showMessageDialog(null, e.getMessage()+ "\n"
					+ e.toString()+ "\n"
					+ "\n					ClassNotFoundException"
					+ "\n							IOException"
					+ "\n					NoSuchElementExcption"
					+ "\n					IllegalArgumentException"
					+ "\n					  NullPointerException"
					+ "\n						ClassCastException"
					+ "\n				ArrayIndexOutOfBoundsException",
					"Maybe Re-Open Another File to Read?", JOptionPane.INFORMATION_MESSAGE);
		}
	}
	
	public void showPieChartOfWageDistribution() 
	{
		
	}
	
	public void exitAppInQuestion() 
	{
		helper.exitAppinQuestion();
	}
}
