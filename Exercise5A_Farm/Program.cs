using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A_Farm
{
    class Program
    {
        //implement a farm. 
        //create a main function that exercises other classes
        static void Main(string[] args)
        {
            //create classes representing types of domestic animals
            //instansiate several objects of each class
            // woops already decided on four animals because of starting instructions
            // decide of four or more methods
            // woops again already made method in main to make a farm because of starting instructions
            //make exception handlers for not implemented
            // woops again again already made animals with names because of starting instructions
            // make Speak() for each animal type
            try
            {
                Farm kansas;

                Chicken MrClucks;
                Chicken MrsClucks;
                Chicken ClucksJunior;
                Chicken Cluckette;

                Sheep MrSmithSmithson;
                Sheep MrsSmithson;
                Sheep MrJohnJohnson;
                Sheep MrsJohnson;

                MilkCow ElizabethThe1st;
                MilkCow ElizabethThe2nd;
                MilkCow ElizabethThe3rd;
                MilkCow Stacey;

                Dog doge = new Dog(1); //implemented Doge
                Dog lassie;
                Dog rinTinTin;
                Dog balto;

                doge.Speak();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Not Implemented.");
            }
        }
    }
    
}
