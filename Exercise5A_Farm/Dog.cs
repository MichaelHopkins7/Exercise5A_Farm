using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A_Farm
{
    internal class Dog
    {
        //say  "Wow", "Bark(Timmy is in the well)", "Bark! Bark!", or "Woof"
        //herd sheep
        //guard chicken coop
        //make puppies
        private string dogSays;
        
        public Dog(int speech) //sets what a dog says
        {
            switch (speech)
            {
                case 1:
                {
                    dogSays = "Doge says \"WOW!\"";
                    break;
                }
                case 2:
                {
                    dogSays = "Lassie says \"Bark!(Timmy is in the well!\"";
                    break;
                }
                case 3:
                {
                    dogSays = "Rin Tin Tin says \"Bark! Bark!\"";
                    break;
                }
                case 4:
                {
                    dogSays = "Balto sayd \"Woof!\"";
                    break;
                }
            }
        }

        public void Speak() //make a dog speak
        {
            Console.WriteLine($"{dogSays}");
        }

    }
}