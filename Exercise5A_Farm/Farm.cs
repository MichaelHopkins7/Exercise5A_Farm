namespace Exercise5A_Farm
{
    internal class Farm
    {
        public Farm()
        {
            Chicken mrClucks = new Chicken("Mr. Clucks", true);
            Chicken mrsClucks = new Chicken("Mrs. Clucks", false);
            Chicken ladyCluckington = new Chicken("Lady Cluckington", false);
            Chicken cluckette = new Chicken("Cluckette", false);

            mrClucks.Speak();
            mrClucks.Eats();
            mrClucks.Produces();
            mrClucks.Makes();

            mrsClucks.Speak();
            mrsClucks.Eats();
            mrsClucks.Produces();
            mrsClucks.Makes();

            ladyCluckington.Speak();
            ladyCluckington.Eats();
            ladyCluckington.Produces();
            ladyCluckington.Makes();

            cluckette.Speak();
            cluckette.Eats();
            cluckette.Produces();
            cluckette.Makes();

            Sheep mrSmithSmithson = new Sheep();
            Sheep mrsSmithson = new Sheep();
            Sheep mrJohnJohnson = new Sheep();
            Sheep mrsJohnson = new Sheep();

            mrSmithSmithson.Eats();
            mrSmithSmithson.Speak();
            mrSmithSmithson.Produces();
            mrSmithSmithson.Makes();

            mrsSmithson.Eats();
            mrsSmithson.Speak();
            mrsSmithson.Produces();
            mrsSmithson.Makes();

            mrJohnJohnson.Eats();
            mrJohnJohnson.Speak();
            mrJohnJohnson.Produces();
            mrJohnJohnson.Makes();

            mrsJohnson.Eats();
            mrsJohnson.Speak();
            mrsJohnson.Produces();
            mrsJohnson.Makes();

            MilkCow elizabethThe1st = new MilkCow();
            MilkCow elizabethThe2nd = new MilkCow();
            MilkCow elizabethThe3rd = new MilkCow();
            MilkCow stacey = new MilkCow();

            elizabethThe1st.Eats();
            elizabethThe1st.Speak();
            elizabethThe1st.Produces();
            elizabethThe1st.Makes();

            elizabethThe2nd.Eats();
            elizabethThe2nd.Speak();
            elizabethThe2nd.Produces();
            elizabethThe2nd.Makes();

            elizabethThe3rd.Eats();
            elizabethThe3rd.Speak();
            elizabethThe3rd.Produces();
            elizabethThe3rd.Makes();

            stacey.Eats();
            stacey.Speak();
            stacey.Produces();
            stacey.Makes();

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