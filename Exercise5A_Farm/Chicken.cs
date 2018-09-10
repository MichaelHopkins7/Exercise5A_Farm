using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A_Farm
{
    internal class Chicken
    {
        //Eat seed
        //say "Cluck"
        //produce eggs
        //make chicks
        // make Speak() for each animal type
        string chickensName;
        bool isMale;
        public Chicken(string name, bool isMale)
        {
            chickensName = name;
            this.isMale = isMale;
            return;
        }

        public void Speak() //make a chicken speak
        {
            Console.WriteLine($"{chickensName} says \"Cluck Cluck\"");
            return;
        }

        public void Eats() //the chicken, it eats
        {
            Console.WriteLine($"{chickensName} eats seed.");
            return;
        }

        public void Makes() //the chicken makes more chickens
        {
            Console.WriteLine($"{chickensName} makes lots of adorable little chicks!"); 
            return;
        }

        public void Produces() //the chicken makes more chickens
        {
            if (isMale == true)
            {
                Console.WriteLine($"{chickensName} produces a wakeup in the morning.");
            }
            else
            {
                Console.WriteLine($"{chickensName} produces a lot of eggs.");
            }
            return;
        }
    }
}