package welcome;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class SQLDatabaseConnection {
    // Connect to your database.
    // Replace server name, username, and password with your credentials
    public static void main(String[] args) {
    	String url ="jdbc:sqlserver://localhost:1433;databaseName=temp";

        try{
            // Code here.
        	Connection connection = DriverManager.getConnection(url,"Ivy","322739aa");
        	System.out.println("Ok");
        }
        // Handle any errors that may have occurred.
        catch (SQLException e) {
            e.printStackTrace();
        }
    }
}