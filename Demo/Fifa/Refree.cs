using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Refree
    {
        public string Name { get; set; }

        // call back function
        public void Look()
        {
            Console.WriteLine($"Refree {Name} is looking");
        }
    }
}
