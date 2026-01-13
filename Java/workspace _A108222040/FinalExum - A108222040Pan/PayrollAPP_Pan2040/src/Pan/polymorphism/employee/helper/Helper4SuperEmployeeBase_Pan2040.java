package Pan.polymorphism.employee.helper;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.nio.file.FileSystemNotFoundException;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Formatter;
import java.util.NoSuchElementException;
import java.util.Scanner;
import java.util.stream.Stream;

import javax.imageio.IIOException;
import javax.swing.ImageIcon;
import javax.swing.JComponent;
import javax.swing.JDesktopPane;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import org.omg.CORBA.FREE_MEM;

import com.sun.javafx.binding.SelectBinding.AsString;

import Pan.library.filestream.Choice4FileStreamType_Pan2040;
import Pan.library.filestream.FileChoosing4WriteOrRead_Pan2040_V2;
import Pan.library.filestream.OpenFileRecord_Pan2040;
import Pan.library.filestream.ReadFileExample_Pan2040;
import Pan.library.checkandvalidation.InputNumberValidation_GUI_CONSOLE_Pan2040;
import Pan.library.components.jtable.TableDialogEditDemoWithLevels_Pan2040;
import Pan.library.enummenu.Btns4UniversalProcess_MenuOp_Image_Pan2040;
import Pan.library.enummenu.FileStramType_MenuOption_Pan2040;
import Pan.library.enummenu.NumberType_MenuOption_Pan2040;
import Pan.library.enummenu.PieChartType_MenuOption_Pan2040;
//import Pan.library.enummenu.usagedemo.Choice4PieChartType_Pan2040;

import Pan.polymorphism.employee.menuoption.*;
import orsoncharts.demo.fx.PieChart3DFXDemo3_Modified_Pan2040;
//mport Pan.swingset2.jtable.TableDemo4PayrollSystem;
import Pan.polymorphism.employee.BasePlusCommissionEmployee;
import Pan.polymorphism.employee.CommissionEmployee;
import Pan.polymorphism.employee.Employee;
import Pan.polymorphism.employee.HourlyEmployee;
import Pan.polymorphism.employee.SalariedEmployee;
import Pan.polymorphism.employee.earningbook.EmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.frame.CommissionEmployeeJFrame_Pan2040_V7;
import Pan.polymorphism.employee.frame.EmployeeBaseJFrame_Pan2040_V4;
//import Pan.polymorphism.employee.interframe.EmployeeBaseJFrame_Pan2040;

//import Pan.library.jfreechart.piechart.*;

public class Helper4SuperEmployeeBase_Pan2040 {
	EmployeeBaseJFrame_Pan2040_V4 frameEmployee;
	
	public int EmployeeNo = 0;
	public String CompanyName = "";
	

	//initialize variables for grade record used in SuperEmployeeBase
	String _SSN = "";
	String _firstName = "";
	String _lastName = "";
	
	public int employeeCounter = 0;
	public static DecimalFormat twoDigits = new DecimalFormat("0.00"); //file 格式 
	
	protected boolean checkON = true;
	protected InputNumberValidation_GUI_CONSOLE_Pan2040 validation_GUI = new InputNumberValidation_GUI_CONSOLE_Pan2040(false,true); //資料的有效性 OK
	protected InputNumberValidation_GUI_CONSOLE_Pan2040 validationNumber_GUI = new InputNumberValidation_GUI_CONSOLE_Pan2040(false,
			true);
	public boolean checkProfile = false; //data is pass or not
	boolean checkRecord = false; //record is pass or not
	
	static EmployeeBaseJFrame_Pan2040_V4 employeeBaseJFrame = null;
	
	public String filePath = "./filePath";
	public FileChoosing4WriteOrRead_Pan2040_V2 FileChoosing4WriteOrRead;
	public ObjectOutputStream outputO;
	public Formatter outputT;
	protected ObjectInputStream inputO;
	protected Scanner inputT;
	public File fileWritten = null;
//	protected PieChart2DMemo0 pieChartDemo;
	
	String companyString;
	String employeeNoString;
	
	public boolean isReadFile = false; //read file
	public boolean isCreateFile = false;
	
