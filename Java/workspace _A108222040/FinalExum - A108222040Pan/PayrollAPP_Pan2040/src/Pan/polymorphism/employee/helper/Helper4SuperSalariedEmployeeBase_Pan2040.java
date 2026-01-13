package Pan.polymorphism.employee.helper;

import java.io.IOException;
import java.util.ArrayList;
import java.util.NoSuchElementException;

import javax.swing.JOptionPane;

import com.sun.corba.se.spi.activation._ActivatorImplBase;

import Pan.library.enummenu.FileStramType_MenuOption_Pan2040;
import Pan.library.enummenu.NumberType_MenuOption_Pan2040;
import Pan.library.filestream.OpenFileRecord_Pan2040;
import Pan.polymorphism.employee.CommissionEmployee;
import Pan.polymorphism.employee.SalariedEmployee;
import Pan.polymorphism.employee.frame.CommissionEmployeeJFrame_Pan2040_V7;
import Pan.polymorphism.employee.frame.EmployeeBaseJFrame_Pan2040_V4;
import Pan.polymorphism.employee.frame.SalariedEmployeeJFrame_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeRecordIndices_Pan2040;
public class Helper4SuperSalariedEmployeeBase_Pan2040 extends Helper4SuperEmployeeBase_Pan2040 {
	EmployeeBaseJFrame_Pan2040_V4 frameEmployee;

	public Helper4SuperSalariedEmployeeBase_Pan2040(SalariedEmployeeJFrame_Pan2040 component) {
		super(component);
		frameEmployee = (SalariedEmployeeJFrame_Pan2040) component;
	}


	@Override
	public void checkInputRecordData() {
		super.checkInputRecordData();
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkNumberValueByComparing_1flag(
					((SalariedEmployeeJFrame_Pan2040) frameEmployee).txtFieldweekSalary.getText(),
					EmployeeRecordIndices_Pan2040.WEEKLY_SALARY.getRecordIndexType(), 0, 1,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((SalariedEmployeeJFrame_Pan2040) frameEmployee).txtFieldweekSalary.setText("");
		}
		if (checkRecord) {
			_SSN = frameEmployee.txtFieldSSN.getText();
			_firstName = frameEmployee.txtFieldFN.getText();
			_lastName = frameEmployee.txtFieldLN.getText();
			_weekSalary = Double
					.parseDouble(((SalariedEmployeeJFrame_Pan2040) frameEmployee).txtFieldweekSalary.getText());
			}
	}// end checkInputRecordData

	@Override
	public void getInputDataReady(boolean _checkRecord)
	{
		super.getInputDataReady(_checkRecord);
		if (_checkRecord)
		{
			_weekSalary = Double
					.parseDouble(((SalariedEmployeeJFrame_Pan2040) frameEmployee).txtFieldweekSalary.getText());
		}
	}//end getInputDataReady
	
	@Override
	public void processAndShowWageRecordUsingCheck() {
		if (employeeCounter < EmployeeNo) {
			checkInputRecordData();
			if (checkRecord) {
				SalariedEmployee record = new SalariedEmployee(_firstName, _lastName, _SSN,
						frameEmployee.isSimpleFormat, _weekSalary);
				addNprocessEveryNewRecord(record);
			} // emd inner if
		} // end outer if
	}// end processAndShowWageRecordUsingCheck()

	@Override
	public Object[][] returnObjectArray() {
		Object[][] data = new Object[eList_Salaried.size()][frameEmployee.listTitleName4Table.size()];

		for (int i = 0; i < eList_Salaried.size(); i++) {
			Object[] object = { eList_Salaried.get(i).getSocialSecurityNumber(),
					eList_Salaried.get(i).getFirstName(), eList_Salaried.get(i).getLastName(),
					eList_Salaried.get(i).getWeeklySalary(), eList_Salaried.get(i).getLevel(),
					eList_Salaried.get(i).getColor() };

			data[i] = object;
		}
		return data;
	}// end Object[][] returnObjectArray()

	@Override
	public void readFile() throws NumberFormatException ,ClassNotFoundException, NoSuchElementException, 
			NullPointerException, ClassCastException,  IOException {
		super.readFile();
		
		SalariedEmployee record = null;

		if (isFileChoosenOK) {
			eList_Salaried = new ArrayList<SalariedEmployee>();
			
			if (streamType_MenuOption == FileStramType_MenuOption_Pan2040.STANDARD_BASED) {
				while (inputT.hasNext()) { //while there is more to read
					inputT.next();
					record = new SalariedEmployee(inputT.next(), inputT.next(), inputT.next(), true, 
							inputT.nextDouble());
					inputT.nextDouble();
					System.out.println("record=" + record);
					
					addNprocessEveryNewRecord(record);
				}//end while
			} else {//FileStramType_MenuOption_Pan2040.BYTE_BASED
				for (int i = 0; i < EmployeeNo; i++) {
					record = (SalariedEmployee) inputO.readObject();
					record = new SalariedEmployee(record.getFirstName(), record.getLastName(),
							record.getSocialSecurityNumber(), frameEmployee.isSimpleFormat, record.getWeeklySalary());
					addNprocessEveryNewRecord(record);
					}//end for
			 	}//end else
			}//end outer if
		
		FileChoosing4WriteOrRead.closeFile();
	}// end readFile()
	
	@Override
	public void refreshJFrame() 
	{
		if (frameEmployee != null) {
			frameEmployee.dispose();
			
			frameEmployee = frameEmployee.refreshJFrame();
		} else 
			JOptionPane.showMessageDialog(null, "You haven't started anything yet!", "Start Input data first",
					JOptionPane.INFORMATION_MESSAGE);
	}// end refreshJFrame
}//end class Helpersalaried
