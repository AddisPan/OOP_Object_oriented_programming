package Pan.library.checkandvalidation;

import java.util.Scanner;

import jdk.nashorn.internal.ir.WhileNode;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import Pan.library.enummenu.NumberType_MenuOption_Pan2040;

public class InputNumberValidation_GUI_CONSOLE_Pan2040 extends JFrame {

	Scanner input;
	public boolean CONSOLE_ON = false;
	public boolean GUI_ON = true;
	
	private static final long serialVersionUID = 2L;
	public double doubleValue = 0;
	public Number numberValue = 0.0;
	public String stringInput = "";
	
	public static int INT_NumberType = NumberType_MenuOption_Pan2040.INT_NUMBER_TYPE.getValueIndex(),
			DOUBLE_NumberType = NumberType_MenuOption_Pan2040.DOUBLE_NUMBER_TYPE.getValueIndex(),
			FLOAT_NumberType = NumberType_MenuOption_Pan2040.FLOAT_NUMBER_TYPE.getValueIndex();
	public int NumberType = 0;
	private String reminder = "";
	public int intValue = 0;

	public InputNumberValidation_GUI_CONSOLE_Pan2040(boolean ConsoleOn, boolean GuiOn) {
		CONSOLE_ON = ConsoleOn;
		GUI_ON = GuiOn;
		input = new Scanner(System.in);
	}
	
	public InputNumberValidation_GUI_CONSOLE_Pan2040(int _NumberType,boolean ConsoleOn, boolean GuiOn) {
		NumberType = _NumberType;
		CONSOLE_ON = ConsoleOn;
		GUI_ON = GuiOn;
		input = new Scanner(System.in);
	}

	public String validateStringNotEmpty (String KeyS) {
		String stringInput = "";
		boolean check_S = false;
		String Qes = "Please enter" + KeyS + "!";
		
		while (check_S == false) {
			stringInput = JOptionPane.showInputDialog(Qes);
			if (stringInput != null)
				check_S = checkStringNotEmpty(stringInput, KeyS);
			else {
				JOptionPane.showMessageDialog(null, "you just cancel the action!");
				
				System.exit(1);
			}
		}//end while
		return stringInput;
	}// end validateStringNotEmpty
	
	public boolean checkStringNotEmpty(String _stringInput, String KeyS) {
		boolean check_S = false;
		reminder = "Re-input " + KeyS +"(Cannot be Empty !)";
		
		try {
			if (!(_stringInput.isEmpty())) {
				check_S = true;
				stringInput = _stringInput;
			} else {
				throw new Exception();
			}
		} catch (Exception ex) {
			if (GUI_ON) {
				JOptionPane.showMessageDialog(this, "Re-input" + KeyS + "(Cannot be Empty!)", ex.getMessage(),
					      JOptionPane.ERROR_MESSAGE);
			} else {
				System.err.println("\nError in inputing value\n" + reminder);
			}
		}// end try-catch
		return check_S;
	}//end checkStringNotEmpty
	
	public Number validateNumberValueByComparing_2flags(String KeyS, Number thresheldValue, int flagValue1_Equal,
			int flagValue2_notEqual, int _NumberType) {
		String NumberData_String;
		
		boolean check_S_Num = false;
		String Qes = "Please enter" + KeyS +"!";
		
		while (check_S_Num == false) {
			NumberData_String = JOptionPane.showInputDialog(Qes);
			check_S_Num = checkNumberValueByComparing_2flags(NumberData_String, KeyS, thresheldValue, flagValue1_Equal, 
					flagValue2_notEqual, _NumberType);
		}// end while
		return numberValue;
	}// end validateNumberValueByComparing_2flags