	ArrayList<CommissionEmployee> eList_Commission = new ArrayList<CommissionEmployee>();
	ArrayList<BasePlusCommissionEmployee> eList_BasePlusCommission = new ArrayList<BasePlusCommissionEmployee>();
	ArrayList<SalariedEmployee> eList_Salaried = new ArrayList<SalariedEmployee>();
	ArrayList<HourlyEmployee> eList_Hourly = new ArrayList<HourlyEmployee>();

	//Commission Employee
	public double _grossSales = 0;
	public double _commisionRate = 0.0;
	
	//BasePlusCommission Employee
	public double _baseSalary = 0.0;
	
	//Salaried Employee
	public double _weekSalary = 0.0;
	
	//Hourly Employee
	public double _hourlywage = 0.0; // wage per hour
	public double _rate4ExtraHours = 0.0;
	public double _hoursWorked = 0;
	public double _maxHoursPerWeek = 80.0;
	public double _min4rateOfExtraHours = 1.0;
	public double _max4rateOfExtraHours = 2.0;
	public double _MAX_WORKED_HOURS = 168;
	public double _normalHoursWorked = 40.0;
	
//	int PieChart2D_Type1 = 0, PieChart2D_Type2 = 1,PieChart2D_Type3 = 2;
//	int pieChartChoosen = PieChart2D_Type1;
	static EmployeeBaseJFrame_Pan2040_V4 employeebaseJFrame = null;
	
	static FileStramType_MenuOption_Pan2040 streamType_MenuOption = null;
	public boolean isJOptionPaneUsed = false;
	public boolean useSimpleOne = true;
	protected boolean isFileChoosenOK = false;
	
	public boolean useJPane = true;
	public boolean isSimpleOne = true;
	ReadFileExample_Pan2040 readfile;
	
	boolean isTableDialogEditVersion_Oracle = true;

	public Helper4SuperEmployeeBase_Pan2040(EmployeeBaseJFrame_Pan2040_V4 _frmEmployee) 
	{
		frameEmployee = _frmEmployee;
		setUpNewStartUp4Buttons();
		setUpDistribution4WageLevels();
	}
	
//	public Helper4SuperEmployeeBase(Pan.polymorphism.employee.interframe.EmployeeBaseJFrame_Pan2040 employeeBaseJFrame) 
//	{
//		
//	}
	
//	public Helper4SuperEmployeeBase(EmployeeBaseInternalJFrame_Pan2040 employeeBaseInternalJFrame) 
//	{
//		
//	}
	
	public void resetButtons4NewStart(boolean _isEnable) //button open or close(first in)
	{
		for (int i = 0;i < frameEmployee.basicChoices.length;i ++)
		{
			frameEmployee.optionButtons[i].setEnabled(_isEnable);
		}
	}
	
	public void setUpNewStartUp4Buttons() { //open three btns
		resetButtons4NewStart(false);
		frameEmployee.btnSetProfile.setEnabled(true);
		frameEmployee.btnExit.setEnabled(true);
		frameEmployee.btnRefresh.setEnabled(true);
		frameEmployee.btnReadFile.setEnabled(true);
	}

	public void setUpDistribution4WageLevels() {
		frameEmployee.lblALowerThreshold.setText("" + EarningLevelEnum_Pan2040.LevelA.getValue());
		frameEmployee.lblBUpperThreshold.setText("" + EarningLevelEnum_Pan2040.LevelA.getValue());
		frameEmployee.lblBLowerThreshold.setText("" + EarningLevelEnum_Pan2040.LevelB.getValue());
		frameEmployee.lblCUpperThreshold.setText("" + EarningLevelEnum_Pan2040.LevelB.getValue());
		frameEmployee.lblUnit
		        .setText("" + EarningLevelEnum_Pan2040.UNIT.getLevelType() + "(" + EarningLevelEnum_Pan2040.UNIT.getValue() + ")");
	}
	
