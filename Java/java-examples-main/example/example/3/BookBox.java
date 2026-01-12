public class BookBox{
   public static void main (String[] args){    
      List_Book ABox = new List_Book();      
      ABox.add (new ABook("PHP5程式設計"));
      ABox.add (new ABook("MySQL資料庫設計"));
      ABox.add (new ABook("PHP5&MySQL架站教學"));
      ABox.add (new ABook("網路架站教學"));
      ABox.add (new ABook("Flash MX2004徹底研究"));      
      System.out.println (ABox); 
   }
}

