import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Welcome{
	public static void main(String[] agrs) {
		String url = "jdbc:mysql://localhost/company?serverTimezone=UTC";
        String user = "root";
        String password = "322739aa";
        String query = "SELECT * from 員工資料表";
        try {
            Connection   conn =DriverManager.getConnection(url,user,password);
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(query);
            while (rs.next()) {
                System.out.print(rs.getString(1)+"  ");
                System.out.print(rs.getString(2)+"  ");
                System.out.print(rs.getString(3)+"  ");
                System.out.print(rs.getString(4)+"  ");
                System.out.print(rs.getString(5)+"  ");
                System.out.println(rs.getString(6));
            }
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } 
	}
}