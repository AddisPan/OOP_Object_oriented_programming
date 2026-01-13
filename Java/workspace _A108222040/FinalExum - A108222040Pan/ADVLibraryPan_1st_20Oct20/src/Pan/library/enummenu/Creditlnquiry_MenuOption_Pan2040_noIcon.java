package Pan.library.enummenu;

public enum Creditlnquiry_MenuOption_Pan2040_noIcon {
	// declare contents of enum type
	   OPEN_FILE (0,"Open File..."),
	   CREDIT_BALANCES (1,"Credit Balances"),
	   DEBIT_BALANCES (2,"Debit Balances"),
	   ZERO_BALANCES (3,"Zero Balances"),
	   PIE_CHART (4,"Pie Chart"),
	   CLOSE_FILE (5,"Close File"),
	   EXIT (6,"Exit");

	   private final int value; // current menu option
	   private final String optionType;

	   // constructor
	   Creditlnquiry_MenuOption_Pan2040_noIcon(int valueOption,String optionT) 
	   {
		   value = valueOption;
		   optionType = optionT;
	   }
	   
	   public int getValue()
	   {
		   return value;
	   }
	   public String getOptionType()
	   {
		   return optionType;
	   }
} //end enum Creditlnquiry_MenuOption_Pan2040_noIcon
