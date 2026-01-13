package Pan.polymorphism.employee.frame;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Font;
import java.util.List;
import java.util.LinkedList;

import javax.swing.Box;
import javax.swing.DefaultListModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JDesktopPane;
import javax.swing.JFrame;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JSeparator;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.border.BevelBorder;
import javax.swing.border.CompoundBorder;
import javax.swing.border.MatteBorder;
import javax.swing.border.TitledBorder;

import com.sun.istack.internal.NotNull;

import Pan.library.checkandvalidation.InputNumberValidation_GUI_CONSOLE_Pan2040;
import Pan.library.enummenu.Btns4UniversalProcess_MenuOp_Image_Pan2040;
import Pan.library.enummenu.Btns4UniversalProcess_MenuOp_noImage_Pan2040;
import Pan.polymorphism.employee.btncontroller.BtnController4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.earningbook.CommissionEmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.earningbook.EmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.earningbook.SalariedEmployeeBaseBook_Pan2040;
import Pan.polymorphism.employee.helper.Helper4SuperEmployeeBase_Pan2040;
import Pan.polymorphism.employee.menuoption.EmployeeRecordIndices_Pan2040;

public class EmployeeBaseJFrame_Pan2040_V4 extends JInternalFrame {
	public static EmployeeBaseJFrame_Pan2040_V4 frame;

	public JPanel contentPane;
	public JTextField txtFieldCN;
	public JTextField txtFieldEN;
	public JTextField txtFieldEarnings;
	public JTextField txtFieldSSN;
	public JTextField txtFieldFN;
	public JTextField txtFieldLN;
	public JTextField txtFieldEmpCounter;
	public JTextField txtFieldHighestE;
	public JTextField txtFieldLowestE;
	public JTextField txtFieldAverageE;
	public JTextField txtFieldLA;
	public JTextField txtFieldLB;
	public JTextField txtFieldLC;
	public JButton btnSetProfile;
	public JButton btnClearProfile;
	public JLabel lblCompanyName;
	public JLabel lblTotalEmployees;
	public JLabel lblEarnings;
	public JButton btnClearRecord;
	public JLabel lblSSN;
	public JLabel lblFirstName;
	public JLabel lblLastName;
	public JLabel lblEmpCounter;
	public JLabel lblHighestEarnings;
	public JLabel lblLowestEarnings;
	public JLabel lblAverageEarnings;
	public JLabel lblAlevel;
	public JLabel lblBlevel;
	public JLabel lblClevel;
	public JLabel lblUnit;
	public JLabel lblUnitSymbol;
	public JButton btnRefresh;
	public JButton btnPieChartDemo;
	public JButton btnOutputAll;
	public JButton btnCalculate;
	public JButton btnOpenFile;
//	public JButton btnWriteFile;
	public JButton btnReadFile;
//	public JButton btnCloseFile;
	public JButton btnExit;
	public JLabel lblResultArea;
	public JSeparator separatorResultTop;
	public JSeparator separatorResultBottom;
	public JSeparator separator_1;
	public JLabel lblRange;
	public JLabel lblCUpperThreshold;
	public JLabel lblDistribution;
	public JSeparator separator;
	public JSeparator separator_2;
	public JLabel lblBUpperThreshold;
	public JLabel lblALowerThreshold;
	public JLabel lblBLowerThreshold;

	public static String employeeType;
	JTabbedPane tabbedPane;
	public String title4InputArea = "Main Frame Area", tip4InputArea = "Input Frame Calculate";
	public String title4TextArea = "Report Output Area", tip4TextArea = "Output Final Report";
	public String title4JList = "Record List Area", tip4JList = "Output Record List";
	public String title4JTable = "Record Output Area", tip4JTable = "Output Record to Table";

	public JTextArea txtArea4RecordTextArea;
	public JList<Object> listArea4RecordListArea;

	public JTable table4RecordTableArea;
	public Box box1, box2, box3;

	public static List<JTextField> listTxtextFieldsProfileG = new LinkedList<>();
	public static List<JTextField> listTxtextFieldsEmployeeG = new LinkedList<>();
	public List<JTextField> listTxtextFieldsResultsG = new LinkedList<>();

	public List<String> listTitleName4Table = new LinkedList<>();
	public String[] namesUsed;
	public Object[][] dataUsed; //used for JTable
	
	public JScrollPane tableAggregate;

