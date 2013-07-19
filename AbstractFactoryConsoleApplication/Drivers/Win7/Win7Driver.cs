using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryConsoleApplication.Drivers.Interfaces;

namespace AbstractFactoryConsoleApplication.Drivers.Win7
{
    class Win7Driver : IDriver
    {

        public IGraphicsManager CreateGraphicsManager()
        {
            return new Win7GraphicsManager();
        }

        public IMemoryManager CreateMemoryManager()
        {
            return new Win7MemoryManager();
        }

        public IProcessorManager CreateProcessorManager()
        {
            return new Win7ProcessorManager();
        }
    }
}
