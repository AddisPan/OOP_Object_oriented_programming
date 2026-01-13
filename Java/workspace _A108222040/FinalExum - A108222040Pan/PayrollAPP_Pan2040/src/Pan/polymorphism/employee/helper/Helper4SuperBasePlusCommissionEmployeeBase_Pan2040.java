package Pan.polymorphism.employee.helper;

import java.io.IOException;
import java.util.ArrayList;
import java.util.NoSuchElementException;

import javax.swing.JOptionPane;

import com.sun.corba.se.spi.activation._ActivatorImplBase;

import Pan.library.enummenu.FileStramType_MenuOption_Pan2040;
import Pan.library.enummenu.NumberType_MenuOption_Pan2040;
import Pan.library.filestream.OpenFileRecord_Pan2040;
import Pan.polymorphism.employee.BasePlusCommissionEmployee;
import Pan.polymorphism.employee.CommissionEmployee;
import Pan.polymorphism.employee.frame.BasePlusCommissionEmployeeJFrame_Pan2040;
import Pan.polymorphism.employee.frame.CommissionEmployeeJFrame_Pan2040_V7;
import Pan.polymorphism.employee.frame.EmployeeBaseJFrame_Pan2040_V4;
import Pan.polymorphism.employee.frame.SalariedEmployeeJFrame_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeRecordIndices_Pan2040;
public class Helper4SuperBasePlusCommissionEmployeeBase_Pan2040 extends Helper4SuperEmployeeBase_Pan2040 {
	EmployeeBaseJFrame_Pan2040_V4 frameEmployee;

	public Helper4SuperBasePlusCommissionEmployeeBase_Pan2040(BasePlusCommissionEmployeeJFrame_Pan2040 component) {
		super(component);
		frameEmployee = (BasePlusCommissionEmployeeJFrame_Pan2040) component;
	}


	@Override
	public void checkInputRecordData() {
		super.checkInputRecordData();
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkNumberValueByComparing_1flag(
					((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldGrossSales.getText(),
					EmployeeRecordIndices_Pan2040.GROSS_SALES.getRecordIndexType(), 0, 1,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldGrossSales.setText("");
		}
		if (checkRecord) {
			checkRecord = validation_GUI.checkNumberValueInRange_min0P1max0N1(
					((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldCommissionRate.getText(),
					EmployeeRecordIndices_Pan2040.Commission_RATE.getRecordIndexType(), 0.0, 1.0,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldCommissionRate.setText("");
		}
		if (checkRecord) {
			checkRecord = validation_GUI.checkNumberValueInRange_min0P1max0N1(
					((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).textFieldBSalary.getText(),
					EmployeeRecordIndices_Pan2040.Base_SALARY.getRecordIndexType(), 0, 100000,
					NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex());
			if (!checkRecord)
				((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).textFieldBSalary.setText("");
		}
		if (checkRecord) {
			_SSN = frameEmployee.txtFieldSSN.getText();
			_firstName = frameEmployee.txtFieldFN.getText();
			_lastName = frameEmployee.txtFieldLN.getText();
			_grossSales = Double
					.parseDouble(((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldGrossSales.getText());
			_commisionRate = Double.parseDouble(
					((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldCommissionRate.getText());
			_baseSalary = Double.parseDouble(
					((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).textFieldBSalary.getText());
			}
	}// end checkInputRecordData

	@Override
	public void getInputDataReady(boolean _checkRecord)
	{
		super.getInputDataReady(_checkRecord);
		if (_checkRecord)
		{
			_grossSales = Double
					.parseDouble(((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldGrossSales.getText());
			_commisionRate = Double.parseDouble(
					((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).txtFieldCommissionRate.getText());
			_baseSalary = Double.parseDouble(
					((BasePlusCommissionEmployeeJFrame_Pan2040) frameEmployee).textFieldBSalary.getText());
		}
	}//end getInputDataReady
	
	@Override
	public void processAndShowWageRecordUsingCheck() {
		if (employeeCounter < EmployeeNo) {
			checkInputRecordData();
			if (checkRecord) {
				BasePlusCommissionEmployee record = new BasePlusCommissionEmployee(_firstName, _lastName, _SSN,
						frameEmployee.isSimpleFormat, _grossSales, _commisionRate, _baseSalary);
				addNprocessEveryNewRecord(record);
			} // emd inner if
		} // end outer if
	}// end processAndShowWageRecordUsingCheck()

	@Override
	public Object[][] returnObjectArray() {
		Object[][] data = new Object[eList_BasePlusCommission.size()][frameEmployee.listTitleName4Table.size()];

		for (int i = 0; i < eList_BasePlusCommission.size(); i++) {
			Object[] object = { eList_BasePlusCommission.get(i).getSocialSecurityNumber(),
					eList_BasePlusCommission.get(i).getFirstName(), eList_BasePlusCommission.get(i).getLastName(),
					eList_BasePlusCommission.get(i).getGrossSales(), eList_BasePlusCommission.get(i).getCommissionRate(),
					eList_BasePlusCommission.get(i).getBaseSalary(), eList_BasePlusCommission.get(i).earnings(), 
					eList_BasePlusCommission.get(i).getLevel(),eList_BasePlusCommission.get(i).getColor() };

			data[i] = object;
		}
		return data;
	}// end Object[][] returnObjectArray()

	@Override
	public void readFile() throws NumberFormatException ,ClassNotFoundException, NoSuchElementException, 
			NullPointerException, ClassCastException,  IOException {
		super.readFile();
		
		BasePlusCommissionEmployee record = null;

		if (isFileChoosenOK) {
			eList_BasePlusCommission = new ArrayList<BasePlusCommissionEmployee>();
			
			if (streamType_MenuOption == FileStramType_MenuOption_Pan2040.STANDARD_BASED) {
				while (inputT.hasNext()) { //while there is more to read
					inputT.next();
					record = new BasePlusCommissionEmployee(inputT.next(), inputT.next(), inputT.next(), true, 
							inputT.nextDouble(), inputT.nextDouble(), inputT.nextDouble());
					inputT.nextDouble();
					System.out.println("record=" + record);
					
					addNprocessEveryNewRecord(record);
				}//end while
			} else {//FileStramType_MenuOption_Pan2040.BYTE_BASED
				for (int i = 0; i < EmployeeNo; i++) {
					record = (BasePlusCommissionEmployee) inputO.readObject();
					record = new BasePlusCommissionEmployee(record.getFirstName(), record.getLastName(),
							record.getSocialSecurityNumber(), frameEmployee.isSimpleFormat, record.getGrossSales(),
							record.getCommissionRate(), record.getBaseSalary());
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
