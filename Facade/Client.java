
public class Client {

	public static void main(String[] args) {
		
		Facade accessingBank = new Facade(123456, 123);
		
		accessingBank.withdrawCash(50.00);
		accessingBank.depositCash(300.00);

	}

}
