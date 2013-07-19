using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryConsoleApplication.Drivers.Interfaces;

namespace AbstractFactoryConsoleApplication.Drivers.Win98
{
    class Win98Driver : IDriver
    {

        public IGraphicsManager CreateGraphicsManager()
        {
            return new Win98GraphicsManager();
        }

        public IMemoryManager CreateMemoryManager()
        {
            return new Win98MemoryManager();
        }

        public IProcessorManager CreateProcessorManager()
        {
            return new Win98ProcessorManager();
        }
    }
}
