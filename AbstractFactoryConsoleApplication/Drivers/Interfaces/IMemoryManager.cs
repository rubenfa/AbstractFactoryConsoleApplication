using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsoleApplication.Drivers.Interfaces
{
    interface IMemoryManager
    {
        int allocatedMemorySize { get; set; }
        void InitializeMemory();
        void ClearMemory();
    }
}
