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
        //make puppies, memes, daring rescues, etc
        private string dogSays;
        private string dogMakes;
        private string dogDoes;
        private string dogBreedIs;

        public Dog(int speech) //sets what a dog does
        {
            switch (speech)
            {
                case 1:
                {
                    dogSays = "Doge says \"WOW!\".";
                    dogMakes = "Doge makes memes.";
                    dogDoes = "Doge butchers the english language.";
                    dogBreedIs = "Doge is such Shiba, very Inu.";
                    break;
                }
                case 2:
                {
                    dogSays = "Lassie says \"Bark!(Timmy is in the well!\").";
                    dogMakes = "Lassie makes TV shows and movies.";
                    dogDoes = "Lassie gets help when Timmy falls in the well.";
                    dogBreedIs = "Lassie is a Rough Collie.";
                    break;
                }
                case 3:
                {
                    dogSays = "Rin Tin Tin says \"Bark! Bark!\".";
                    dogMakes = "Rin Tin Tin made a hit movie that contributed to Warner Bros. success.";
                    dogDoes = "Rin Tin Tin made german shepards more popular dogs in the US.";
                    dogBreedIs = "Rin Tin Tin was a German Shepard.";
                    break;
                }
                case 4:
                {
                    dogSays = "Balto sayd \"Woof!\".";
                        dogMakes = "Balto makes life saving deliveries of medicine";
                        dogDoes = "Balto lead his dog team successfully through a whiteout blizzard at night.";
                        dogBreedIs = "Balto is a Siberian Husky";
                    break;
                }
            }
        }

        public void Speak() //make a dog speak
        {
            Console.WriteLine($"{dogSays}");
        }

        public void Make()
        {
            Console.WriteLine($"{dogMakes}");
        }

        public void Does()
        {
            Console.WriteLine($"{dogDoes}");
        }

        public void BreedIs()
        {
            Console.WriteLine($"{dogBreedIs}");
        }
    }
}