	public boolean checkNumberValueByComparing_2flags(String NumberData_String, String KeyS, Number thresheldValue,
			int flagValue1_Equal, int flagValue2_notEqual, int _NumberType) {
		boolean check_S_Num = false;
		
		if ((checkStringNotEmpty(NumberData_String, KeyS)))
		{
			reminder = "";
			try {
				numberValue = parseNumber2TypeNeeded(NumberData_String, _NumberType);
				
				if ((compareNumber(numberValue, thresheldValue.intValue()) == flagValue1_Equal)
						|| (compareNumber(numberValue, thresheldValue) == flagValue2_notEqual)) {
					check_S_Num = true;
				} else {
					if (flagValue2_notEqual == +1)
						reminder = KeyS + "(>= " + thresheldValue + "!)";
					else
						reminder = KeyS + "(<= " + thresheldValue + "!)";
					
					throw new NumberFormatException();
				}
			} catch (NumberFormatException ex) {
				JOptionPane.showMessageDialog(this, "\nPlease re-input" + reminder, ex.getMessage(),
						JOptionPane.ERROR_MESSAGE);
			}//end try-catch
		}
		return check_S_Num;
	}// end checkNumberValueByComparing_2flags
	
	public boolean checkNumberValueInRange_min0P1max0N1(String NumberData_String, String KeyS, Number minValue,
			Number maxValue, int _NumberType) throws NumberFormatException{
		boolean check_S_Num = false;
		
		if ((checkStringNotEmpty(NumberData_String, KeyS)))
		{
			reminder = "Re-Input=>" + KeyS + "\n(between " + minValue + "(>=) and" + maxValue + "(<=)!)";
			try {
				numberValue = parseNumber2TypeNeeded(NumberData_String, _NumberType);
				if (((_NumberType == INT_NumberType) && ((numberValue.intValue() <= maxValue.intValue())
						&& (numberValue.intValue() >= minValue.intValue())))
						|| ((_NumberType == DOUBLE_NumberType) && ((numberValue.doubleValue() <= maxValue.doubleValue())
								&& (numberValue.doubleValue() >= minValue.doubleValue())))
						|| ((_NumberType == FLOAT_NumberType) && ((numberValue.floatValue() <= maxValue.floatValue())
								&& (numberValue.floatValue() >= minValue.floatValue())))){
					check_S_Num = true;
				} else {
					throw new NumberFormatException();
				}
			} catch (NumberFormatException ex) {
				JOptionPane.showMessageDialog(null, reminder, "Error inputing Number value",
						JOptionPane.INFORMATION_MESSAGE);
			}// end try-catch
		}
		return check_S_Num;
	}// end checkNumberValueInRange_min0P1max0N1
	
	public Number validateNumberValueInRange_min0P1mNumberax0N1(String KeyS, Number minValue, Number maxValue,
			int _NumberType){
		String NumberData_String;
		boolean check_S_Num = false;
		String Qes = "Enter/Select" + KeyS + " >> ";
		reminder = "You just clicked on CANCEL button!";
		
		while (check_S_Num == false) {
			NumberData_String = JOptionPane.showInputDialog(Qes);
			if ((NumberData_String != null) && (NumberData_String.length() > 0)) {
				check_S_Num = checkNumberValueInRange_min0P1max0N1(NumberData_String, KeyS, minValue, maxValue, 
						_NumberType);
			} else {
				JOptionPane.showMessageDialog(null, reminder, "CANCELLED", JOptionPane.INFORMATION_MESSAGE);
				
				System.exit(1);
			}
		} // end while
		return numberValue;
	}// end validateNumberValueInRange_min0P1mNumberax0N1
	
	public boolean checkNumberValue(String NumberData_String, String KeyS, int _NumberType)
			throws NumberFormatException{
		boolean check_S_Num = false;
		
		if ((checkStringNotEmpty(NumberData_String, KeyS)))
		{
			reminder = "Re-Input=>" + KeyS;
			try {
				if (_NumberType == INT_NumberType)
					numberValue = Integer.parseInt(NumberData_String);
				else if (_NumberType == DOUBLE_NumberType)
					numberValue = Double.parseDouble(NumberData_String);
				else if (_NumberType == FLOAT_NumberType)
					numberValue = Double.parseDouble(NumberData_String);
				
				check_S_Num = true;
			} catch (NumberFormatException ex) {
				if (GUI_ON)
					JOptionPane.showMessageDialog(null, reminder, "Error in inputing value",
							JOptionPane.INFORMATION_MESSAGE);
				else
					System.err.println("\nError in inputing value\n"+ reminder);
			}//end try-catch
		}
		return check_S_Num;
	}// end checkNumberValue
	
