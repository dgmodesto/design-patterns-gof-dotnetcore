using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ProxyImage : Image
    {
        private string fileName;
        private RealImage image;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }
        public override void displayImage()
        {
            if(image == null)
            {
                image = new RealImage(fileName);
            }
            image.displayImage();
        }
    }
}
