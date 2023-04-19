namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an Instance of ConcreteClassA and calling the templateMethod
            AbstractClass objA = new ConcreteClassA();
            objA.TemplateMethod();

            Console.WriteLine();

            // Creating an Instance of ConcreteClassB and calling the templateMethod
            AbstractClass objB = new ConcreteClassB();
            objB.TemplateMethod();

            Console.ReadLine();
        }
    }
}