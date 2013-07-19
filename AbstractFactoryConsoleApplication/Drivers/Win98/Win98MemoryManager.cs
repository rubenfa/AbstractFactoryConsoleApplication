using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryConsoleApplication.Drivers.Interfaces;

namespace AbstractFactoryConsoleApplication.Drivers.Win98
{
    class Win98MemoryManager:IMemoryManager
    {
        int memoryAllocated;

        public int allocatedMemorySize
        {
            get
            {
                return memoryAllocated;
            }
            set
            {
                memoryAllocated = value;
            }
        }

        public void InitializeMemory()
        {
            Console.WriteLine(string.Format("Inicializando {0} MB de memoria en Windows 98", memoryAllocated));
        }

        public void ClearMemory()
        {
            Console.WriteLine("Borrando memoria en Windows 98");
        }
    }
}
