using System;
namespace CoR{

    public abstract class RequestProcessor{
        protected RequestProcessor? nextHandler;

        public void SetNextHandler(RequestProcessor handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(int request);
    }
}