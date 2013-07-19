using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryConsoleApplication.Drivers.Interfaces;

namespace AbstractFactoryConsoleApplication
{
    class Program
    {
       
        static void Main(string[] args)
        {
            IDriver driver = null; ;

            if (args[0] == "win98")
                driver = new AbstractFactoryConsoleApplication.Drivers.Win98.Win98Driver();
            else if (args[0] == "win7")
                driver = new AbstractFactoryConsoleApplication.Drivers.Win7.Win7Driver();

            try
            {
                IMemoryManager memory = driver.CreateMemoryManager();
                memory.allocatedMemorySize = int.Parse(args[1]);
                memory.InitializeMemory();

                IProcessorManager processor = driver.CreateProcessorManager();
                processor.setCurrentClockSpeed(int.Parse(args[2]));

                IGraphicsManager graphics = driver.CreateGraphicsManager();
                graphics.useSystemMemory = true;
                graphics.drawPixel();


            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Parámetros insuficientes. Debe introducir comando.exe driver memory_size clock_speed");
            }
            catch (Exception)
            {
                Console.WriteLine("Driver no encontrado");
            }


            Console.ReadKey();             
        }
    }
}
