package Pan.library.enummenu;

public enum Creditlnquiry_MenuOption_Pan2040 {
	// declare contents of enum type
	   OPEN_FILE (0,"Open File...", "./image/openfile.png"),
	   CREDIT_BALANCES (1,"Credit Balances", "./image/CB.png"),
	   DEBIT_BALANCES (2,"Debit Balances", "./image/DB.png"),
	   ZERO_BALANCES (3,"Zero Balances", "./image/zero.png"),
	   PIE_CHART (4,"Pie Chart", "./image/chart.png"),
	   CLOSE_FILE (5,"Close File", "./image/close.png"),
	   EXIT (6,"Exit","./image/exit.png");

	   private final int value; // current menu option
	   private final String optionType;
	   private final String imageIconString;

	   // constructor
	   Creditlnquiry_MenuOption_Pan2040(int valueOption,String optionT,String _imageIconString) 
	   {
		   value = valueOption;
		   optionType = optionT;
		   imageIconString = _imageIconString;
	   }
	   
	   public int getValue()
	   {
		   return value;
	   }
	   public String getOptionType()
	   {
		   return optionType;
	   }
	   public String getImageIcon()
	   {
		   return imageIconString;
	   }
} 
