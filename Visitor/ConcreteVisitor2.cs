using System;
namespace Visitor{
    public class ConcreteVisitor2 : Ivisitor{

        public void VisitConcreteElementA(ConcreteElementA _concreteElementA){
            Console.WriteLine("\nVisitor 2 enters and does something to A");
        }
        public void VisitConcreteElementB(ConcreteElementB _concreteElementB){
            Console.WriteLine("\nVisitor 2 enters and does something to B");
        }

    }
}