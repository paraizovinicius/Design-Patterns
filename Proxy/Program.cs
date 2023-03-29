using System;
namespace Proxy{
    public class Program
    {
        public static void Main()
        {
            // Creates a Proxy object 
            IImage image = new ProxyImg("image.jpg");

            // The first time the image is loaded, she'll be loaded from disk
            image.Display();

            // The second time, she'll be loaded from proxy cache
            image.Display();
        }
    }
}

