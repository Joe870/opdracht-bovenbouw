using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal class Motherboard
    {
        public Processor processor;
        public Disk disk;

        public Motherboard(Processor processor, Disk disk)
        {
            this.processor = processor;
            this.disk = disk;
        }

        public void StartUp()
        {
            Console.WriteLine("Starting the motherboard.");
            processor.StartUp();
        }
    }
}
