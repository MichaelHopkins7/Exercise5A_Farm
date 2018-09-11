using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A_Farm
{
    internal class MilkCow
    {
        //produce milk
        //say "Moo"
        //eat grass
        //make calves
        // make Speak() for each animal type
        public void Speak() //make a cow speak
        {
            Console.WriteLine("The cow says \"Moo.\"");
        }

        public void Eats() //make a cow eat
        {
            Console.WriteLine("The cows eat grass.");
        }

        public void Makes() //make a cow Make baby calves
        {
            Console.WriteLine("The cows makes calves.");
        }

        public void Produces() //make a cow produce
        {
            Console.WriteLine("The milkcow produces milk.");
        }
    }
}