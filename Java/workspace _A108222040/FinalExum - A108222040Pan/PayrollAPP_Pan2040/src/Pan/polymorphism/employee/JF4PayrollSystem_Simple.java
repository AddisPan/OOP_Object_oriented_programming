/*
 * Copyright (c) 1995, 2008, Oracle and/or its affiliates. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 *
 *   - Redistributions of source code must retain the above copyright
 *     notice, this list of conditions and the following disclaimer.
 *
 *   - Redistributions in binary form must reproduce the above copyright
 *     notice, this list of conditions and the following disclaimer in the
 *     documentation and/or other materials provided with the distribution.
 *
 *   - Neither the name of Oracle or the names of its
 *     contributors may be used to endorse or promote products derived
 *     from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS
 * IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO,
 * THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
 * PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL THE COPYRIGHT OWNER OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
 * EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */ 

package Pan.polymorphism.employee;

import javax.swing.JInternalFrame;
import javax.swing.JDesktopPane;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JMenuBar;
import javax.swing.JFrame;
import javax.swing.KeyStroke;

import com.sun.corba.se.spi.activation._ActivatorImplBase;

import Pan.library.enummenu.MenuOption;
import Pan.polymorphism.employee.btncontroller.BtnController4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.frame.BasePlusCommissionEmployeeJFrame_Pan2040;
import Pan.polymorphism.employee.frame.CommissionEmployeeJFrame_Pan2040_V7;
import Pan.polymorphism.employee.frame.EmployeeBaseJFrame_Pan2040_V4;
import Pan.polymorphism.employee.frame.HourlyEmployeeJFrame_Pan2040;
import Pan.polymorphism.employee.frame.SalariedEmployeeJFrame_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperBasePlusCommissionEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperCommissionEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperHouorlyEmployeeBase_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperSalariedEmployeeBase_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeType_MenuOption_Pan2040;
import Pan.prestudy.oracle.jintemalframe.MyInternalFrame;

import java.awt.event.*;
import java.awt.*;

/*
 * InternalFrameDemo.java requires:
 *   MyInternalFrame.java
 */