	public JButton[] optionButtons;

	public Btns4UniversalProcess_MenuOp_Image_Pan2040[] basicChoices = {
			Btns4UniversalProcess_MenuOp_Image_Pan2040.Process_Data, Btns4UniversalProcess_MenuOp_Image_Pan2040.Refresh,
			Btns4UniversalProcess_MenuOp_Image_Pan2040.Clear_Record,
			Btns4UniversalProcess_MenuOp_Image_Pan2040.Set_Profile,
			Btns4UniversalProcess_MenuOp_Image_Pan2040.Clear_Profile_and_Results,
			Btns4UniversalProcess_MenuOp_Image_Pan2040.Output_Results, Btns4UniversalProcess_MenuOp_Image_Pan2040.Exit,
			Btns4UniversalProcess_MenuOp_Image_Pan2040.OpenFile, Btns4UniversalProcess_MenuOp_Image_Pan2040.ReadFile,
//			Btns4UniversalProcess_MenuOp_noImage_Pan2040.WriteFile,Btns4UniversalProcess_MenuOp_noImage_Pan2040.CloseFile,
			Btns4UniversalProcess_MenuOp_Image_Pan2040.PieChartDemo };
	public EmployeeBaseBook_Pan2040 employeeBook;
	public static Helper4SuperEmployeeBase_Pan2040 helper4Employee;
	public static String employeeType4Jframe;
	public static BtnController4SuperEmployeeBase_Pan2040 btnController;
	
	public boolean ifPreviewing = true; //for previewing file to see if it is a needed file with right format of data
	public boolean isSimpleFormat = false;
	
	public DefaultListModel <Object> listModel = new DefaultListModel<Object>();
	
	JDesktopPane theDesktop;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
//		employeeType = "SuperBase Emplyee (by Ling-Chang Pan2040 )";
//		EventQueue.invokeLater(new Runnable() {
//			public void run() {
//				try {
//					EmployeeBaseJFrame_Pan2040_V4 frame = new EmployeeBaseJFrame_Pan2040_V4(employeeType);
//					frame.setVisible(true);
//				} catch (Exception e) {
//					e.printStackTrace();
//				}
//			}
//		});
		
		employeeType = "SuperBase Emplyee (by Ling-Chang Pan2040 )";
		EmployeeBaseJFrame_Pan2040_V4 frame_real = new EmployeeBaseJFrame_Pan2040_V4(employeeType);
		
