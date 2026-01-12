public class List_Book{
   private BookNode list;
   public List_Book(){
      list = null;
   }
   public void add (ABook mag){
      BookNode node = new BookNode (mag);
      BookNode current;
      if (list == null){
         list = node;
      }else{
         current = list;
         while (current.next != null)
            current = current.next;
         current.next = node;
      }
   }
   public String toString (){
      String result = "";
      BookNode current = list;
      while (current != null){
         result += current.aBook + "\n";
         current = current.next;
      }
      return result;
   }
   private class BookNode{
      public ABook aBook;
      public BookNode next;
      public BookNode(ABook mag){
         aBook = mag;
         next = null;
      }
   }
}


