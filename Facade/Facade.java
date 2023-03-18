
public class Facade { //Essa classe centraliza uma s�rie de 'fun��es' que devem ser feitas para cada opera��o em TestBankAccount
	
	private int accountNumber;
	
	private int securityCode;
	
	Classe1 checarConta;
	Classe2 checarCodigo;
	Classe3 checarFundos;
	
	public Facade(int newAcctNum, int newSecCode) {
		accountNumber = newAcctNum; //123456
		securityCode = newSecCode; //123
		
		//inicializar os objetos
		checarConta = new Classe1(); //Checar a conta
		checarCodigo = new Classe2(); //Checar o codigo de seguran�a
		checarFundos = new Classe3(); //Checar os fundos da conta
	}
	
	public int getAccountNumber() { return accountNumber;}
	public int getSecurityCode() { return securityCode;}
	
	public void withdrawCash(double cashToGet) {
		if(checarConta.accountActive(getAccountNumber()) &&
				checarCodigo.isCodeCorrect(getSecurityCode()) &&
				checarFundos.haveEnoughMoney(cashToGet)) {
			System.out.println("\nTransação COMPLETA\n");
		} else {
			System.out.println("\nTransação FALHOU\n");
		}
	}
	
	public void depositCash(double cashToDeposit) {
		if(checarConta.accountActive(getAccountNumber()) &&
				checarCodigo.isCodeCorrect(getSecurityCode())) {
			
			checarFundos.makeDeposit(cashToDeposit);
			System.out.println("\nTransação COMPLETA\n");
		} else {
			System.out.println("\nTransação FALHOU\n");
		}
	}

}
