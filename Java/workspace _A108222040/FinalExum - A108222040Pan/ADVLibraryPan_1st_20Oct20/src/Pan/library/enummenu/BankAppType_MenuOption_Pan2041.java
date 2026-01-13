package Pan.library.enummenu;

public enum BankAppType_MenuOption_Pan2041 {
   // declare contents of enum type
   CREATE_ACCOUNT (0,"Create Account"),
   READ_ACCOUNT (1,"Read Account"),
   INQUIRE_CREDIT (2,"Inquire Credit"),
   QUIT (3,"Quit");

   private final int value; // current menu option
   private final String bankAppType;

   // constructor
   BankAppType_MenuOption_Pan2041(int valueOption,String optionType) 
   {
	   value = valueOption;
	   bankAppType = optionType;
   }
   
   public int getvalue()
   {
	   return value;
   }
   public String getbankAppType()
   {
	   return bankAppType;
   }
} 
