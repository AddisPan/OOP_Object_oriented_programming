import java.sql.Connection; 
import java.sql.DriverManager; 
import java.sql.PreparedStatement; 
import java.sql.ResultSet; 
import java.sql.SQLException; 
import java.sql.Statement; 

public class JdbcMysql {
	
	  private Connection con = null; //Database objects 
	  private Statement stat = null; 
	  private ResultSet rs = null; //結果集 
	  private PreparedStatement pst = null; 
	  private String dropdbSQL = "DROP TABLE User "; 
	  
	  private String createdbSQL = "CREATE TABLE User (" + 
	    "    id     INTEGER " + "  , name    VARCHAR(20) " + 
	    "  , passwd  VARCHAR(20))"; 
	  private String insertdbSQL = "insert into User(id,name,passwd) " + 
	      "select ifNULL(max(id),0)+1,?,? FROM User"; 
	  private String selectSQL = "select * from User "; 
	  private String temp ="jdbc:mysql://localhost/temp?serverTimezone=UTC&";
	  private String connect = temp + "useUnicode=true&&useSSL=false";
	  public JdbcMysql() 
	  { 
	    try { 
	      Class.forName("com.mysql.cj.jdbc.Driver"); //註冊driver 
	      con = DriverManager.getConnection(connect,"root","322739aa"); 
	    } 
	    catch(ClassNotFoundException e) 
	    { 
	      System.out.println("DriverClassNotFound :"+e.toString()); 
	    }//有可能會產生sqlexception 
	    catch(SQLException x) { 
	      System.out.println("Exception :"+x.toString()); 
	    }  
	  } 
	  public void createTable() 
	  { 
	    try 
	    { 
	      stat = con.createStatement(); 
	      stat.executeUpdate(createdbSQL); 
	    } 
	    catch(SQLException e) 
	    { 
	      System.out.println("CreateDB Exception :" + e.toString()); 
	    } 
	    finally 
	    { 
	      Close(); 
	    } 
	  } 
	  public void insertTable( String name,String passwd) 
	  { 
	    try 
	    { 
	      pst = con.prepareStatement(insertdbSQL); 
	      
	      pst.setString(1, name); 
	      pst.setString(2, passwd); 
	      pst.executeUpdate(); 
	    } 
	    catch(SQLException e) 
	    { 
	      System.out.println("InsertDB Exception :" + e.toString()); 
	    } 
	    finally 
	    { 
	      Close(); 
	    } 
	  } 
	  public void dropTable() 
	  { 
	    try 
	    { 
	      stat = con.createStatement(); 
	      stat.executeUpdate(dropdbSQL); 
	    } 
	    catch(SQLException e) 
	    { 
	      System.out.println("DropDB Exception :" + e.toString()); 
	    } 
	    finally 
	    { 
	      Close(); 
	    } 
	  } 
	  public void SelectTable() 
	  { 
	    try 
	    { 
	      stat = con.createStatement(); 
	      rs = stat.executeQuery(selectSQL); 
	      System.out.println("ID\t\tName\t\tPASSWORD"); 
	      while(rs.next()) 
	      { 
	        System.out.println(rs.getInt("id")+"\t\t"+ 
	            rs.getString("name")+"\t\t"+rs.getString("passwd")); 
	      } 
	    } 
	    catch(SQLException e) 
	    { 
	      System.out.println("DropDB Exception :" + e.toString()); 
	    } 
	    finally 
	    { 
	      Close(); 
	    } 
	  } 
	  private void Close() 
	  { 
	    try 
	    { 
	      if(rs!=null) 
	      { 
	        rs.close(); 
	        rs = null; 
	      } 
	      if(stat!=null) 
	      { 
	        stat.close(); 
	        stat = null; 
	      } 
	      if(pst!=null) 
	      { 
	        pst.close(); 
	        pst = null; 
	      } 
	    } 
	    catch(SQLException e) 
	    { 
	      System.out.println("Close Exception :" + e.toString()); 
	    } 
	  }   
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
	    //測看看是否正常 
	    JdbcMysql sqlcon = new JdbcMysql(); 
	    sqlcon.dropTable(); 
	    sqlcon.createTable(); 
	    sqlcon.insertTable("justinwu","322739aa"); 
	    sqlcon.insertTable("Ivy Lin","353766aa"); 
	    sqlcon.SelectTable(); 

	}

}
