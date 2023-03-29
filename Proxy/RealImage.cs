using System;
namespace Proxy{
    // Real Object
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk();
        }

        public void Display()
        {
            Console.WriteLine("Displaying image " + _fileName);
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading image " + _fileName);
        }
    }
}