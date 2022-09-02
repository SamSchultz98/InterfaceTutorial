using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTutorial
{
    internal class Boxer : ISpeakable
    {
        public string Color { get; set; }
        public string AnimalType { get; set; } = String.Empty;
        public void Speak()
        {
            Console.WriteLine("Whoof!");
        }
        public string Name { get; set; }
    }
}
