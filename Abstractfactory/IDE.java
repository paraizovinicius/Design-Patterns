
public class IDE {
    
    private Window w;
    private Scrollbar sb;

    public IDE(WidgetFactory wf){
        setLayout(wf);
    }


    public void setLayout(WidgetFactory wf){
        w = wf.createWindow();
        sb = wf.createScrollBar();
        drawApp();
    }

    public void drawApp(){
        w.draw();
        sb.draw();
    }

}
