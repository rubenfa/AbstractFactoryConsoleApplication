using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryConsoleApplication.Drivers.Interfaces;

namespace AbstractFactoryConsoleApplication.Drivers.Win7
{
    class Win7MemoryManager:IMemoryManager
    {
        int memoryAllocated =0;

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
            Console.WriteLine(string.Format("Inicializando {0} GB de memoria en Windows 7",memoryAllocated));
        }

        public void ClearMemory()
        {
            Console.WriteLine("Borrando memoria en Windows 7");
        }
    }
}
