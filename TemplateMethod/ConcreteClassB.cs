namespace TemplateMethod
{
    class ConcreteClassB : AbstractClass
    {
        protected override void Step2()
        {
            Console.WriteLine("ConcreteClassB Step 2");
        }
    }
}