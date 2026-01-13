package Pan.polymorphism.employee.frame;

import java.awt.EventQueue;

public class CommissiomEmployeeJFrame_Pan2040 extends EmployeeBaseJFrame_Pan2040 {

	public  CommissiomEmployeeJFrame_Pan2040(String employeeType)
	{
		super(employeeType);
		getContentPane().setLayout(null);
	}
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		employeeType = "Commison-Emplyee (by Pan2040)";
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					CommissiomEmployeeJFrame_Pan2040 frame = new CommissiomEmployeeJFrame_Pan2040(employeeType);
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
}
