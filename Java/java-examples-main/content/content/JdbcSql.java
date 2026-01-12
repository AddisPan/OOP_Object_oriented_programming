package welcome;
import java.sql.Connection; 
import java.sql.DriverManager; 
import java.sql.PreparedStatement; 
import java.sql.ResultSet; 
import java.sql.SQLException; 
import java.sql.Statement; 


public class JdbcSql {
	
	 private Connection con = null; //Database objects 
	  //連接object 
	  private Statement stat = null; 
	  //執行,傳入之sql為完整字串 
	  private ResultSet rs = null; 
	  //結果集 
	  private PreparedStatement pst = null; 
	  //執行,傳入之sql為預儲之字申,需要傳入變數之位置 
	  //先利用?來做標示 
	  String url2 ="jdbc:sqlserver://localhost:1433;databaseName=temp";
	  private String dropdbSQL = "DROP TABLE User1;"; 
	  
	  private String createdbSQL = "CREATE TABLE User1(id INTEGER,name CHAR(20),passwd CHAR(20));"; 
	  
	  private String insertdbSQL = "insert into User1(id,name,passwd) " + 
	      "select iSNULL(max(id),0)+1,?,? FROM User1"; 
	  
	  private String selectSQL = "select * from User1 "; 
	  
	  public JdbcSql() 
	  { 
	    try { 
	      Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver"); 
	      //註冊driver 
	      con = DriverManager.getConnection(url2, "Ivy","322739aa"); 
	      //取得connection
	      
	    } 
	    catch(ClassNotFoundException e) 
	    { 
	      System.out.println("DriverClassNotFound :"+e.toString()); 
	    }//有可能會產生sqlexception 
	    catch(SQLException x) { 
	      System.out.println("Exception :"+x.toString()); 
	    } 
	    
	  } 
	  //建立table的方式 
	  //可以看看Statement的使用方式 
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
	  //新增資料 
	  //可以看看PrepareStatement的使用方式 
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
	  //刪除Table, 
	  //跟建立table很像 
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
	  //查詢資料 
	  //可以看看回傳結果集及取得資料方式 
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
	  //完整使用完資料庫後,記得要關閉所有Object 
	  //否則在等待Timeout時,可能會有Connection poor的狀況 
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
	    JdbcSql sqlcon = new JdbcSql(); 
	    sqlcon.dropTable(); 
	    sqlcon.createTable(); 
	    sqlcon.insertTable("justinwu","322739aa"); 
	    sqlcon.insertTable("Ivy Lin", "353766aa"); 
	    sqlcon.SelectTable(); 

	}

}