public class JF4PayrollSystem_Simple extends JFrame
                               implements ActionListener {
    JDesktopPane desktop;
    EmployeeBaseJFrame_Pan2040_V4 baseEmployee;
    CommissionEmployeeJFrame_Pan2040_V7 commissionEmployee;
    BasePlusCommissionEmployeeJFrame_Pan2040 basePlusCommissionEmployee;
    HourlyEmployeeJFrame_Pan2040 hourlyEmployee;
    SalariedEmployeeJFrame_Pan2040 SalariedEmployee;
    
    public static Helper4SuperEmployeeBase_Pan2040 helper4Employee;
    
    public EmployeeType_MenuOption_Pan2040 [] employeeChoices = { EmployeeType_MenuOption_Pan2040.BaseEmployee,
    		EmployeeType_MenuOption_Pan2040.SalariedEmployee, EmployeeType_MenuOption_Pan2040.HourlyEmployee,
    		EmployeeType_MenuOption_Pan2040.CommissionEmployee, EmployeeType_MenuOption_Pan2040.BasePlusCommissionEmployee,
    		EmployeeType_MenuOption_Pan2040.Quit
    };

    public JF4PayrollSystem_Simple() {
        super("Grade-Book Aplication - Using InternalFrameDemo (by Pan2040)");

        //Make the big window be indented 50 pixels from each edge
        //of the screen.
        int inset = 50;
        Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
        setBounds(inset, inset, screenSize.width  - inset*2, screenSize.height - inset*2);

        //Set up the GUI.
        desktop = new JDesktopPane(); //a specialized layered pane
//        createFrame(); //create first "window"
        setContentPane(desktop);
        setJMenuBar(createMenuBar());

        //Make dragging a little faster but perhaps uglier.
        desktop.setDragMode(JDesktopPane.OUTLINE_DRAG_MODE);
    }

    protected JMenuBar createMenuBar() {
        JMenuBar menuBar = new JMenuBar();

        //Set up the lone menu.
        JMenu menu = new JMenu("Employee");
        menu.setMnemonic(KeyEvent.VK_E);
        menuBar.add(menu);

        //BaseEmployee
        JMenuItem menuItem = new JMenuItem(EmployeeType_MenuOption_Pan2040.BaseEmployee.getEmployeeType());
        menuItem.setMnemonic(KeyEvent.VK_B);
        menuItem.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_B, ActionEvent.ALT_MASK));
        menuItem.setActionCommand(EmployeeType_MenuOption_Pan2040.BaseEmployee.getEmployeeType());
        menuItem.addActionListener(this);
        menu.add(menuItem);

      //SalariedEmployee
        menuItem = new JMenuItem(EmployeeType_MenuOption_Pan2040.SalariedEmployee.getEmployeeType());
        menuItem.setMnemonic(KeyEvent.VK_S);
        menuItem.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_S, ActionEvent.ALT_MASK));
        menuItem.setActionCommand(EmployeeType_MenuOption_Pan2040.SalariedEmployee.getEmployeeType());
        menuItem.addActionListener(this);
        menu.add(menuItem);
        
      //HourlyEmployee
        menuItem = new JMenuItem(EmployeeType_MenuOption_Pan2040.HourlyEmployee.getEmployeeType());
        menuItem.setMnemonic(KeyEvent.VK_H);
        menuItem.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_H, ActionEvent.ALT_MASK));
        menuItem.setActionCommand(EmployeeType_MenuOption_Pan2040.HourlyEmployee.getEmployeeType());
        menuItem.addActionListener(this);
        menu.add(menuItem);
        
      //CommissionEmployee
        menuItem = new JMenuItem(EmployeeType_MenuOption_Pan2040.CommissionEmployee.getEmployeeType());
        menuItem.setMnemonic(KeyEvent.VK_C);
        menuItem.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_C, ActionEvent.ALT_MASK));
        menuItem.setActionCommand(EmployeeType_MenuOption_Pan2040.CommissionEmployee.getEmployeeType());
        menuItem.addActionListener(this);
        menu.add(menuItem);
        
      //BaseEmployee
        menuItem = new JMenuItem(EmployeeType_MenuOption_Pan2040.BasePlusCommissionEmployee.getEmployeeType());
        menuItem.setMnemonic(KeyEvent.VK_P);
        menuItem.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_P, ActionEvent.ALT_MASK));
        menuItem.setActionCommand(EmployeeType_MenuOption_Pan2040.BasePlusCommissionEmployee.getEmployeeType());
        menuItem.addActionListener(this);
        menu.add(menuItem);

        return menuBar;
    }

    //React to menu selections.
    public void actionPerformed(ActionEvent e) {
//        if ("new".equals(e.getActionCommand())) { //new
//            createFrame();
//        } else { //quit
//            quit();
//        }
    	EmployeeType_MenuOption_Pan2040 choice = null;
    	String taskChoiceType_String = e.getActionCommand();
    	JOptionPane.showMessageDialog(null, taskChoiceType_String);
    	
    	for (int i = 0; i < employeeChoices.length; i++)
    	{
    		if (employeeChoices[i].getEmployeeType() == taskChoiceType_String) {
    			choice = employeeChoices[i];
    			break;
    		}
    	}
    	createFrame(taskChoiceType_String, choice);
    }

    //Create a new internal frame.
    protected void createFrame(String actionS, EmployeeType_MenuOption_Pan2040 _empoyeeTypeEnum) {
//    	MyInternalFrame frame = new MyInternalFrame();
//        frame.setVisible(true); //necessary as of 1.3
//        desktop.add(frame);
//        try {
//            frame.setSelected(true);
//        } catch (java.beans.PropertyVetoException e) {}
    	
    	switch (_empoyeeTypeEnum) {
    	case BaseEmployee:
    		baseEmployee = new EmployeeBaseJFrame_Pan2040_V4(EmployeeType_MenuOption_Pan2040.BaseEmployee.getEmployeeType());
			EmployeeBaseJFrame_Pan2040_V4.Main_Run(baseEmployee, _empoyeeTypeEnum.getEmployeeType(),
					new BtnController4SuperEmployeeBase_Pan2040(baseEmployee, desktop));
			
			baseEmployee.setVisible(true);
			desktop.add(baseEmployee);
			
			try {
				baseEmployee.setSelected(true);
			}catch (java.beans.PropertyVetoException ec) {
				
			}//end try-catch
			break;
			
    	case SalariedEmployee:
    		SalariedEmployee = new SalariedEmployeeJFrame_Pan2040(
    				EmployeeType_MenuOption_Pan2040.SalariedEmployee.getEmployeeType());
    		
    		helper4Employee = new Helper4SuperSalariedEmployeeBase_Pan2040(SalariedEmployee);
    		
    		SalariedEmployeeJFrame_Pan2040.Main_Run(SalariedEmployee, _empoyeeTypeEnum.getEmployeeType(),
					new BtnController4SuperEmployeeBase_Pan2040(SalariedEmployee, desktop));
			
    		SalariedEmployee.setVisible(true);
			desktop.add(SalariedEmployee);
			
			try {
				SalariedEmployee.setSelected(true);
			}catch (java.beans.PropertyVetoException ec) {
				
			}//end try-catch
			break;
			
    	case HourlyEmployee:
    		hourlyEmployee = new HourlyEmployeeJFrame_Pan2040(
    				EmployeeType_MenuOption_Pan2040.HourlyEmployee.getEmployeeType());
    		
    		helper4Employee = new Helper4SuperHouorlyEmployeeBase_Pan2040(hourlyEmployee);
    		
    		HourlyEmployeeJFrame_Pan2040.Main_Run(hourlyEmployee, _empoyeeTypeEnum.getEmployeeType(),
					new BtnController4SuperEmployeeBase_Pan2040(hourlyEmployee, desktop));
			
    		hourlyEmployee.setVisible(true);
			desktop.add(hourlyEmployee);
			
			try {
				hourlyEmployee.setSelected(true);
			}catch (java.beans.PropertyVetoException ec) {
				
			}//end try-catch
			break;
			
    	case CommissionEmployee:
    		commissionEmployee = new CommissionEmployeeJFrame_Pan2040_V7(
    				EmployeeType_MenuOption_Pan2040.CommissionEmployee.getEmployeeType());
    		
    		helper4Employee = new Helper4SuperCommissionEmployeeBase_Pan2040(commissionEmployee);
    		
    		CommissionEmployeeJFrame_Pan2040_V7.Main_Run(commissionEmployee, _empoyeeTypeEnum.getEmployeeType(),
					new BtnController4SuperEmployeeBase_Pan2040(commissionEmployee, desktop));
			
    		commissionEmployee.setVisible(true);
			desktop.add(commissionEmployee);
			
			try {
				commissionEmployee.setSelected(true);
			}catch (java.beans.PropertyVetoException ec) {
				
			}//end try-catch
			break;
			
    	case BasePlusCommissionEmployee:
    		basePlusCommissionEmployee = new BasePlusCommissionEmployeeJFrame_Pan2040(
    				EmployeeType_MenuOption_Pan2040.BasePlusCommissionEmployee.getEmployeeType());
    		
    		helper4Employee = new Helper4SuperBasePlusCommissionEmployeeBase_Pan2040(basePlusCommissionEmployee);
    		
    		BasePlusCommissionEmployeeJFrame_Pan2040.Main_Run(basePlusCommissionEmployee, _empoyeeTypeEnum.getEmployeeType(),
					new BtnController4SuperEmployeeBase_Pan2040(basePlusCommissionEmployee, desktop));
			
    		basePlusCommissionEmployee.setVisible(true);
			desktop.add(basePlusCommissionEmployee);
			
			try {
				basePlusCommissionEmployee.setSelected(true);
			}catch (java.beans.PropertyVetoException ec) {
				
			}//end try-catch
			break;
			
    	case Quit:
    		quit();
    	}//end switch
    }

    //Quit the application.
    protected void quit() {
        System.exit(0);
    }

    /**
     * Create the GUI and show it.  For thread safety,
     * this method should be invoked from the
     * event-dispatching thread.
     */
    private static void createAndShowGUI() {
        //Make sure we have nice window decorations.
        JFrame.setDefaultLookAndFeelDecorated(true);

        //Create and set up the window.
        JF4PayrollSystem_Simple frame = new JF4PayrollSystem_Simple();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        //Display the window.
        frame.setVisible(true);
    }

    public static void main(String[] args) {
        //Schedule a job for the event-dispatching thread:
        //creating and showing this application's GUI.
        javax.swing.SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                createAndShowGUI();
            }
        });
    }
}
