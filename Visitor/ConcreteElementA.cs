using System;
namespace Visitor{
    public class ConcreteElementA : IElement
    {

        public string Propriedade1 { get; set; }
        public string Propriedade2 { get; set; }

        public void Accept(Ivisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }


    }
}