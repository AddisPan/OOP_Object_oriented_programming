package Pan.library.enummenu;

public enum FileStramType_MenuOption_Pan2040 {
	
	CHARACTER_BASED		(0, "CHARACTER_BASED"),
	BYTE_BASED			(1, "BYTE_BASED"),
	STANDARD_BASED		(2, "TEXT_BASED"),
	EXIT				(3, "Exit");
	
	
	private final int value;
	private final String optionType;
	
	FileStramType_MenuOption_Pan2040(int valueOption, String optionT)
	{
		value=valueOption;
		optionType= optionT;
	}
	
	public int getValue() 
	{
		return value;
	}
	
	public String getOptionType()
	{
		return optionType;
	}

}
