import javax.swing.JOptionPane;
public class Depositeasset{
	public static void main(String[] args){
		Name name=new Name("吳佳諺");
		Address address=new Address("台北市","大安區","復興南路二段","","199號");
		Asset asset=new Asset(1.05,3,1000000);
		Depositor depositor=new Depositor(name,address);
		depositor.setasset(asset);
		JOptionPane.showMessageDialog(null,depositor.toString());
	}

}