namespace Exercise5A_Farm
{
    internal class Farm
    {
        public Farm()
        {
            Chicken mrClucks;
            Chicken mrsClucks;
            Chicken ladyCluckington;
            Chicken cluckette;

            Sheep mrSmithSmithson;
            Sheep mrsSmithson;
            Sheep mrJohnJohnson;
            Sheep mrsJohnson;

            MilkCow elizabethThe1st;
            MilkCow elizabethThe2nd;
            MilkCow elizabethThe3rd;
            MilkCow stacey;

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

    }
}