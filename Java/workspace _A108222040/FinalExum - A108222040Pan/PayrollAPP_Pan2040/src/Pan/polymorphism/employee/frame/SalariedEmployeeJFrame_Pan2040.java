package Pan.polymorphism.employee.frame;

import java.awt.EventQueue;
import javax.swing.JTextField;
import javax.swing.border.CompoundBorder;

import Pan.polymorphism.employee.btncontroller.BtnController4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.earningbook.EmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.earningbook.SalariedEmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperCommissionEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperSalariedEmployeeBase_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeRecordIndices_Pan2040;

import javax.swing.border.BevelBorder;
import java.awt.Color;
import java.awt.Container;

import javax.swing.JDesktopPane;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.SwingConstants;

public class SalariedEmployeeJFrame_Pan2040 extends EmployeeBaseJFrame_Pan2040_V4 {
	public JTextField txtFieldweekSalary;
	public JLabel lblweekSalary;

//	public static Helper4SuperSalariedEmployeeBase_Pan2040 helper4Employee;
//	SalariedEmployeeBaseBook_Pan2040 employeeBook;
	/**
	 * Launch the application.
	 */
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
		employeeType = "SalariedEmployee (by Ling-Chang Pan2040 )";
		SalariedEmployeeJFrame_Pan2040 frame = new SalariedEmployeeJFrame_Pan2040(employeeType);
		
		Main_Run(frame, employeeType, new BtnController4SuperEmployeeBase_Pan2040(frame,null));
	}//end main
	

	public SalariedEmployeeJFrame_Pan2040(String employeeType) {
		super(employeeType);
		employeeType4Jframe = "SalariedEmployee (by Ling-Chang Pan2040 )";
		helper4Employee = new Helper4SuperSalariedEmployeeBase_Pan2040(this);
	}
	

	/**
	 * @wbp.parser.constructor
	 */
	public SalariedEmployeeJFrame_Pan2040(String employeeType,JDesktopPane theDesktop) {
		super(employeeType);
		helper4Employee = new Helper4SuperSalariedEmployeeBase_Pan2040(this);
	}
	@Override
	protected void setupComponents4JPanel() {
		super.setupComponents4JPanel();

		txtFieldweekSalary = new JTextField();
		txtFieldweekSalary.setColumns(10);
		txtFieldweekSalary.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),

						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldweekSalary);

		lblweekSalary = new JLabel("weekSalary:");
		lblweekSalary.setHorizontalAlignment(SwingConstants.RIGHT);
		lblweekSalary.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblweekSalary.setBounds(31, 394, 69, 29);
		contentPane.add(lblweekSalary);
	}

	@Override
	public void initializeTitleNamesList4JTable() {
		super.initializeTitleNamesList4JTable();
		
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.WEEKLY_SALARY.getRecordIndexType());
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.WAGE_LEVEL.getRecordIndexType());
		listTitleName4Table.add(EmployeeRecordIndices_Pan2040.INDEX_COLOR.getRecordIndexType());
	}
	
	@Override
	protected void initializeTextFieldArrayList() {
		super.initializeTextFieldArrayList();
		
		listTxtextFieldsEmployeeG.add(txtFieldweekSalary);
	}//end initializeTextFieldArrayList()
	
	@Override
	public EmployeeBaseBook_Pan2040 setBasics2StartBookingEmployee() {
		employeeBook = new EmployeeBaseBook_Pan2040(helper4Employee.CompanyName, helper4Employee.EmployeeNo, true);
		return employeeBook;
	}//end setBasics2StartBookingEmployee
	
	@Override
	public EmployeeBaseJFrame_Pan2040_V4 refreshJFrame() { //app refresh open
		EmployeeBaseJFrame_Pan2040_V4 component = new SalariedEmployeeJFrame_Pan2040(employeeType4Jframe);
		
//		helper4Employee = new Helper4SuperSalariedEmployeeBase_Pan2040(component);
		
		btnController = new BtnController4SuperEmployeeBase_Pan2040(component, null);
		Main_Run(component, employeeType4Jframe, btnController);
		
		return component;
	}//end refreshJFrame
}
