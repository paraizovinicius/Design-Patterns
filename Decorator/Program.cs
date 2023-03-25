namespace Decorator{
    public class Program{
        static void Main(string[] args)
        {
            // Creates concrete object
            Component componente = new ConcreteComponent();

            // Adds funcionality1
            componente = new DecoratorConcreto1(componente);

            // Adds funcionality2
            componente = new DecoratorConcreto2(componente);

            // Calls the Execute() of decorated object
            Console.WriteLine(componente.Execute());
        }
    }
}