	public void prepareBasicProfileUsingCheck() //Basic data check
	{
		checkProfile = validationNumber_GUI.checkStringNotEmpty(frameEmployee.txtFieldCN.getText(),
				EmployeeRecordIndices_Pan2040.COMPANY_NAME.getRecordIndexType());
		
		if (checkON)
			JOptionPane.showMessageDialog(null, "employee=" + frameEmployee.getClass());
			
		if (checkProfile) {
			CompanyName = validationNumber_GUI.stringInput;
			checkProfile = validationNumber_GUI.checkNumberValueByComparing_1flag(frameEmployee.txtFieldEN.getText(),
					EmployeeRecordIndices_Pan2040.EMPLOYEE_NO.getRecordIndexType(), 0, 1,
					NumberType_MenuOption_Pan2040.INT_NUMBER_TYPE.getValueIndex());
			
			if (!checkProfile)
				frameEmployee.txtFieldEN.setText("");
			else {
				EmployeeNo = validationNumber_GUI.numberValue.intValue();
				
				frameEmployee.btnOpenFile.setEnabled(true);
			} //else
		}// if
	}// end prepareBasicProfileUsingCheck
	
	public void checkInputRecordData() { 
		checkRecord = false;
		
		checkRecord = validationNumber_GUI.checkStringNotEmpty(frameEmployee.txtFieldSSN.getText(),
				EmployeeRecordIndices_Pan2040.SSN.getRecordIndexType());
		
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkStringNotEmpty(frameEmployee.txtFieldFN.getText(),
					EmployeeRecordIndices_Pan2040.FIRST_NAME.getRecordIndexType());
		}
		
