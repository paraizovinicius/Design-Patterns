
public class PMWidgetFactory extends WidgetFactory{
    
    public Scrollbar createScrollBar(){
        return new PMScrollBar();
    }

    public Window createWindow(){
        return new PMWindow();
    }
}
