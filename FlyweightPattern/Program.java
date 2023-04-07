
public class Program {

    public static void main(String[] args) {
        FlyweightFactory factory = new FlyweightFactory();
    
        Flyweight flyweight1 = factory.GetFlyweight("Key1");
        Flyweight flyweight2 = factory.GetFlyweight("Key1");

        flyweight1.Operation();
        flyweight2.Operation(); //As we have 2 objects using the same key, it'll trigger the conditional in GetFlyweight

        Flyweight flyweight3 = factory.GetFlyweight("Key2");
        flyweight3.Operation();
    
    }
    
}
