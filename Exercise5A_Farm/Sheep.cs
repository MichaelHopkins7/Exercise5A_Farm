using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A_Farm
{
    internal class Sheep
    {
        //eat grass
        //provide wool
        //make baby sheep
        //say "Baa"
        // make Speak() for each animal type
        public void Speak() //make a sheep speak
        {
            Console.WriteLine("The sheep says \"Baa.\"");
        }

        public void Eats() //make a sheep eat
        {
            Console.WriteLine("The sheep eat grass.");
        }

        public void Makes() //make a sheep Make baby sheep
        {
            Console.WriteLine("The sheep makes lambs.");
        }

        public void Produces() //make a sheep produce
        {
            Console.WriteLine("The sheep produce wool.");
        }
    }
}