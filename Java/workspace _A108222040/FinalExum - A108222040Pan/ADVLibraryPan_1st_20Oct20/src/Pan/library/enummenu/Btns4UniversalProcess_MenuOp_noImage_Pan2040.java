package Pan.library.enummenu;

public enum Btns4UniversalProcess_MenuOp_noImage_Pan2040 {
	
	Process_Data				(1, "Calculate"),
	Refresh						(2, "Refresh"),
	Output_Results				(3, "Output Results"),
	Clear_Record				(4, "Clear Record"),
	Set_Profile					(5, "Set Profile"),
	Clear_Profile_and_Results	(6, "Clear Profile/Results"),
	Exit						(7, "Exit"),
	OpenFile					(8, "Open File"),
	ReadFile					(9, "Read File"),
	WriteFile					(10,"Write File"),
	NEXT_RECORD					(11,"Next Record"),
	ADD_RECORD					(12,"Enter"),
	CloseFile					(13,"Close File"),
	PieChartDemo				(14,"Pie-Chart");
	
	private final int value;
	private final String buttonType;
	
	Btns4UniversalProcess_MenuOp_noImage_Pan2040(int valueOption, String optionType)
	{
		value=valueOption;
		buttonType=optionType;
	}
	
	public int getvalue()
	{
		return value;
	}
	
	public String getButtonType() 
	{
		return buttonType;
	}
	

}
