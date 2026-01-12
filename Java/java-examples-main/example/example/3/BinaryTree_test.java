public class BinaryTree_test{
  public static void main(String[] args) {
    BinaryTree tree = new BinaryTree();
    tree.insert("PHP5程式設計");
    tree.insert("MySQL資料庫設計");
    tree.insert("PHP5&MySQL架站教學");
    tree.insert("網路架站教學");
    tree.insert("Flash MX2004徹底研究");
    tree.insert("Linux徹底研究");
    System.out.print("Preorder: ");
    tree.preorder();
    System.out.print("\n\nInorder: ");
    tree.inorder();
    System.out.print("\n\nPostorder: ");
    tree.postorder();
    System.out.print("\n");
  }
}