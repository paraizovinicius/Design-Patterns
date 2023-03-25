namespace Decorator{
    public class DecoratorConcreto1 : Decorator
    {
        public DecoratorConcreto1(Component component) : base(component)
        {
        }

        public string Functionality1(){
            int a = 2+2;
            return "\nFunctionality1 added. \n";
        }


        public override string Execute()
        {
            return Functionality1() + base.Execute();
        }

    }
}
