
public class MotifWidgetFactory extends WidgetFactory{
    
    public Scrollbar createScrollBar(){
        return new MotifScrollBar();
    }

    public Window createWindow(){
        return new MotifWindow();
    }
}
