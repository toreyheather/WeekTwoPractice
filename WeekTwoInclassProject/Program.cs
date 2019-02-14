using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoInclassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Color = "Black";
            dog.breed = "poodle";

            Console.WriteLine ("The " + dog.breed + " is " + dog.Color + ".");
            Console.Read();
}
    }
}