		if (checkRecord) {
			checkRecord = validationNumber_GUI.checkStringNotEmpty(frameEmployee.txtFieldLN.getText(),
					EmployeeRecordIndices_Pan2040.LAST_NAME.getRecordIndexType());
		}
	}// end checkInputRecordData
	
	public void getInputDataReady(boolean _checkRecord)
	{
		if (_checkRecord)
		{
			_SSN = frameEmployee.txtFieldSSN.getText();
			_firstName = frameEmployee.txtFieldFN.getText();
			_lastName = frameEmployee.txtFieldLN.getText();
		}
	}//end getInputDataReady
	
    public void processAndShowWageRecordUsingCheck(){
    	
	}//end processAndShowWageRecordUsingCheck()
	
    /**
     * 1.add every recor to employee-book and further process and complete
     * EverySalary/record Profile
     * 
     * 2.add every record to  report and show processed results
     * 
     * 3.add every record to its corresponding arrayList
     * 
     * 4.go to final phase to  both display whole results and reset all conditions
     * 
     */
	public void addNprocessEveryNewRecord(BasePlusCommissionEmployee record) 
	{
		employeeCounter += 1;
		/**
		 * <p>
		 * 1.add every raw record to employee-book and further process and complete
		 * Every Salary / record Profile
		 */
		frameEmployee.employeeBook.processEverySalaryProfile(record);
		JOptionPane.showMessageDialog(null, "Employee: " + employeeCounter + ":\n" + record.toString2());
		
		writeRecord2ReportFileNdisplayCompleteRecord(record);
		
		addRecord2CorrespondingArrayList(record);
		
		go2FinalPhaseIfDoneAllRecordsInput();
	}
	
	/**
	 * 1.output/write every record into file-stream.
	 * 2.display/set concatenated records to areas considered; and finally
	 * 3.set every formatted record to  output RecordListArea
	 * 4.display/show total processed results to  a record-results area in the
	 *   grade-book form
	 * 5.set total student number (already processed) in JTextField considered.
	 * @param record
	 */
	public void writeRecord2ReportFileNdisplayCompleteRecord(Employee record)
	{
		if (!isReadFile) {
			addEveryRecord2FileStream(record);
		}//end if
		
		frameEmployee.txtArea4RecordTextArea
		        .setText(frameEmployee.employeeBook.recordsConcatenated);
		
		frameEmployee.listModel.addElement(record.toString3());
		
		if (!isReadFile)//only for creating file.
			frameEmployee.txtFieldEarnings.setText(twoDigits.format(record.earnings()));
		
		frameEmployee.txtFieldEmpCounter.setText(String.format("%d",employeeCounter));
	}// end writeRecord2ReportFileNdisplayCompleteRecord
	
	public void addEveryRecord2FileStream(Employee record)
	{
		if (streamType_MenuOption == FileStramType_MenuOption_Pan2040.BYTE_BASED) {
			try {
				outputO.writeObject(record);
				outputO.flush();
			} catch (IOException e) {
				e.printStackTrace();
				JOptionPane.showMessageDialog(null, "Something wrong with your record data!",
						"No data was added into file", JOptionPane.ERROR_MESSAGE);
			}
		}else {
			outputT.format("%s", record); //text
		}
	}//end addEveryRecord2FileStream
	
	public void addRecord2CorrespondingArrayList(Employee record) {
		if (record instanceof SalariedEmployee) {
			eList_Salaried.add((SalariedEmployee) record);
		}else if (record instanceof HourlyEmployee) {
			eList_Hourly.add((HourlyEmployee) record);
		}else if (record instanceof BasePlusCommissionEmployee) {
			System.out.println("I am in BasePlusCommissionEmployee");
			eList_BasePlusCommission.add((BasePlusCommissionEmployee) record);
		}else if (record instanceof CommissionEmployee) {
			eList_Commission.add((CommissionEmployee) record);
			System.out.println("I am in CommissionEmployee");
		}else {
			System.out.println("Add Nothing!");
		}
	}
	
	public void go2FinalPhaseIfDoneAllRecordsInput()
	{
		if (employeeCounter == EmployeeNo) { //Counter equal EmployeeNo
			JOptionPane.showMessageDialog(null, "All employee' records have done input!");
			
			addWholeRecords2JTable();
			
			displayNcompleteEarningBookResults(frameEmployee.employeeBook);
			
			if (!isReadFile)
			{
				WriteLogFile(frameEmployee.employeeBook);
				closeFile(); //close all for only for "write file"
			}
			
			resetButtons4NewStart(true);
			
			frameEmployee.btnOpenFile.setEnabled(false);
			frameEmployee.btnCalculate.setEnabled(false);
		}
	}//end go2FinalPhaseIfDoneAllRecordsInput
	
	public void WriteLogFile(EmployeeBaseBook_Pan2040 _employeeBook)
	{
		if (fileWritten != null && OpenFileRecord_Pan2040.output != null) {
			OpenFileRecord_Pan2040.output.format(frameEmployee.employeeBook.toString());
		} else {
			JOptionPane.showMessageDialog(null, "No file was choose!", "Choose a file FIRST.",
					JOptionPane.INFORMATION_MESSAGE);
			
			return;
		}
	}//end WriteLogFile
	
	
	public void addWholeRecords2JTable()
	{
		frameEmployee.dataUsed = returnObjectArray();
		TableDialogEditDemoWithLevels_Pan2040 demoTable = new TableDialogEditDemoWithLevels_Pan2040(
				frameEmployee.table4RecordTableArea, frameEmployee.namesUsed, frameEmployee.dataUsed);
			
		frameEmployee.tableAggregate = demoTable.scrollPane;
//			TableDemo4PayrollSystem demoOK = new TableDemo4PayrollSystem(null, 
//					frameEmployee.contentPane);
//			
//			frameEmployee.tableAggregate = demoOK.createJTable(frameEmployee.tableAggregate,
//					frameEmployee.table4RecordTableArea, frameEmployee.nameUsed, frameEmployee.dataUsed, null);
	}//end addWholeRecords2JTable()
	
	public void outputFinalReport()
	{
		frameEmployee.txtArea4RecordTextArea.setText(frameEmployee.employeeBook.toString());
		
		frameEmployee.listArea4RecordListArea.setModel(frameEmployee.listModel);
		frameEmployee.addJTable2Box();
	}
	
	public void displayNcompleteEarningBookResults(EmployeeBaseBook_Pan2040 _employeeBook)
	{
		if (employeeCounter != 0) {
			frameEmployee.txtFieldLA.setText("" + frameEmployee.employeeBook.aLevel);
			frameEmployee.txtFieldLB.setText("" + frameEmployee.employeeBook.bLevel);
			frameEmployee.txtFieldLC.setText("" + frameEmployee.employeeBook.cLevel);
			
			frameEmployee.txtFieldEmpCounter.setText(String.format("%d", _employeeBook.employeeCounter));
			frameEmployee.txtFieldHighestE.setText(twoDigits.format(_employeeBook.highestE));
			frameEmployee.txtFieldLowestE.setText(twoDigits.format(_employeeBook.lowestE));
			
			_employeeBook.calculateAverageNproduceLevelArray();
			frameEmployee.txtFieldAverageE.setText(twoDigits.format(_employeeBook.mean));
		}//end if
		else {
			JOptionPane.showMessageDialog(null, "老兄/老姊! 沒半個人 算什麼咚咚啊!", "No preset-profile or input",
					JOptionPane.ERROR_MESSAGE);			
		}
	}//end displayNcompleteEarningBookResults(EmployeeBaseBook_Pan2040 _employeeBook)
	
	public Object[][] returnObjectArray()
	{
		return null;
	}//end Object[][] returnObjectArray()
	
	public void enableProfileTextBoxs(boolean isEnable) //輸入格<TextBooks>要打開 啥時關 啥時開
	{
		boolean condition = false;
		
		for (JTextField txtField : EmployeeBaseJFrame_Pan2040_V4.listTxtextFieldsProfileG) {
			txtField.setEnabled(isEnable);
			condition = !isEnable;
		}
		
		for (JTextField txtField : frameEmployee.listTxtextFieldsResultsG)
			txtField.setEnabled(!isEnable);
		
		for (JTextField txtField : EmployeeBaseJFrame_Pan2040_V4.listTxtextFieldsEmployeeG)
			txtField.setEnabled(!isEnable);
		
		if (condition == true)
		{
			frameEmployee.btnCalculate.setText(Btns4UniversalProcess_MenuOp_Image_Pan2040.Process_Data.getButtonType());
			frameEmployee.btnSetProfile.setEnabled(false);
		} else {
			frameEmployee.btnCalculate.setText(Btns4UniversalProcess_MenuOp_Image_Pan2040.Process_Data.getButtonType());
			frameEmployee.btnSetProfile.setEnabled(true);
		}
	}
	
	public void showPieChartOfWageDistribution(EmployeeBaseBook_Pan2040 _employeeBook)
	{
		_employeeBook.levelsV[0] = (double) ((_employeeBook.aLevel * 100.00) / employeeCounter);
		_employeeBook.levelsV[1] = (double) ((_employeeBook.bLevel * 100.00) / employeeCounter);
		_employeeBook.levelsV[2] = (double) ((_employeeBook.cLevel * 100.00) / employeeCounter);
	}
	
	public void resetComponentsForNewStart()
	{
		enableProfileTextBoxs(true);
		clearProfileAndResults();
		clearRecordTextFields();
		
		checkProfile = false;
		
		clearProfileAndResults();
		
		frameEmployee.txtArea4RecordTextArea.setText("");
		frameEmployee.listArea4RecordListArea.removeAll();
	}
	
	public void openFile(String _filePath) throws FileSystemNotFoundException, NullPointerException, IOException
	{
		isReadFile = false;
		isCreateFile = true;
		employeeCounter = 0;
		JOptionPane.showMessageDialog(null, "This file writer is for log report.", "Write a text-based report", JOptionPane.INFORMATION_MESSAGE);
		fileWritten = OpenFileRecord_Pan2040.getfile(_filePath, useJPane);
		if (fileWritten != null) {
			OpenFileRecord_Pan2040.openFile(fileWritten);
		}
		if (OpenFileRecord_Pan2040.output != null) {
			//Below is for choosing Stream-type used for writing accounts' profile
			JOptionPane.showMessageDialog(null, "The next file writer choosed is for recording every accoount record.",
					"Write Account Records", JOptionPane.INFORMATION_MESSAGE);
			ImageIcon icon = new ImageIcon("./img/QM.png");
			streamType_MenuOption = Choice4FileStreamType_Pan2040.decideWhichFileStreamType(icon, false); //OK
			
			JOptionPane.showMessageDialog(null, streamType_MenuOption, "Stream-type Chosen",
					JOptionPane.INFORMATION_MESSAGE);
			if (streamType_MenuOption != null) {
				//Below is for fileChooser used for writing account records
				FileChoosing4WriteOrRead = new FileChoosing4WriteOrRead_Pan2040_V2(true, false,
						streamType_MenuOption.getValue());
				FileChoosing4WriteOrRead.chooseFile(_filePath, "Create File");
				if (FileChoosing4WriteOrRead.result == JFileChooser.APPROVE_OPTION) {
					FileChoosing4WriteOrRead.OpenFile2Write(streamType_MenuOption.getOptionType());
					String companyString = String.format("%s\t%s\n", "Company", CompanyName);
					String employeeNoString = String.format("%s\t%s","EmployeeNo", EmployeeNo);
					if (streamType_MenuOption == FileStramType_MenuOption_Pan2040.BYTE_BASED) {
						outputO = FileChoosing4WriteOrRead.outputO; // here output has been implemented and not 'null'
						
						//write basic profile into file
						outputO.writeObject(companyString);
						outputO.writeObject(employeeNoString);
					} else {
						outputT = FileChoosing4WriteOrRead.outputT; // here output has been implemented and not 'null'
						
						//write basic profile into file
						outputT.format(companyString);
						outputT.format(employeeNoString);
					}
					frameEmployee.btnOpenFile.setEnabled(false);//New one
					frameEmployee.btnCalculate.setEnabled(true);//New one
					frameEmployee.btnClearRecord.setEnabled(true);
				}
			} else 
				JOptionPane.showMessageDialog(null, "you just cancel the action");
		}// end if (OpenFileRecord_Pan2040.output != null)
	}// emd openFile
	
	public void closeFile()
	{
		OpenFileRecord_Pan2040.closeFile();
		FileChoosing4WriteOrRead.closeFile();
		
		isFileChoosenOK = false;
	}// end of closeFile()
	
	public void readFile() throws ClassNotFoundException, IOException, NoSuchElementException, NullPointerException,
										IllegalArgumentException, ClassCastException, ArrayIndexOutOfBoundsException
	{
		isReadFile = true;
		boolean isFileNeeded = false;
		
		if (frameEmployee.ifPreviewing)
		{
			JOptionPane.showMessageDialog(null, "This file reader is for previewing log report.",
				"Read a text-based log report", JOptionPane.INFORMATION_MESSAGE);
			
			isFileNeeded = OpenFileRecord_Pan2040.readFile2PreviewContent4ContinueOrNot(frameEmployee.txtArea4RecordTextArea,
					filePath, useSimpleOne);
		
			if (isFileNeeded)
				readFile_EmployeeAccount();
		}else {//just directly read account without previewing file for confirmation
			readFile_EmployeeAccount();
		}
	}// end readFile()
	
	public void readFile_EmployeeAccount() throws ClassNotFoundException, IOException, ArrayIndexOutOfBoundsException
	{
		JOptionPane.showMessageDialog(null, "This file reader choosen is for reading every account record.",
				"Read Account Records", JOptionPane.INFORMATION_MESSAGE);
		ImageIcon icon = new ImageIcon("./image/QM.png");
		streamType_MenuOption = Choice4FileStreamType_Pan2040.decideWhichFileStreamType(icon, isJOptionPaneUsed);
		
		if (streamType_MenuOption != null) {
			FileChoosing4WriteOrRead = new FileChoosing4WriteOrRead_Pan2040_V2(false, true, streamType_MenuOption.getValue());
			
			FileChoosing4WriteOrRead.chooseFile(filePath, "Read File");
			FileChoosing4WriteOrRead.OpenFile2Read(streamType_MenuOption.getOptionType());
			
			if (streamType_MenuOption == FileStramType_MenuOption_Pan2040.BYTE_BASED) {
				inputO = FileChoosing4WriteOrRead.inputO;//Here, output has been implemented and not 'null'
				
				//Read basic profile into file
				companyString = inputO.readObject().toString();
				employeeNoString = inputO.readObject().toString();
			} else {
				inputT = FileChoosing4WriteOrRead.inputT;//Here, input has been implemented and not 'null'
				
				//Read basic profile into file
				companyString = inputT.nextLine();
				employeeNoString = inputT.nextLine();
			}
			
			advancedlyProcessBasics();
			
			if (FileChoosing4WriteOrRead.result == JFileChooser.APPROVE_OPTION) {
				System.out.println("File chosen for Read is succesfully opened!");
			}
			isFileChoosenOK = true;
		} else
			JOptionPane.showMessageDialog(null, "you just cancel the action!");
	}// end readFile_EmployeeAccount()
	
	public void advancedlyProcessBasics() throws ArrayIndexOutOfBoundsException
	{
		String[] arrOfStr = companyString.split("\t"); //切割
		CompanyName = arrOfStr[1];
		frameEmployee.txtFieldCN.setText(CompanyName);
		frameEmployee.txtFieldCN.setEnabled(false);
		
		arrOfStr = employeeNoString.split("\t");
		EmployeeNo = Integer.parseInt(arrOfStr[1]);
		frameEmployee.txtFieldEN.setText(arrOfStr[1]);
		frameEmployee.txtFieldEN.setEnabled(false);
		
		JOptionPane.showMessageDialog(null, "CompanyName=" + CompanyName + "\nEmployeeNo" + EmployeeNo);
		
		//initialize a new employeeBook for frameEmployee considered
		frameEmployee.employeeBook = frameEmployee.setBasics2StartBookingEmployee();
		employeeCounter = 0;//reset to zero
	}//end advancedlyProcessBasics()
	
	public void exitAppinQuestion() {
		frameEmployee.dispose();
	}// end exitAppInQuestion
	
	public void refreshJFrame() 
	{
		if (frameEmployee != null) {
			frameEmployee.dispose();
			
			frameEmployee = frameEmployee.refreshJFrame();
		} else 
			JOptionPane.showMessageDialog(null, "You haven't started anything yet!", "Start Input data first",
					JOptionPane.INFORMATION_MESSAGE);
	}// end refreshJFrame
	
	public void clearRecordTextFields()
	{
		for (JTextField txtField : EmployeeBaseJFrame_Pan2040_V4.listTxtextFieldsEmployeeG)	
			txtField.setText("");
	}// end clearRecordTextFields()
	
	public void clearProfileAndResults() 
	{
		for (JTextField txtField : EmployeeBaseJFrame_Pan2040_V4.listTxtextFieldsProfileG)
			txtField.setText("");
		
		for (JTextField txtField : frameEmployee.listTxtextFieldsResultsG)
			txtField.setText("");
	}//end clearProfileAndResults() 
	
	public void readRecordData() throws NumberFormatException, ClassNotFoundException, NoSuchElementException,
	NullPointerException, ClassCastException, IOException
	{
		
	}
	
	public void RunPieChart3DFX()
	   {
		PieChart3DFXDemo3_Modified_Pan2040.categories = new String [3];
	   	
	   	PieChart3DFXDemo3_Modified_Pan2040.categories= Stream.of(
	   			EarningLevelEnum_Pan2040.LevelA.getLevelType(),
	   			EarningLevelEnum_Pan2040.LevelB.getLevelType(),
	   			EarningLevelEnum_Pan2040.LevelC.getLevelType()).toArray(String[]::new);
	   	
	   	PieChart3DFXDemo3_Modified_Pan2040.values4Categories=new double[PieChart3DFXDemo3_Modified_Pan2040.categories.length];
	   	PieChart3DFXDemo3_Modified_Pan2040.values4Categories[0] = frameEmployee.employeeBook.levelsV [0] ;
	   	PieChart3DFXDemo3_Modified_Pan2040.values4Categories[1] = frameEmployee.employeeBook.levelsV [1];
	   	PieChart3DFXDemo3_Modified_Pan2040.values4Categories[2] = frameEmployee.employeeBook.levelsV [2];
	   	
	   	PieChart3DFXDemo3_Modified_Pan2040.title2Display="Wage Distribution";

//	   	PieChart3DFXDemo3_Modified_Pan2040.launch(PieChart3DFXDemo3_Modified_Pan2040.class);
		PieChart3DFXDemo3_Modified_Pan2040.launchMore(PieChart3DFXDemo3_Modified_Pan2040.class);
	   }//end RunPieChart3DFX
}
