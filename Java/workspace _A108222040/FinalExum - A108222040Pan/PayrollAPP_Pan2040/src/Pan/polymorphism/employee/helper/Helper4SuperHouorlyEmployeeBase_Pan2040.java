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
import Pan.polymorphism.employee.HourlyEmployee;
import Pan.polymorphism.employee.frame.CommissionEmployeeJFrame_Pan2040_V7;
import Pan.polymorphism.employee.frame.EmployeeBaseJFrame_Pan2040_V4;
import Pan.polymorphism.employee.frame.HourlyEmployeeJFrame_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeRecordIndices_Pan2040;
public class Helper4SuperHouorlyEmployeeBase_Pan2040 extends Helper4SuperEmployeeBase_Pan2040 {
	EmployeeBaseJFrame_Pan2040_V4 frameEmployee;

	public Helper4SuperHouorlyEmployeeBase_Pan2040(HourlyEmployeeJFrame_Pan2040 component) {
		super(component);
		frameEmployee = (HourlyEmployeeJFrame_Pan2040) component;
	}


	@Override
	public void checkInputRecordData() {
		super.checkInputRecordData();
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkNumberValueByComparing_1flag(
					((HourlyEmployeeJFrame_Pan2040) frameEmployee).txtFieldHoursWorked.getText(),
					EmployeeRecordIndices_Pan2040.HOURS_WORKED.getRecordIndexType(), 0, 1,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((HourlyEmployeeJFrame_Pan2040) frameEmployee).txtFieldHoursWorked.setText("");
		}
		
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkNumberValueByComparing_1flag(
					((HourlyEmployeeJFrame_Pan2040) frameEmployee).txtMaxWorkedhours.getText(),
					EmployeeRecordIndices_Pan2040.MAX_WORKED_HOURS.getRecordIndexType(), 0, 168,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((HourlyEmployeeJFrame_Pan2040) frameEmployee).txtMaxWorkedhours.setText("");
		}
		
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkNumberValueByComparing_1flag(
					((HourlyEmployeeJFrame_Pan2040) frameEmployee).textFieldextrahourRate.getText(),
					EmployeeRecordIndices_Pan2040.EXTRA_HOURS_RATE.getRecordIndexType(), 0, 40,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((HourlyEmployeeJFrame_Pan2040) frameEmployee).textFieldextrahourRate.setText("");
		}
		
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkNumberValueByComparing_1flag(
					((HourlyEmployeeJFrame_Pan2040) frameEmployee).textFieldhourlyWage.getText(),
					EmployeeRecordIndices_Pan2040.HOURLY_WAGE.getRecordIndexType(), 0, 1,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((HourlyEmployeeJFrame_Pan2040) frameEmployee).textFieldhourlyWage.setText("");
		}
	}// end checkInputRecordData

	@Override
	public void getInputDataReady(boolean _checkRecord)
	{
		super.getInputDataReady(_checkRecord);
		if (_checkRecord)
		{
			_hoursWorked = Double
					.parseDouble(((HourlyEmployeeJFrame_Pan2040) frameEmployee).txtFieldHoursWorked.getText());
			_MAX_WORKED_HOURS = Double.parseDouble(
					((HourlyEmployeeJFrame_Pan2040) frameEmployee).txtMaxWorkedhours.getText());
			_rate4ExtraHours = Double.parseDouble(
					((HourlyEmployeeJFrame_Pan2040) frameEmployee).textFieldextrahourRate.getText());
			_hourlywage = Double.parseDouble(
					((HourlyEmployeeJFrame_Pan2040) frameEmployee).textFieldhourlyWage.getText());
		}
	}//end getInputDataReady
	
	@Override
	public void processAndShowWageRecordUsingCheck() {
		if (employeeCounter < EmployeeNo) {
			checkInputRecordData();
			if (checkRecord) {
				HourlyEmployee record = new HourlyEmployee(_firstName, _lastName, _SSN,
						frameEmployee.isSimpleFormat, _hoursWorked, _rate4ExtraHours, _hourlywage);
				addNprocessEveryNewRecord(record);
			} // emd inner if
		} // end outer if
	}// end processAndShowWageRecordUsingCheck()

	@Override
	public Object[][] returnObjectArray() {
		Object[][] data = new Object[eList_Hourly.size()][frameEmployee.listTitleName4Table.size()];

		for (int i = 0; i < eList_Hourly.size(); i++) {
			Object[] object = { eList_Hourly.get(i).getSocialSecurityNumber(),
					eList_Hourly.get(i).getFirstName(), eList_Hourly.get(i).getLastName(),
					eList_Hourly.get(i).getHours(), eList_Hourly.get(i).getextraHourRate(),
					eList_Hourly.get(i).getWage(),
					eList_Hourly.get(i).earnings(), eList_Hourly.get(i).getLevel(),
					eList_Hourly.get(i).getColor() };

			data[i] = object;
		}
		return data;
	}// end Object[][] returnObjectArray()

	@Override
	public void readFile() throws NumberFormatException ,ClassNotFoundException, NoSuchElementException, 
			NullPointerException, ClassCastException,  IOException {
		super.readFile();
		
		HourlyEmployee record = null;

		if (isFileChoosenOK) {
			eList_Hourly = new ArrayList<HourlyEmployee>();
			
			if (streamType_MenuOption == FileStramType_MenuOption_Pan2040.STANDARD_BASED) {
				while (inputT.hasNext()) { //while there is more to read
					inputT.next();
					record = new HourlyEmployee(inputT.next(), inputT.next(), inputT.next(), true, 
							inputT.nextDouble(), inputT.nextDouble(), inputT.nextDouble());
					inputT.nextDouble();
					System.out.println("record=" + record);
					
					addNprocessEveryNewRecord(record);
				}//end while
			} else {//FileStramType_MenuOption_Pan2040.BYTE_BASED
				for (int i = 0; i < EmployeeNo; i++) {
					record = (HourlyEmployee) inputO.readObject();
					record = new HourlyEmployee(record.getFirstName(), record.getLastName(),
							record.getSocialSecurityNumber(), frameEmployee.isSimpleFormat, record.getHours(),
							record.getextraHourRate(), record.getWage());
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
}//end class HelperCommission
