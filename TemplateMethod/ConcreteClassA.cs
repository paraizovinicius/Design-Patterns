namespace TemplateMethod
{
    class ConcreteClassA : AbstractClass
    {
        protected override void Step2()
        {
            Console.WriteLine("ConcreteClassA Step 2");
        }
    }
}