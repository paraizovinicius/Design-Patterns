namespace State{
    public class Program{
        static void Main(string[] args)
        {
            // Creates object of context with initial state 1
            Context context = new Context(new ConcreteState1()); //We're creating a 'context' object witch already has a defined initial state. And this state is a 'ConcreteState1' object
            
            // Executes behaviour of current state
            context.Request(); // Output: Object is in state 1

            // Alter object's state to 2 and executes current state's behaviour
            context.Request(); // Output: Object is in state 2

            // Alter the object's state to 1 and executes current state's behaviour
            context.Request(); // Output: Object is in state 1
        }
    }
}