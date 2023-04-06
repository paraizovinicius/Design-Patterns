using System;
namespace Visitor{
    public class Program{
        static void Main(string[] args)
        {
            ConcreteElementA elementA = new ConcreteElementA();
            ConcreteElementB elementB = new ConcreteElementB();

            elementA.Propriedade1 = "Property A1";
            elementA.Propriedade2 = "Property A2";
            elementB.Propriedade1 = "Property B1";
            elementB.Propriedade2 = "Property B2";

            ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

            elementA.Accept(visitor1);
            elementA.Accept(visitor2);
            elementB.Accept(visitor1);
            elementB.Accept(visitor2);

            
        }
    }
}