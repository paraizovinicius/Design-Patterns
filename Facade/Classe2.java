
public class Classe2 {

	private int securityCode = 123;
	
	public int getSecurityCode() {
		return securityCode;
	}
	
	public boolean isCodeCorrect(int secCodeToCheck) {
		if(secCodeToCheck == getSecurityCode()){
			return true;
			} else {
				return false;
			}
		}
}