		Main_Run(frame_real, employeeType, new BtnController4SuperEmployeeBase_Pan2040(frame_real, null));
	}

	/**
	 * Create the frame.
	 */
	public EmployeeBaseJFrame_Pan2040_V4(String employeeType) {
		super (employeeType + "-App",
				true,
				true,
				true,
				true);
		
		employeeType4Jframe = employeeType;
		setupAll();
	}
	
	public EmployeeBaseJFrame_Pan2040_V4(String employeeType, JDesktopPane _theDesktop) {
			super (employeeType + "-App",
					true,
					true,
					true,
					true);
			
			employeeType4Jframe = employeeType;
			setupAll();
			theDesktop =_theDesktop;
		}
	
	public void setupAll() {
        setUpTitleAndBasics4JFrame ( "Employee-Book Application for", employeeType);
		
		createAndSetupCoreComponent4JTabbedPane(); //Table(桌子)

		setupComponents4JPanel(); //Panel(盤子)

		initializeButtonArray(); //Button

		initializeTextFieldArrayList();

		initializeTitleNamesList4JTable();

		initializeTitleNamesString4JTable();
		
		helper4Employee = new Helper4SuperEmployeeBase_Pan2040(this);
	}
	
	public static void Main_Run(EmployeeBaseJFrame_Pan2040_V4 component, String _employeeType,
			BtnController4SuperEmployeeBase_Pan2040 _buttonController) {
		btnController = _buttonController;
		btnController.addActionListenerOnButtons();
		run2StartOrRefresh(_employeeType, component);
		
		component.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		component.setVisible(true);
	}
	
	public static void run2StartOrRefresh (String _frameTitle, EmployeeBaseJFrame_Pan2040_V4 component) {
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					frame = component;
					
					frame.setTitle(_frameTitle);
					frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
					frame.setBounds(100, 100, 722, 821);
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
	
	protected void setUpTitleAndBasics4JFrame (String _frameTitle, String employeeType) {
		setTitle("Application of" + employeeType);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 714, 787);
	}

	protected void createAndSetupCoreComponent4JTabbedPane() {
		contentPane = new JPanel();
//		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setBorder(new BevelBorder(BevelBorder.LOWERED, Color.LIGHT_GRAY, null, Color.CYAN, null));
//		setContentPane(contentPane);

		contentPane.setLayout(null);

		box1 = Box.createHorizontalBox();
		box2 = Box.createHorizontalBox();
		box3 = Box.createHorizontalBox();

		txtArea4RecordTextArea = new JTextArea(500, 650);
		txtArea4RecordTextArea.setEditable(false);
		box1.add(new JScrollPane(txtArea4RecordTextArea));

		listArea4RecordListArea = new JList<>();
		listArea4RecordListArea.setBounds(10, 10, 500, 600);
		listArea4RecordListArea.setAutoscrolls(true);

		box2.add(new JScrollPane(listArea4RecordListArea));

		tabbedPane = new JTabbedPane();
		tabbedPane.addTab(title4InputArea, null, contentPane, tip4InputArea);
		tabbedPane.addTab(title4TextArea, null, box1, tip4TextArea);
		tabbedPane.addTab(title4JList, null, box2, tip4JList);
		tabbedPane.addTab(title4JTable, null, box3, tip4JTable);

		tabbedPane.setBackgroundAt(0, Color.CYAN);
		tabbedPane.setBackgroundAt(1, Color.GREEN);
		tabbedPane.setBackgroundAt(2, Color.YELLOW);
		tabbedPane.setBackgroundAt(3, Color.MAGENTA);

		getContentPane().add(tabbedPane);
	}

	protected void setupComponents4JPanel() {
		lblTotalEmployees = new JLabel("Total Employees:");
		lblTotalEmployees.setBounds(446, 124, 104, 15);
		lblTotalEmployees.setHorizontalAlignment(SwingConstants.RIGHT);
		lblTotalEmployees.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblTotalEmployees);

		lblCompanyName = new JLabel("Company:");
		lblCompanyName.setBounds(30, 117, 69, 29);
		lblCompanyName.setHorizontalAlignment(SwingConstants.RIGHT);
		lblCompanyName.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblCompanyName);

		txtFieldCN = new JTextField();
		txtFieldCN.setBounds(109, 128, 131, 21);
		txtFieldCN.setColumns(10);
		txtFieldCN.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldCN);

		txtFieldEN = new JTextField();
		txtFieldEN.setBounds(560, 125, 96, 21);
		txtFieldEN.setColumns(10);
		txtFieldEN.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldEN);

		separator = new JSeparator();
		separator.setBounds(30, 183, 626, 2);
		separator.setOpaque(true);
		separator.setForeground(Color.GREEN);
		separator.setBackground(new Color(75, 0, 130));
		contentPane.add(separator);

		lblEarnings = new JLabel("Earnings:");
		lblEarnings.setBounds(30, 215, 69, 29);
		lblEarnings.setBorder(new TitledBorder(null, "", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		lblEarnings.setOpaque(true);
		lblEarnings.setHorizontalAlignment(SwingConstants.RIGHT);
		lblEarnings.setFont(new Font("Times New Roman", Font.BOLD | Font.ITALIC, 14));
		lblEarnings.setBackground(new Color(250, 250, 210));
		contentPane.add(lblEarnings);

		txtFieldEarnings = new JTextField();
		txtFieldEarnings.setBounds(109, 219, 96, 21);
		txtFieldEarnings.setColumns(10);
		txtFieldEarnings.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldEarnings);

		lblSSN = new JLabel("SSN:");
		lblSSN.setBounds(30, 294, 69, 29);
		lblSSN.setHorizontalAlignment(SwingConstants.RIGHT);
		lblSSN.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblSSN);

		txtFieldSSN = new JTextField();
		txtFieldSSN.setBounds(109, 298, 96, 21);
		txtFieldSSN.setColumns(10);
		txtFieldSSN.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldSSN);

		lblFirstName = new JLabel("First Name:");
		lblFirstName.setBounds(30, 324, 69, 29);
		lblFirstName.setHorizontalAlignment(SwingConstants.RIGHT);
		lblFirstName.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblFirstName);

		txtFieldFN = new JTextField();
		txtFieldFN.setBounds(109, 328, 96, 21);
		txtFieldFN.setColumns(10);
		txtFieldFN.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldFN);

		lblLastName = new JLabel("Last Name:");
		lblLastName.setBounds(30, 359, 69, 29);
		lblLastName.setHorizontalAlignment(SwingConstants.RIGHT);
		lblLastName.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblLastName);

		txtFieldLN = new JTextField();
		txtFieldLN.setBounds(109, 363, 96, 21);
		txtFieldLN.setColumns(10);
		txtFieldLN.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldLN);

		lblEmpCounter = new JLabel("Employee Counter:");
		lblEmpCounter.setBounds(446, 257, 104, 29);
		lblEmpCounter.setHorizontalAlignment(SwingConstants.RIGHT);
		lblEmpCounter.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblEmpCounter);

		txtFieldEmpCounter = new JTextField();
		txtFieldEmpCounter.setBounds(560, 261, 96, 21);
		txtFieldEmpCounter.setEditable(false);
		txtFieldEmpCounter.setColumns(10);
		txtFieldEmpCounter.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldEmpCounter);

		lblHighestEarnings = new JLabel("Highest Earnings:");
		lblHighestEarnings.setBounds(446, 291, 104, 29);
		lblHighestEarnings.setHorizontalAlignment(SwingConstants.RIGHT);
		lblHighestEarnings.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblHighestEarnings);

		txtFieldHighestE = new JTextField();
		txtFieldHighestE.setBounds(560, 295, 96, 21);
		txtFieldHighestE.setEditable(false);
		txtFieldHighestE.setColumns(10);
		txtFieldHighestE.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldHighestE);

		lblLowestEarnings = new JLabel("Lowest Earnings:");
		lblLowestEarnings.setBounds(446, 324, 104, 29);
		lblLowestEarnings.setHorizontalAlignment(SwingConstants.RIGHT);
		lblLowestEarnings.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblLowestEarnings);

		txtFieldLowestE = new JTextField();
		txtFieldLowestE.setBounds(560, 328, 96, 21);
		txtFieldLowestE.setEditable(false);
		txtFieldLowestE.setColumns(10);
		txtFieldLowestE.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldLowestE);

		txtFieldAverageE = new JTextField();
		txtFieldAverageE.setBounds(560, 363, 96, 21);
		txtFieldAverageE.setEditable(false);
		txtFieldAverageE.setColumns(10);
		txtFieldAverageE.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		contentPane.add(txtFieldAverageE);

		lblAverageEarnings = new JLabel("Average Earnings:");
		lblAverageEarnings.setBounds(446, 359, 104, 29);
		lblAverageEarnings.setHorizontalTextPosition(SwingConstants.LEFT);
		lblAverageEarnings.setHorizontalAlignment(SwingConstants.RIGHT);
		lblAverageEarnings.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblAverageEarnings);

		separator_1 = new JSeparator();
		separator_1.setBounds(30, 460, 626, 2);
		separator_1.setOpaque(true);
		separator_1.setForeground(Color.GREEN);
		separator_1.setBackground(new Color(75, 0, 130));
		contentPane.add(separator_1);

		lblDistribution = new JLabel("Distribution of Wage-Levels");
		lblDistribution.setBounds(30, 475, 626, 29);
		lblDistribution.setOpaque(true);
		lblDistribution.setHorizontalAlignment(SwingConstants.CENTER);
		lblDistribution.setFont(new Font("Times New Roman", Font.BOLD | Font.ITALIC, 14));
		lblDistribution.setBorder(new BevelBorder(BevelBorder.LOWERED, new Color(255, 0, 0), null, null, null));
		lblDistribution.setBackground(new Color(175, 238, 238));
		contentPane.add(lblDistribution);

		lblAlevel = new JLabel("A_Level  >=");
		lblAlevel.setBounds(239, 514, 69, 29);
		lblAlevel.setHorizontalAlignment(SwingConstants.RIGHT);
		lblAlevel.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblAlevel);

		txtFieldLA = new JTextField();
		txtFieldLA.setBounds(506, 518, 96, 21);
		txtFieldLA.setEditable(false);
		txtFieldLA.setColumns(10);
		txtFieldLA.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		txtFieldLA.setBackground(new Color(255, 228, 225));
		contentPane.add(txtFieldLA);

		lblBlevel = new JLabel("B_Level    =");
		lblBlevel.setBounds(239, 553, 69, 29);
		lblBlevel.setHorizontalAlignment(SwingConstants.RIGHT);
		lblBlevel.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblBlevel);

		txtFieldLB = new JTextField();
		txtFieldLB.setBounds(506, 557, 96, 21);
		txtFieldLB.setEditable(false);
		txtFieldLB.setColumns(10);
		txtFieldLB.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		txtFieldLB.setBackground(new Color(255, 228, 225));
		contentPane.add(txtFieldLB);

		lblClevel = new JLabel("C_Level <=");
		lblClevel.setBounds(239, 586, 69, 29);
		lblClevel.setHorizontalAlignment(SwingConstants.RIGHT);
		lblClevel.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblClevel);

		txtFieldLC = new JTextField();
		txtFieldLC.setBounds(506, 590, 96, 21);
		txtFieldLC.setEditable(false);
		txtFieldLC.setColumns(10);
		txtFieldLC.setBorder(
				new CompoundBorder(new BevelBorder(BevelBorder.RAISED, new Color(255, 175, 175), null, null, null),
						new BevelBorder(BevelBorder.RAISED, new Color(0, 255, 0), null, null, null)));
		txtFieldLC.setBackground(new Color(255, 228, 225));
		contentPane.add(txtFieldLC);

		lblALowerThreshold = new JLabel("");
		lblALowerThreshold.setBounds(345, 514, 119, 29);
		lblALowerThreshold.setBorder(new MatteBorder(1, 1, 1, 1, (Color) new Color(0, 0, 0)));
		lblALowerThreshold.setOpaque(true);
		lblALowerThreshold.setHorizontalAlignment(SwingConstants.CENTER);
		lblALowerThreshold.setForeground(Color.BLACK);
		lblALowerThreshold.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblALowerThreshold.setBackground(new Color(250, 250, 210));
		contentPane.add(lblALowerThreshold);

		lblBLowerThreshold = new JLabel("");
		lblBLowerThreshold.setBounds(345, 551, 33, 29);
		lblBLowerThreshold.setBorder(new MatteBorder(1, 1, 1, 1, (Color) new Color(0, 0, 0)));
		lblBLowerThreshold.setOpaque(true);
		lblBLowerThreshold.setHorizontalAlignment(SwingConstants.CENTER);
		lblBLowerThreshold.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblBLowerThreshold.setBackground(new Color(250, 250, 210));
		contentPane.add(lblBLowerThreshold);

		lblCUpperThreshold = new JLabel("");
		lblCUpperThreshold.setBounds(345, 586, 119, 29);
		lblCUpperThreshold.setBorder(new MatteBorder(1, 1, 1, 1, (Color) new Color(0, 0, 0)));
		lblCUpperThreshold.setOpaque(true);
		lblCUpperThreshold.setHorizontalAlignment(SwingConstants.CENTER);
		lblCUpperThreshold.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblCUpperThreshold.setBackground(new Color(250, 250, 210));
		contentPane.add(lblCUpperThreshold);

		lblBUpperThreshold = new JLabel("");
		lblBUpperThreshold.setBounds(431, 551, 33, 29);
		lblBUpperThreshold.setBorder(new MatteBorder(1, 1, 1, 1, (Color) new Color(0, 0, 0)));
		lblBUpperThreshold.setOpaque(true);
		lblBUpperThreshold.setHorizontalAlignment(SwingConstants.CENTER);
		lblBUpperThreshold.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblBUpperThreshold.setBackground(new Color(250, 250, 210));
		contentPane.add(lblBUpperThreshold);

		lblRange = new JLabel("~");
		lblRange.setBounds(388, 551, 33, 29);
		lblRange.setOpaque(true);
		lblRange.setHorizontalAlignment(SwingConstants.CENTER);
		lblRange.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblRange.setBackground(new Color(250, 250, 210));
		contentPane.add(lblRange);

		lblUnitSymbol = new JLabel("Unit:");
		lblUnitSymbol.setBounds(47, 551, 43, 33);
		lblUnitSymbol.setHorizontalAlignment(SwingConstants.RIGHT);
		lblUnitSymbol.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblUnitSymbol);

		separator_2 = new JSeparator();
		separator_2.setBounds(30, 625, 626, 2);
		separator_2.setOpaque(true);
		separator_2.setForeground(Color.GREEN);
		separator_2.setBackground(new Color(75, 0, 130));
		contentPane.add(separator_2);

		btnCalculate = new JButton("Calculate");
		btnCalculate.setBounds(30, 652, 96, 30);
		btnCalculate.setForeground(Color.BLACK);
		btnCalculate.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnCalculate.setBackground(new Color(135, 206, 250));
		contentPane.add(btnCalculate);

		btnRefresh = new JButton("Refresh");
		btnRefresh.setBounds(560, 652, 96, 30);
		btnRefresh.setForeground(Color.BLACK);
		btnRefresh.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnRefresh.setBackground(new Color(135, 206, 250));
		contentPane.add(btnRefresh);

		btnOutputAll = new JButton("Output to TextArea");
		btnOutputAll.setBounds(162, 652, 167, 30);
		btnOutputAll.setForeground(Color.BLACK);
		btnOutputAll.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnOutputAll.setBackground(new Color(135, 206, 250));
		contentPane.add(btnOutputAll);

		btnOpenFile = new JButton("Open File");
		btnOpenFile.setBounds(30, 706, 96, 30);
		btnOpenFile.setForeground(Color.BLACK);
		btnOpenFile.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnOpenFile.setBackground(new Color(135, 206, 250));
		contentPane.add(btnOpenFile);

