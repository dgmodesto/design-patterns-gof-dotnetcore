using System;

namespace Proxy
{
    class Program
    {
        /*
         - INTENÇÃO:    fornece um substituto (surrogate) ou marcador da localização de outro objeto
                        para controlar o acesso ao mesmo.
         - Um objeto representando um outro objeto.
             */
        static void Main(string[] args)
        {
            Image image1 = new ProxyImage("HiRes_10MB_Photo1");
            Image image2 = new ProxyImage("HiRes_10MB_Photo2");

            image1.displayImage();
            image2.displayImage();


            image1.displayImage();

        }
    }
}
