using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryConsoleApplication.Drivers.Interfaces;

namespace AbstractFactoryConsoleApplication.Drivers.Win98
{
    class Win98GraphicsManager:IGraphicsManager
    {
        private bool usingSystemMemory;

        public bool useSystemMemory
        {
            get
            {
                return usingSystemMemory;
            }
            set
            {
                usingSystemMemory = value;
            }
        }

        public void drawPixel()
        {
            Console.WriteLine("Dibujando un pixel en Windows 98");
        }
    }
}
