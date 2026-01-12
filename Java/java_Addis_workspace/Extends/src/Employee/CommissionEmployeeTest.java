package Employee;

public class CommissionEmployeeTest{
	public static void main(String[] args){
		CommissionEmployee employee = new CommissionEmployee("林小寶", "M9315922",
															 500000, 0.12);
		System.out.println("名子:"+employee.getName());
		System.out.println("編號:"+employee.getid());
		System.out.println("業務金額:"+employee.getGrossSales());
		System.out.println("獎金比率:"+employee.getrateCommission());
		System.out.println("傭金:"+employee.earnings());
		System.out.println();
		System.out.printf("%s\n",employee);
	}
}