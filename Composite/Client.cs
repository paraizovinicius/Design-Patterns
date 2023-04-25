namespace Composite
{
    class Client
    {
        private Component _component;

        public Client(Component component)
        {
            _component = component;
        }

        public void DoOperation()
        {
            _component.Operation();
        }
    }
}

// The Client class encapsulates this structure of composite objects and provides a simple interface 
//to access and manipulate the object structure, regardless of whether it is a composite object or a leaf object