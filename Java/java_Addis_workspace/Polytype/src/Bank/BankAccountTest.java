package Bank;

public class BankAccountTest{
	public static void main(String[] args) {
		System.out.println("開一個銀行帳戶");
		BankAccount account = new BankAccount();
		System.out.println("帳戶存款 = $" + account.getBalance());
		System.out.println("存$50.00");
		account.makeDeposit("50.00");
		System.out.println("帳戶存款 = $" + account.getBalance());
		System.out.println("存$9.99");
		account.makeDeposit("9.99");
		System.out.println("帳戶存款 = $" + account.getBalance());
		System.out.println("存$0.01");
		account.makeDeposit("0.01");
		System.out.println("帳戶存款 = $" + account.getBalance());
		System.out.println("關閉帳戶");
		account.closeAccount();
		System.out.println("帳戶存款 = $" + account.getBalance());
	}
}