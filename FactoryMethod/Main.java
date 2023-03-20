import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
      	int input = -1;
		

		while (input != 0) {
			System.out.println("Digite um numero (0 para sair): ");
			input = scanner.nextInt();

			if (input == 1){
				Application app = new ExcelApplication();
				app.newDocument();
			}

			if (input == 2){
				Application app2 = new WordApplication();
				app2.newDocument();
			}
		}
		scanner.close();
	}
	

}
