package Pan.polymorphism.employee.frame;

import java.awt.EventQueue;
import javax.swing.JTextField;
import javax.swing.border.CompoundBorder;

import Pan.polymorphism.employee.btncontroller.BtnController4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.earningbook.EmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperCommissionEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeRecordIndices_Pan2040;

import javax.swing.border.BevelBorder;
import java.awt.Color;

import javax.swing.JDesktopPane;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.SwingConstants;

public class CommissionEmployeeJFrame_Pan2040_V7 extends EmployeeBaseJFrame_Pan2040_V4 {
	public JTextField txtFieldGrossSales;
	public JTextField txtFieldCommissionRate;
	private JLabel lblGrossSales;
	private JLabel lblCommissionRate;

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
		employeeType = "Commision Emplyee (by Ling-Chang Pan2040 )";
		CommissionEmployeeJFrame_Pan2040_V7 frame = new CommissionEmployeeJFrame_Pan2040_V7(employeeType);
		
		Main_Run(frame, employeeType, new BtnController4SuperEmployeeBase_Pan2040(frame,null));
	}//end main
	

	public CommissionEmployeeJFrame_Pan2040_V7(String employeeType) {
		super(employeeType);
		employeeType4Jframe = "Commision Emplyee (by Ling-Chang Pan2040 )";
		helper4Employee = new Helper4SuperCommissionEmployeeBase_Pan2040(this);
	}
	

	public CommissionEmployeeJFrame_Pan2040_V7(String employeeType,JDesktopPane theDesktop) {
		super(employeeType);
		helper4Employee = new Helper4SuperCommissionEmployeeBase_Pan2040(this);
	}
	
	@Override
	protected void setupComponents4JPanel() {
		super.setupComponents4JPanel();

		txtFieldGrossSales = new JTextField();
		txtFieldGrossSales.setColumns(10);
		txtFieldGrossSales.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),

						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		txtFieldGrossSales.setBounds(110, 399, 96, 21);
		contentPane.add(txtFieldGrossSales);

		lblGrossSales = new JLabel("Gross Sales:");
		lblGrossSales.setHorizontalAlignment(SwingConstants.RIGHT);
		lblGrossSales.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblGrossSales.setBounds(31, 394, 69, 29);
		contentPane.add(lblGrossSales);

		lblCommissionRate = new JLabel("Commission Rate:");
		lblCommissionRate.setHorizontalAlignment(SwingConstants.RIGHT);
		lblCommissionRate.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblCommissionRate.setBounds(240, 391, 108, 29);
		contentPane.add(lblCommissionRate);

		txtFieldCommissionRate = new JTextField();
		txtFieldCommissionRate.setColumns(10);
		txtFieldCommissionRate.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),

						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		txtFieldCommissionRate.setBounds(359, 399, 96, 21);
		contentPane.add(txtFieldCommissionRate);
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
		
		listTxtextFieldsEmployeeG.add(txtFieldGrossSales);
		listTxtextFieldsEmployeeG.add(txtFieldCommissionRate);
	}//end initializeTextFieldArrayList()
	
	@Override
	public EmployeeBaseBook_Pan2040 setBasics2StartBookingEmployee() {
		employeeBook = new EmployeeBaseBook_Pan2040(helper4Employee.CompanyName, helper4Employee.EmployeeNo, true);
		return employeeBook;
	}//end setBasics2StartBookingEmployee
	
	@Override
	public EmployeeBaseJFrame_Pan2040_V4 refreshJFrame() { //app refresh open
		EmployeeBaseJFrame_Pan2040_V4 component = new CommissionEmployeeJFrame_Pan2040_V7(employeeType4Jframe);
		
//		helper4Employee = new Helper4SuperCommissionEmployeeBase_Pan2040(component);
		
		btnController = new BtnController4SuperEmployeeBase_Pan2040(component, null);
		Main_Run(component, employeeType4Jframe, btnController);
		
		return component;
	}//end refreshJFrame
}
