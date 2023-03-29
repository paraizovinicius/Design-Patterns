using System;
namespace Proxy{
    public class ProxyImg : IImage
    {
        private string _fileName;
        private RealImage? _realImage;

        public ProxyImg(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName); // first time is loaded, she'll call the RealImage class (Real Object)
            }
            _realImage.Display(); // Not the first time is loaded. The local variable already know the _filename
        }
    }
}

