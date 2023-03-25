namespace Decorator{
    public class DecoratorConcreto2 : Decorator
    {
        public DecoratorConcreto2(Component component) : base(component) {
        }

        public string Functionality2(){
            int a = 1+1;
            return "\nFunctionality2 added. \n";
        }


        public override string Execute()
        {
            return Functionality2() + base.Execute();
        }

    }
}
