using System;
using System.Collections.Generic;
namespace Composite{
    class ConcreteComponent : Component{
        
        protected List<Component> _children = new List<Component>();

        public void Operation(){
            Console.WriteLine("\nComposite Operation");
            foreach(var child in _children){
                child.Operation();
            }
        }
        public void Add(Component component){
            this._children.Add(component);
        }
        public void Remove(Component component){
            this._children.Remove(component);
        }

    }
}