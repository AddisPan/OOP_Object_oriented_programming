package Pan.polymorphism.employee.menuoption;
import java.awt.Color;
public enum EarningLevelEnum_Pan2040 {
   // declare contents of enum type
	LevelA   (15, "Level A", "A", new Color(255,0,0) ), 
	LevelB   (8, "Level B", "B", new Color(0,255,0) ), 
	LevelC   (0, "Level C", "C", new Color(0,0,255) ),
	UNIT     (1000, "Thousand", "", new Color(255,255,255)), 
	MAX_WORKED_HOURS(80, "max worked hours", "", new Color(255,255,255));

   private final int value; // current menu option
   private final String levelOrUnitType;
   private final String levelCharacter;
   private final Color indexColor;
   
    // constructor
	EarningLevelEnum_Pan2040(int valueOption, String _levelOrUnitType, String _levelCharacter, Color _indexColor) 
	{
		value = valueOption;
		levelOrUnitType = _levelOrUnitType;
		levelCharacter = _levelCharacter;
		indexColor = _indexColor;
	}
	
	public int getValue()
	{
		return value;
	}
	
	public String getLevelType()
	{
		return levelOrUnitType;
	}
	
	public String getLevelCharacter()
	{
		return levelCharacter;
	}
	
	public Color getColor()
	{
		return indexColor;
	}
} 