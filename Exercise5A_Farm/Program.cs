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
                Dog lassie = new Dog(2);
                Dog rinTinTin = new Dog(3);
                Dog balto = new Dog(4);

                doge.Speak();
                doge.Make();
                doge.Does();
                doge.BreedIs();

                lassie.Speak();
                lassie.Make();
                lassie.Does();
                lassie.BreedIs();

                rinTinTin.Speak();
                rinTinTin.Make();
                rinTinTin.Does();
                rinTinTin.BreedIs();

                balto.Speak();
                balto.Make();
                balto.Does();
                balto.BreedIs();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Not Implemented.");
            }
        }
    }
    
}
