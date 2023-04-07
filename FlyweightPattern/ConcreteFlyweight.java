public class ConcreteFlyweight implements Flyweight {

    private String key;

    public ConcreteFlyweight(String key) {
        this.key = key;
    }

    public void Operation() {
        System.out.println("Operation X finished for key " + key);
    }
}