	public Number validateNumberValue(String KeyS, int _NumberType) {
		String NumberData_String = "";
		boolean check_S_Num = false;
		String Qes = "Enter" + KeyS + "!";
		
		while (check_S_Num == false) {
			if (GUI_ON)
				NumberData_String = JOptionPane.showInputDialog(Qes);
			else {
				System.out.print(Qes);
				NumberData_String = input.nextLine();
			}
			check_S_Num = checkNumberValue(NumberData_String, KeyS, _NumberType);
		}// end while
		return numberValue;
	}//end validateNumberValue
	
	public Number validateNumberValueByComparing_1flag(String KeyS, Number thresheldValue, int flagValue,
			int _NumberType) {
		String numberData_String;
		boolean check_S_Num = false;
		String Qes = "Please enter" + KeyS + "!";
		
		while (check_S_Num == false) {
			numberData_String = JOptionPane.showInputDialog(Qes);
			check_S_Num = checkNumberValueByComparing_1flag(numberData_String, KeyS, thresheldValue, flagValue,
					_NumberType);
		}//end while
		return numberValue;
	}// end validateNumberValueByComparing_1flag
	
	public boolean checkNumberValueByComparing_1flag(String NumberData_String, String KeyS, Number thresheldValue,
			int flagValue, int _NumberType)
	{
		boolean check_S_Num = false;
		if ((checkStringNotEmpty(NumberData_String, KeyS)))
		{
			reminder = "\nPlease re-input -->" + KeyS;
			try {
				if (_NumberType == INT_NumberType)
					numberValue = Integer.parseInt(NumberData_String);
				else if (_NumberType == DOUBLE_NumberType)
					numberValue = Double.parseDouble(NumberData_String);
				else if (_NumberType == FLOAT_NumberType)
					numberValue = Float.parseFloat(NumberData_String);
				
				if (compareNumber(numberValue, thresheldValue) == flagValue) {
					check_S_Num = true;
				} else {
					
					if (flagValue == 0)
						reminder += "(= " + thresheldValue + "!)";
					else if (flagValue == 1)
						reminder += "(> " + thresheldValue + "!)";
					else
						reminder += "(< " + thresheldValue + "!)";
					
					JOptionPane.showMessageDialog(null, reminder);
					throw new Exception();
				}
			} catch (Exception ex) {
				if (GUI_ON) {
					JOptionPane.showMessageDialog(this, "\n" + reminder, ex.getMessage(), JOptionPane.ERROR_MESSAGE);
				} else {
					System.err.println("\r\nError in inputing value\n" + reminder);
				}
			}//end try-catch
		}
		return check_S_Num;
	}//end checkNumberValueByComparing_1flag
	
	public int compareNumber (Number a, Number b) {
		if (((a.intValue() < b.intValue())) || ((a.doubleValue() < b.doubleValue()))
				||((a.floatValue() < b.floatValue())))
			return -1;
		else if (((a.intValue() > b.intValue())) || ((a.doubleValue() > b.doubleValue()))
				||((a.floatValue() > b.floatValue())))
			return +1;
		else
			return 0;
	}// end compareNumber
	
	public Number parseNumber2TypeNeeded (String NumberData_String, int _NumberType) {
		Number _numberValue = 0;
		if (_NumberType == INT_NumberType)
			_numberValue = Integer.parseInt(NumberData_String);
		else if (_NumberType == DOUBLE_NumberType)
			_numberValue = Double.parseDouble(NumberData_String);
		else if (_NumberType == FLOAT_NumberType)
			_numberValue = Float.parseFloat(NumberData_String);
		
		return _numberValue;
	}// end parseNumber2TypeNeeded
	
