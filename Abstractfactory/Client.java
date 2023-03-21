
public class Client {
    
    public static void main(String[] args) {
        IDE ide = new IDE(new MotifWidgetFactory());

        ide.setLayout(new PMWidgetFactory());
    }
}
