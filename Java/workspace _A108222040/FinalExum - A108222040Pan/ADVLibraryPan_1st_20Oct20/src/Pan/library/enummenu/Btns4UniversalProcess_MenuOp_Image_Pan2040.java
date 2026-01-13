package Pan.library.enummenu;

public enum Btns4UniversalProcess_MenuOp_Image_Pan2040 {
	
	Process_Data				(1, "Calculate","./img/SetProfile.png"),
	Refresh						(2, "Refresh","./img/Refresh.png"),
	Output_Results				(3, "Output Results","./img/Output.png"),
	Clear_Record				(4, "Clear Record","./img/Clear.png"),
	Set_Profile					(5, "Set Profile","./img/SetProfile.png"),
	Clear_Profile_and_Results	(6, "Clear Profile/Results","./img/Clear.png"),
	Exit						(7, "Exit","./img/exit.png"),
	OpenFile					(8, "Open File","./img/openfile.png"),
	ReadFile					(9, "Read File","./img/Read.png"),
	WriteFile					(10,"Write File","./img/openfile.png"),
	NEXT_RECORD					(11,"Next Record","./img/openfile.png"),
	ADD_RECORD					(12,"Enter","./img/openfile.png"),
	CloseFile					(13,"Close File","./img/openfile.png"),
	PieChartDemo				(14,"Pie-Chart","./img/chart.png");
	
	private final int value;
	private final String buttonType;
	private final String imageIconString;
	
	Btns4UniversalProcess_MenuOp_Image_Pan2040(int valueOption, String optionType, String _imageIconString)
	{
		value=valueOption;
		buttonType=optionType;
		imageIconString = _imageIconString;
	}
	
	public int getvalue()
	{
		return value;
	}
	
	public String getButtonType() 
	{
		return buttonType;
	}
	
	public String getImageIcon() 
	{
		return imageIconString;
	}
}
