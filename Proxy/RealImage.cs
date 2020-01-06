using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealImage : Image
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            private set {  fileName = value; }
        }

        public RealImage(string fileName)
        {
            FileName = fileName;
            loadImageFromDisk();
        }

        public void loadImageFromDisk()
        {
            Console.WriteLine("Loading " + FileName);
        }

        public override void displayImage()
        {
            Console.WriteLine("Displaying " + FileName);
        }
    }
}