//		btnWriteFile = new JButton("Write File");
//		btnWriteFile.setBounds(162, 706, 96, 30);
//		btnWriteFile.setForeground(Color.BLACK);
//		btnWriteFile.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
//		btnWriteFile.setBackground(new Color(135, 206, 250));
//		contentPane.add(btnWriteFile);

		btnReadFile = new JButton("Read File");
		btnReadFile.setBounds(297, 706, 96, 30);
		btnReadFile.setForeground(Color.BLACK);
		btnReadFile.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnReadFile.setBackground(new Color(135, 206, 250));
		contentPane.add(btnReadFile);

//		btnCloseFile = new JButton("Close File");
//		btnCloseFile.setBounds(429, 706, 96, 30);
//		btnCloseFile.setForeground(Color.BLACK);
//		btnCloseFile.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
//		btnCloseFile.setBackground(new Color(135, 206, 250));
//		contentPane.add(btnCloseFile);

		btnPieChartDemo = new JButton("Pie-Chart Demo");
		btnPieChartDemo.setBounds(367, 652, 158, 30);
		btnPieChartDemo.setForeground(Color.BLACK);
		btnPieChartDemo.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnPieChartDemo.setBackground(new Color(135, 206, 250));
		contentPane.add(btnPieChartDemo);

		btnExit = new JButton("Exit");
		btnExit.setBounds(560, 706, 96, 30);
		btnExit.setForeground(Color.BLACK);
		btnExit.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnExit.setBackground(new Color(135, 206, 250));
		contentPane.add(btnExit);

		btnClearRecord = new JButton("Clear Record");
		btnClearRecord.setBounds(215, 219, 127, 30);
		btnClearRecord.setForeground(Color.BLACK);
		btnClearRecord.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnClearRecord.setBackground(new Color(135, 206, 250));
		contentPane.add(btnClearRecord);

		lblResultArea = new JLabel("Results Area");
		lblResultArea.setBounds(446, 218, 210, 29);
		lblResultArea.setHorizontalAlignment(SwingConstants.CENTER);
		lblResultArea.setFont(new Font("Times New Roman", Font.BOLD, 12));
		contentPane.add(lblResultArea);

		separatorResultTop = new JSeparator();
		separatorResultTop.setBounds(446, 215, 210, 3);
		separatorResultTop.setOrientation(SwingConstants.VERTICAL);
		separatorResultTop.setOpaque(true);
		separatorResultTop.setForeground(Color.GREEN);
		separatorResultTop.setBackground(new Color(75, 0, 130));
		contentPane.add(separatorResultTop);

		separatorResultBottom = new JSeparator();
		separatorResultBottom.setBounds(446, 252, 210, 3);
		separatorResultBottom.setOrientation(SwingConstants.VERTICAL);
		separatorResultBottom.setOpaque(true);
		separatorResultBottom.setForeground(Color.GREEN);
		separatorResultBottom.setBackground(new Color(75, 0, 130));
		contentPane.add(separatorResultBottom);

		btnSetProfile = new JButton("Set Profile");
		btnSetProfile.setBounds(30, 72, 210, 30);
		btnSetProfile.setForeground(Color.BLACK);
		btnSetProfile.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnSetProfile.setBackground(new Color(135, 206, 250));
		contentPane.add(btnSetProfile);

		btnClearProfile = new JButton("Clear Profile/Results");
		btnClearProfile.setBounds(446, 72, 210, 30);
		btnClearProfile.setForeground(Color.BLACK);
		btnClearProfile.setFont(new Font("Yu Gothic Light", Font.BOLD, 12));
		btnClearProfile.setBackground(new Color(135, 206, 250));
		contentPane.add(btnClearProfile);

		lblUnit = new JLabel("Thousand");
		lblUnit.setBounds(97, 553, 96, 29);
		lblUnit.setOpaque(true);
		lblUnit.setHorizontalAlignment(SwingConstants.CENTER);
		lblUnit.setFont(new Font("Times New Roman", Font.BOLD, 12));
		lblUnit.setBackground(Color.YELLOW);
		contentPane.add(lblUnit);
	}
	
	public void initializeButtonArray() {
		JButton[] buttonsInitialzed = { btnCalculate, btnRefresh, btnClearRecord, btnSetProfile, btnClearProfile,
				btnOutputAll, btnExit, btnOpenFile, btnReadFile, btnPieChartDemo };
//			, btnWriteFile, btnCloseFile};
		optionButtons = buttonsInitialzed;

		for (int i = 0; i < basicChoices.length; i++) {
			// System.out.print(basicChoices[i].getButtonType());
			optionButtons[i].setText(basicChoices[i].getButtonType()); // Text
			optionButtons[i].setIcon(new ImageIcon((basicChoices[i].getImageIcon())));
		}
	}

	protected void initializeTextFieldArrayList() {
		JTextField[] txtFieldsProfile = { txtFieldCN, txtFieldEN };
		JTextField[] txtFieldsEmployee = { txtFieldSSN, txtFieldFN, txtFieldLN, txtFieldEarnings };
		JTextField[] txtFieldsOutput = { txtFieldEmpCounter, txtFieldLowestE, txtFieldHighestE, txtFieldAverageE,
				txtFieldLA, txtFieldLB, txtFieldLC };

		for (JTextField txtField : txtFieldsProfile) {
			listTxtextFieldsProfileG.add(txtField);
		}

		for (JTextField txtField : txtFieldsEmployee) {
			listTxtextFieldsEmployeeG.add(txtField);
		}

		for (JTextField txtField : txtFieldsOutput) {
			listTxtextFieldsResultsG.add(txtField);
		}
	}

	public void initializeTitleNamesList4JTable() {
		String[] titleNames4Table = { EmployeeRecordIndices_Pan2040.SSN.getRecordIndexType(),
				EmployeeRecordIndices_Pan2040.FIRST_NAME.getRecordIndexType(),
				EmployeeRecordIndices_Pan2040.LAST_NAME.getRecordIndexType() };

		for (String titleName : titleNames4Table) {
			listTitleName4Table.add(titleName);
		}
	}

	public void initializeTitleNamesString4JTable() {
		namesUsed = new String[listTitleName4Table.size()];
		for (int i = 0; i < namesUsed.length; i++) {
			namesUsed[i] = listTitleName4Table.get(i).toString();
		}
	}

	public void add() {
		namesUsed = new String[listTitleName4Table.size()];
		for (int i = 0; i < namesUsed.length; i++) {
			namesUsed[i] = listTitleName4Table.get(i).toString();
		}
	}
	
	public void addJTable2Box() {
		box3.add(tableAggregate);
	}
	
	public EmployeeBaseBook_Pan2040 setBasics2StartBookingEmployee() {
		employeeBook = new EmployeeBaseBook_Pan2040(helper4Employee.CompanyName, helper4Employee.EmployeeNo, true);
		return employeeBook;
	}
	
	public EmployeeBaseJFrame_Pan2040_V4 refreshJFrame() { //app refresh open
		EmployeeBaseJFrame_Pan2040_V4 component = new EmployeeBaseJFrame_Pan2040_V4(employeeType4Jframe);
		
		helper4Employee = new Helper4SuperEmployeeBase_Pan2040(component);
		
		btnController = new BtnController4SuperEmployeeBase_Pan2040(component, null);
		Main_Run(component, employeeType4Jframe, btnController);
		
		return component;
	}//end refreshJFrame
}