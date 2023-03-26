namespace State{
    public class ConcreteState1 : State
    {
        public void Handle(Context context)
        {
            // Defines the behavior of State 1
            Console.WriteLine("The object is in state 1");
            // Alter the object state
            context.State = new ConcreteState2();
        }
    }
}
