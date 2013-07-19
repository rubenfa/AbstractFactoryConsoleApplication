using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsoleApplication.Drivers.Interfaces
{
    interface IGraphicsManager
    {
        bool useSystemMemory { get; set; }
        void drawPixel();
    }
}
