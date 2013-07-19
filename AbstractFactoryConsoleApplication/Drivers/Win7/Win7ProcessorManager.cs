using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryConsoleApplication.Drivers.Interfaces;

namespace AbstractFactoryConsoleApplication.Drivers.Win7
{
    class Win7ProcessorManager:IProcessorManager
    {
        public void setCurrentClockSpeed(int clockSpeed)
        {
            Console.WriteLine(String.Format("Establecida velociddad del procesador a {0} Ghz en Windows 7",clockSpeed));
        }
    }
}
