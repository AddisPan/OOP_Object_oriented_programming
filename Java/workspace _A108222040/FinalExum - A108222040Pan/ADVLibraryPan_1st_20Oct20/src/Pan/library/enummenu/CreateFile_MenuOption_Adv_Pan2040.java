package Pan.library.enummenu;

public enum CreateFile_MenuOption_Adv_Pan2040 {
	// declare contents of enum type
	   OPEN_FILE (0,"Save into...","./image/openfile.png"),
	   ADD_RECORD (1,"Enter...","./image/CB.png"),
	   CLOSE_FILE (2,"Close File...","./image/close.png"),
	   EXIT (3,"Exit...","./image/exit.png");

	   private final int value; // current menu option
	   private final String optionType;
	   private final String imageIconString;

	   // constructor
	   CreateFile_MenuOption_Adv_Pan2040(int valueOption,String optionT,String _imageIconString) 
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
