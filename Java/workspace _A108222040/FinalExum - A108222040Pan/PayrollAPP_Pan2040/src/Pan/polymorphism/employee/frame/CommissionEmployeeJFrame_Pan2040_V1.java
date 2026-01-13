package Pan.polymorphism.employee.frame;

import java.awt.EventQueue;
import javax.swing.JTextField;
import javax.swing.border.CompoundBorder;
import javax.swing.border.BevelBorder;
import java.awt.Color;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.SwingConstants;

public class CommissionEmployeeJFrame_Pan2040_V1 extends EmployeeBaseJFrame_Pan2040 {
	private JTextField txtFieldGrossSales;
	private JTextField txtFieldCommissionRate;
	private JLabel lblGrossSales;
	private JLabel lblCommissionRate;

	public  CommissionEmployeeJFrame_Pan2040_V1(String employeeType)
	{
		super(employeeType);
		
		txtFieldGrossSales = new JTextField();
		txtFieldGrossSales.setColumns(10);
		txtFieldGrossSales.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
								new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		txtFieldGrossSales.setBounds(110, 399, 96, 21);
		getContentPane().add(txtFieldGrossSales);
		
		lblGrossSales = new JLabel("Gross Sales:");
		lblGrossSales.setHorizontalAlignment(SwingConstants.RIGHT);
		lblGrossSales.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblGrossSales.setBounds(31, 394, 69, 29);
		getContentPane().add(lblGrossSales);
		
		lblCommissionRate = new JLabel("Commission Rate:");
		lblCommissionRate.setHorizontalAlignment(SwingConstants.RIGHT);
		lblCommissionRate.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblCommissionRate.setBounds(240, 391, 108, 29);
		getContentPane().add(lblCommissionRate);
		
		txtFieldCommissionRate = new JTextField();
		txtFieldCommissionRate.setColumns(10);
		txtFieldCommissionRate.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
								new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		txtFieldCommissionRate.setBounds(359, 399, 96, 21);
		getContentPane().add(txtFieldCommissionRate);
	}
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		employeeType = "Commison-Emplyee (by Pan2040)";
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					CommissionEmployeeJFrame_Pan2040_V1 frame = new CommissionEmployeeJFrame_Pan2040_V1(employeeType);
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
}
