package Employee;

public class PolymorphismTest{
	public static void main(String[] args) {
		CommissionEmployee CommissionEmployee=
				new CommissionEmployee("林小寶","M9425952",300000,0.12);
		BaseCommissionEmployee BaseCommissionEmployee=
				new BaseCommissionEmployee("林小寶","M9425952",300000,0.12,16000);
		System.out.printf("\n%s\n%s\n","外聘員工",CommissionEmployee);
		System.out.printf("\n%s\n%s\n","外聘員工加底薪",BaseCommissionEmployee);
		CommissionEmployee CommissionEmployee1=BaseCommissionEmployee;
		System.out.printf("\n%s\n%s\n","呼叫外聘員工加底薪和父親別的字串化",
				CommissionEmployee1);
	}
}