package Pan.library.enummenu;

public enum PieChartType_MenuOption_Pan2040 {
   // declare contents of enum type
	INT_NUMBER_TYPE		(1, "INT_NumberType"),
	DOUBLE_NUMBER_TYPE	(2, "DOUBLE_NumberType"),
	FLOAT_NUMBER_TYPE	(3, "FLOAT_NumberType");

   private final int valueIndex; // current menu option
   private final String numberType;

   PieChartType_MenuOption_Pan2040(int _valueIndex, String _numberType)
   {
	   valueIndex = _valueIndex;
	   numberType= _numberType;
   }
	
   public int getValueIndex() 
   {
		return valueIndex;
   }
	
   public String getNumberType()
   {
		return numberType;
   }
} 