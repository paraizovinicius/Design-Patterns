using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;
namespace Composite{
    class Leaf1 : Component{
    public void Operation(){
        Console.WriteLine("Leaf Operation");
    }

    public void Add(Component component){
        throw new NotImplementedException();
    }

    public void Remove(Component component){
        throw new NotImplementedException();
    }

}

}