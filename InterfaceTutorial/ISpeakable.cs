using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTutorial
{



    internal interface ISpeakable               //Interface is a contract between two clases 
    {
        public void Speak();                    //The body stays empty on an interface

        public string AnimalType { get; set; }  //If you take this out of the other classes, you'll see you can't have extra properties in here that are not in rthe other classes

        public void Scream()                    //You can put in a default method, because it uses the other two properties that are associated with the other classes 
        {
            Console.WriteLine($"{AnimalType} screams");
            Speak();
        }



    }
}



//No executable code goes into the body. The interface has to have the same method, but in the class would have the body of the method in it
//We do this to make a list with all the other animals, because they do not link with each other