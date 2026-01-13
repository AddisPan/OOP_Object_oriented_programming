package Pan.library.enummenu;

public enum BankAccount_TxtFieldEnumAdv_Pan2040 {
	// declare contents of enum type
	   ACCOUNT_NO (0,"Account-number"),
	   FIRST_NAME (1,"First-name"),
	   LAST_NAME (2,"Last-name"),
	   CELL_PHONE (3,"Cell-Phone"),
	   EMAIL (4,"e-mail"),
	   BALANCE (5,"Balance");

	   private final int fieldValue; // current menu option
	   private final String fieldType;

	   // constructor
	   BankAccount_TxtFieldEnumAdv_Pan2040(int _fieldValue,String _fieldType) 
	   {
		   fieldValue = _fieldValue;
		   fieldType = _fieldType;
	   }
	   
	   public int getFieldValue()
	   {
		   return fieldValue;
	   }
	   public String getFieldType()
	   {
		   return fieldType;
	   }
} 
