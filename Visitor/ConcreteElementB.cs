using System;
namespace Visitor{
    public class ConcreteElementB : IElement
    {

        public string Propriedade1 { get; set; }
        public string Propriedade2 { get; set; }

        public void Accept(Ivisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }


    }
}