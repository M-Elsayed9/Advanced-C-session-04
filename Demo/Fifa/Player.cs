using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }

        // call back function
        public void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
    }
}
