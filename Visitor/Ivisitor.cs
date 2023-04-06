using System;
namespace Visitor{
    public interface Ivisitor{
    void VisitConcreteElementA(ConcreteElementA _concreteElementA);
    void VisitConcreteElementB(ConcreteElementB _concreteElementB);
    }
}