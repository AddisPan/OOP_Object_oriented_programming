package Pan.polymorphism.employee.frame;

import java.awt.EventQueue;
import javax.swing.JTextField;
import javax.swing.border.CompoundBorder;

import Pan.polymorphism.employee.btncontroller.BtnController4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.earningbook.CommissionEmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperCommissionEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperHouorlyEmployeeBase_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeRecordIndices_Pan2040;

import javax.swing.border.BevelBorder;
import java.awt.Color;
import java.awt.Container;

import javax.swing.JDesktopPane;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.SwingConstants;

public class HourlyEmployeeJFrame_Pan2040 extends EmployeeBaseJFrame_Pan2040_V4 {
	public JTextField txtFieldHoursWorked;
	public JTextField txtMaxWorkedhours;
	public JLabel lblHoursWorked;
	public JLabel lblMaxWorkedhours;
	public JLabel lblExtraHourRate;
	public JTextField textFieldextrahourRate;
	public JTextField textFieldhourlyWage;
	private JLabel lblhourlyWage;
	
	public CommissionEmployeeBaseBook_Pan2040 CemployeeBook;

	public static void main(String[] args) {
//		employeeType = "Commison-Emplyee (by Pan2040)";
//		EventQueue.invokeLater(new Runnable() {
//			public void run() {
//				try {
//					CommissionEmployeeJFrame_Pan2040_V7 frame = new CommissionEmployeeJFrame_Pan2040_V7(employeeType);
//					frame.setVisible(true);
//				} catch (Exception e) {
//					e.printStackTrace();
//				}
//			}
//		});
		employeeType = "Houorly Emplyee (by Ling-Chang Pan2040 )";
		HourlyEmployeeJFrame_Pan2040 frame = new HourlyEmployeeJFrame_Pan2040(employeeType);
		
		Main_Run(frame, employeeType, new BtnController4SuperEmployeeBase_Pan2040(frame,null));
	}//end main
	

	public HourlyEmployeeJFrame_Pan2040(String employeeType) {
		super(employeeType);
		employeeType4Jframe = "Houorly Emplyee (by Ling-Chang Pan2040 )";
		helper4Employee = new Helper4SuperHouorlyEmployeeBase_Pan2040(this);
	}
	

	/**
	 * @wbp.parser.constructor
	 */
	public HourlyEmployeeJFrame_Pan2040(String employeeType,JDesktopPane theDesktop) {
		super(employeeType);
		helper4Employee = new Helper4SuperHouorlyEmployeeBase_Pan2040(this);
	}
	
	@Override
	protected void setupComponents4JPanel() {
		super.setupComponents4JPanel();
		contentPane.setLayout(null);

		txtFieldHoursWorked = new JTextField();
		txtFieldHoursWorked.setBounds(110, 399, 96, 21);
		txtFieldHoursWorked.setColumns(10);
		txtFieldHoursWorked.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),

						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldHoursWorked);

		lblHoursWorked = new JLabel("Hours Worked:");
		lblHoursWorked.setBounds(10, 394, 90, 29);
		lblHoursWorked.setHorizontalAlignment(SwingConstants.RIGHT);
		lblHoursWorked.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblHoursWorked);

		lblMaxWorkedhours = new JLabel("Max Worked hours:");
		lblMaxWorkedhours.setBounds(226, 294, 108, 29);
		lblMaxWorkedhours.setHorizontalAlignment(SwingConstants.RIGHT);
		lblMaxWorkedhours.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblMaxWorkedhours);

		txtMaxWorkedhours = new JTextField();
		txtMaxWorkedhours.setBounds(344, 299, 96, 21);
		txtMaxWorkedhours.setColumns(10);
		txtMaxWorkedhours.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),

						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtMaxWorkedhours);
		
		lblExtraHourRate = new JLabel("extra hour Rate:");
		lblExtraHourRate.setHorizontalAlignment(SwingConstants.RIGHT);
		lblExtraHourRate.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblExtraHourRate.setBounds(226, 333, 108, 29);
		contentPane.add(lblExtraHourRate);
		
		textFieldextrahourRate = new JTextField();
		textFieldextrahourRate.setColumns(10);
		textFieldextrahourRate.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
		
								new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		textFieldextrahourRate.setBounds(344, 338, 96, 21);
		contentPane.add(textFieldextrahourRate);
		
		lblhourlyWage = new JLabel("hourlyWage:");
		lblhourlyWage.setHorizontalAlignment(SwingConstants.RIGHT);
		lblhourlyWage.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblhourlyWage.setBounds(31, 426, 69, 29);
		contentPane.add(lblhourlyWage);
		
		textFieldhourlyWage = new JTextField();
		textFieldhourlyWage.setColumns(10);
		textFieldhourlyWage.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
		
								new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		textFieldhourlyWage.setBounds(110, 431, 96, 21);
		contentPane.add(textFieldhourlyWage);
	}

	@Override
	public void initializeTitleNamesList4JTable() {
		super.initializeTitleNamesList4JTable();
		
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.GROSS_SALES.getRecordIndexType());
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.Commission_RATE.getRecordIndexType());
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.EARINGS.getRecordIndexType());
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.WAGE_LEVEL.getRecordIndexType());
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.INDEX_COLOR.getRecordIndexType());
	}
	
	@Override
	protected void initializeTextFieldArrayList() {
		super.initializeTextFieldArrayList();
		
		listTxtextFieldsEmployeeG.add(txtFieldHoursWorked);
		listTxtextFieldsEmployeeG.add(txtMaxWorkedhours);
		listTxtextFieldsEmployeeG.add(textFieldextrahourRate);
		listTxtextFieldsEmployeeG.add(textFieldhourlyWage);
	}//end initializeTextFieldArrayList()
	
	
	public CommissionEmployeeBaseBook_Pan2040 setBasics2StartBookingEmployeeC() {
		CemployeeBook = new CommissionEmployeeBaseBook_Pan2040(helper4Employee.CompanyName, helper4Employee.EmployeeNo, true);
		return CemployeeBook;
	}//end setBasics2StartBookingEmployee
	
	@Override
	public EmployeeBaseJFrame_Pan2040_V4 refreshJFrame() { //app refresh open
		HourlyEmployeeJFrame_Pan2040 component = new HourlyEmployeeJFrame_Pan2040(employeeType4Jframe);
		
		helper4Employee = new Helper4SuperHouorlyEmployeeBase_Pan2040(component);
		
		btnController = new BtnController4SuperEmployeeBase_Pan2040(component, null);
		Main_Run(component, employeeType4Jframe, btnController);
		
		return component;
	}//end refreshJFrame
}
