using System;
namespace Visitor{
    public interface IElement
    {
        public void Accept(Ivisitor visitor);

    }
}