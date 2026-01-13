package Pan.polymorphism.employee.earningbook;

import Pan.polymorphism.employee.menuoption.EarningLevelEnum_Pan2040;
import Pan.polymorphism.employee.CommissionEmployee;
import java.awt.Color;
import java.text.DecimalFormat;

public class BasePlusCommissionEmployeeBaseBook_Pan2040 {
	static private DecimalFormat twoDigits = new DecimalFormat("0.00");
	
	public String finalReport4WageBook = "";
	public String header4WageBook = 
			"\r\n\t@________________________________________________________@\n\n"
		+   "\r\n\t\t                Wage-Book Report for the Company         \n\n"
		+   "\r\n\t@________________________________________________________@\n";
	
	public String formatTitle4EmployeeBook = String.format("            \t%15s\t%15s\t%15s\t", "FirstN", "LastN", "SSN");
	
	public String formatTitleConsole = "";
	public String formatTitleGUI = "";
	public String recordsConcatenated = "";
	
	public int employeeCounter = 0;
	public double total = 0.0, highestE = Double.MIN_VALUE, lowestE = Double.MAX_VALUE, mean = 0.0;
	public String nameLowest, nameHighest;
	public String SSNlowest = "", SSNhighest = "";
	
	public int aLevel = 0, bLevel = 0, cLevel = 0;
	
	public String[] levelsS = {EarningLevelEnum_Pan2040.LevelA.getLevelType(), EarningLevelEnum_Pan2040.LevelB.getLevelType(),
			EarningLevelEnum_Pan2040.LevelC.getLevelType()};
	
	public double[] levelsV = new double[levelsS.length];
	
	public Color indexColor = EarningLevelEnum_Pan2040.LevelA.getColor();
	
	public double unitNT = 1000;
	
	//Below are Properties used
	public String CompanyName;
	
	public int EmployeeNo;
	public String LevelLetter;
	public boolean isGUI;
	public  BasePlusCommissionEmployeeBaseBook_Pan2040(String _companyName,int _employeeNo,boolean _isGUI) 
	{
		CompanyName = _companyName;
		EmployeeNo = _employeeNo;
		
		isGUI = _isGUI;
		
		header4WageBook += String.format("\r\nCompany: %s\nEmploy No: %3d\t\r\n", CompanyName, EmployeeNo);
	}

	public void processEverySalaryProfile(CommissionEmployee record) 
	{
		recordsConcatenated += record; //null String
		
		calculateTotal(record.earnings());
		LevelLetter = incrementLetterGradeLevelCounter(record.earnings());
		findHighest(record);
		findLowest(record);
		
		record.setLevel(LevelLetter); //difrerent level
		record.setColor(indexColor); //different color
		
		employeeCounter += 1;
	} //end processEverySalaryProfile
	
	public void calculateTotal(double _everyEarnings) 
	{
		total += _everyEarnings;
	} 
	
	public void findHighest(CommissionEmployee record) 
	{
		if (record.earnings() > highestE) {
			highestE = record.earnings();
			nameHighest = record.getFirstName() + " " + record.getLastName();
			SSNhighest = record.getSocialSecurityNumber();
		}
	}
	
	public void findLowest(CommissionEmployee record) 
	{
		if (record.earnings() < lowestE) {
			lowestE = record.earnings();
			nameLowest = record.getFirstName() + " " + record.getLastName();
			SSNlowest = record.getSocialSecurityNumber();
		}
	} 
	
	public String incrementLetterGradeLevelCounter(double wage) 
	{
		String levelS = "";
		int wageInt = (int) (wage / EarningLevelEnum_Pan2040.UNIT.getValue());
		
		if (wageInt >= EarningLevelEnum_Pan2040.LevelA.getValue()) {
			levelS = EarningLevelEnum_Pan2040.LevelA.getLevelCharacter();
			indexColor = EarningLevelEnum_Pan2040.LevelA.getColor();
			++aLevel;
		}else if (wageInt >= EarningLevelEnum_Pan2040.LevelB.getValue()) {
			levelS = EarningLevelEnum_Pan2040.LevelB.getLevelCharacter();
			indexColor = EarningLevelEnum_Pan2040.LevelB.getColor();
			++bLevel;
		}else {
			levelS = EarningLevelEnum_Pan2040.LevelC.getLevelCharacter();
			indexColor = EarningLevelEnum_Pan2040.LevelC.getColor();
			++cLevel;
		}
		return levelS;
	} 
	
	public void calculateAverageNproduceLevelArray() 
	{
		mean = total / EmployeeNo;
		produceLevelArray();
	} 
	
	public void produceLevelArray() 
	{
		levelsV[0] = (double) (aLevel);
		levelsV[1] = (double) (bLevel);
		levelsV[2] = (double) (cLevel);
	} 
	
	public String toString() 
	{
		finalReport4WageBook = "";
		
		finalReport4WageBook = finalReport4WageBook + header4WageBook;
		
		if (isGUI)
			
			finalReport4WageBook += "\r\n\t@________________________________________________________@\n";
		else
			finalReport4WageBook += "\r\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n";
		
		finalReport4WageBook += "\r\n\r\nSalary average for this week: " + twoDigits.format(mean);
		finalReport4WageBook += "\r\nLowest Salary: " + twoDigits.format(lowestE);
		finalReport4WageBook += "\tName: " + nameLowest;
		finalReport4WageBook += "\r\nHighest Salary: " + twoDigits.format(highestE);
		finalReport4WageBook += "\tName" + nameHighest;
		
		finalReport4WageBook += String.format("\r\n\r\n%s\n\tA: %3d\r\n\tB: %3d\r\n\tC: %3d\r\n\r\n",
				"No. of employees who earned in each level:\r\n", aLevel, bLevel, cLevel);
		
		
		return finalReport4WageBook;
	} 
}
