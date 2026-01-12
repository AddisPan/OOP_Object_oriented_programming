import java.io.Serializable;
public class MyClass implements Serializable
{
    private int number;
    private char letter;
    public MyClass( ){
        number = 0;
        letter = 'A';
    }
    public MyClass(int theNumber, char theLetter){
        number = theNumber;
        letter = theLetter;
    }
    public String toString( ){
        return "Number = "+ number +"  Letter ="+letter;
    }
}