	public Number validateDataValueInRange(String keyString, double minValue, double maxValue, boolean checkFlagMin0,
			boolean checkFlagMax0, int _typeInt){
		Number _numberValue = 0;
		boolean check_S_Num = false;
		boolean isCancel = false;
		String minValueS = "", maxValueS = "";
		
		if (_typeInt == INT_NumberType) {
			minValueS = String.valueOf((int) minValue);
			maxValueS = String.valueOf((int) maxValue);
		} else {
			minValueS = String.valueOf(minValue);
			maxValueS = String.valueOf(maxValue);
		}
		
		String Qes = keyString + "\n(between" + 
				minValueS + (checkFlagMin0 ? "(>=)" : "(>)") + "and" +
				maxValueS + (checkFlagMax0 ? "(<=)!)" : "(<)!)") + "?" ;
		String data_String = "";
		
		while (check_S_Num == false && (!isCancel)) {
			if (CONSOLE_ON) {
				System.out.println(Qes);
				data_String = input.next();
			} else {
				data_String = JOptionPane.showInputDialog(Qes);
				
				if (data_String != null) {
					isCancel = false;
				} else {
					JOptionPane.showMessageDialog(null, "you just cancel the action!");
					isCancel = true;
					
					System.exit(1);
				}
			}
			if (data_String != null) 
				check_S_Num = checkDataValueInRange(data_String, keyString, minValue, maxValue, checkFlagMin0,
						checkFlagMax0, _typeInt);
		}//end while
		if (! isCancel)
			_numberValue = parseNumber2TypeNeeded(data_String, _typeInt);
		else
			return null;
		return _numberValue;
	}// end validateDataValueInRange
	
	public boolean checkNumberValueInRange_min0P1max0N1 (String data_String, String keyString, double minValue,
			double maxValue, boolean checkFlagMin0, boolean checkFlagMax0, int _typeInt) {
		boolean check_S_Num = false;
		NumberType = _typeInt;
		
		check_S_Num = TryCatchInRange(data_String, keyString, minValue, maxValue, checkFlagMin0, checkFlagMax0, 
				_typeInt);
		
		numberValue = 0.0;
		return check_S_Num;
	}// end checkNumberValueInRange_min0P1max0N1
	
	public boolean checkDataValueInRange(String data_String, String keyString, double minValue, double maxValue,
			boolean checkFlagMin0, boolean checkFlagMax0, int _typeInt) {
		boolean check_S_Num = false;
		NumberType = _typeInt;
		
		check_S_Num = TryCatchInRange(data_String, keyString, minValue, maxValue, checkFlagMin0, checkFlagMax0, 
				_typeInt);
		
		numberValue = 0.0;
		return check_S_Num;
	} //end checkDataValueInRange
	
	public boolean TryCatchInRange(String data_String, String keyString, double minValue, double maxValue,
			boolean flagMin0, boolean flagMax0, int _Numbertype) {
		boolean check_S_Num = false;
		reminder = "Re-input/Check" + keyString + "\n(between " + minValue + (flagMin0 ? "(>=)" : "(>) ") + "and"
				+ maxValue + (flagMax0 ? "(<=)!)" : "(<)!");
		
		try {
			numberValue = parseNumber2TypeNeeded(data_String, _Numbertype);
			
			if ((flagMin0 ? (numberValue.doubleValue() >= minValue) : (numberValue.doubleValue() > minValue))
					&& (flagMax0 ? (numberValue.doubleValue() >= minValue) : (numberValue.doubleValue() < maxValue))) {
				check_S_Num = true;
			}
			else {
				throw new Exception();
			}
		} catch (Exception ex) {
			if (CONSOLE_ON)
				System.out.println(ex + "\r\n" + reminder);
			
			if (GUI_ON)
				JOptionPane.showMessageDialog(this, reminder, "Re-input/Check",
						JOptionPane.ERROR_MESSAGE);
		}// try-catch
		return check_S_Num;
	}// end TryCatchInRange
	
	public void judgeTypeInsideTryClause(String dataInString) {
		if (NumberType == INT_NumberType) {
			intValue = Integer.parseInt(dataInString);
			numberValue = intValue;
		} else if (NumberType == DOUBLE_NumberType) {
			doubleValue = Double.parseDouble(dataInString);
			
			numberValue = doubleValue;
		}
	}// end void judgeTypeInsideTryClause
}
