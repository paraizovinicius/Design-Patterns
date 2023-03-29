using System;
namespace CoR{
    public class ConcreteImpl3 : RequestProcessor
    {
        public override void HandleRequest(int request)
        {
            if (request > 20) // Handle requests above 20
            {
                Console.WriteLine("{0} Handles the request {1}", this.GetType().Name, request);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}