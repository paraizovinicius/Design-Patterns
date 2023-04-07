import java.util.HashMap;
import java.util.Map;

public class FlyweightFactory {

    private Map<String, Flyweight> flyweights = new HashMap<>();

    public Flyweight GetFlyweight(String key) {
        Flyweight flyweight = flyweights.get(key);
        if (flyweight != null) {
            System.out.println("\nFlyweight already exists for key " + key);
            return flyweight;
        } else {
            flyweight = new ConcreteFlyweight(key);
            flyweights.put(key, flyweight);
            return flyweight;
        }
    }
}