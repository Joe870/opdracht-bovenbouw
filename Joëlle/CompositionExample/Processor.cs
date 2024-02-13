using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal class Processor
    {
        public int clockSpeed;

        public Processor(int clockSpeed)
        {
            this.clockSpeed = clockSpeed;
        }

        public void StartUp()
        {
            Console.WriteLine("Starting the processor...");
        }
    }
}
