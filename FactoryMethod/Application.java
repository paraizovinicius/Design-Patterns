
public abstract class Application {
	
	public abstract Document createDocument();
	
	public void newDocument() {
		Document d = createDocument(); //desta maneira, conseguimos instanciar uma classe abstrata
		d.open();
	}

}
