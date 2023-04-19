namespace TemplateMethod
{
    abstract class AbstractClass
    {
        // The Template Method
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }

        protected void Step1()
        {
            Console.WriteLine("AbstractClass Step 1");
        }

        protected void Step3()
        {
            Console.WriteLine("AbstractClass Step 3");
        }

        // Abstract method that will be implemented by subclasses
        protected abstract void Step2();
    }
}