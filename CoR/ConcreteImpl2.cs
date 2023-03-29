using System;
namespace CoR{
    public class ConcreteImpl2 : RequestProcessor
    {
        public override void HandleRequest(int request)
        {
            if (request > 10 && request <= 20) // Handle requests between 11 and 20
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
