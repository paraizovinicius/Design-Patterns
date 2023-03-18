
public class Classe3 {

	private double cashInAccount = 60.00; //Dinheiro na conta
	
	public double getCashInAccount() {
		return cashInAccount;
	}
	
	public void decreaseCashInAccont(double cashWithdrawn) {
		cashInAccount -= cashWithdrawn;
	}
	
	public void increaseCashInAccont(double cashDeposit) {
		cashInAccount += cashDeposit;
	}
	
	public boolean haveEnoughMoney(double cashToWithdrawal) {
		
		if(cashToWithdrawal > getCashInAccount()) {
			System.out.println("ERRO: Não tem dinheiro suficiente! Balanço: " + getCashInAccount());
			
			return false;
		} else {
			
			decreaseCashInAccont(cashToWithdrawal);
			System.out.println("Retirada completa! Balanço: " + getCashInAccount());
			return true;
		}
	}
	
	public void makeDeposit(double cashToDeposit) {
		increaseCashInAccont(cashToDeposit);
		System.out.println("Deposito completo! Balanço: " + getCashInAccount());
	}
}






