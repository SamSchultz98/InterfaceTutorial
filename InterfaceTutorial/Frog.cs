using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTutorial
{
    internal class Frog : ISpeakable            //Joining ISpeakable here links the Class to the interface
    {
        public string Size { get; set; }
        public string AnimalType { get; set; } = String.Empty;
        public void Speak()
        {
            Console.WriteLine("Ribbit");
        }
    }
}
