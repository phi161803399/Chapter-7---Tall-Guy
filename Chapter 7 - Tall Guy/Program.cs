using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___Tall_Guy
{
    class Program
    {
        static void Main(string[] args)
        {
            IClown[] clowns = new IClown[2]; 
            TallGuy tallGuy = new TallGuy("A guitar") {Name = "Jimmy", Height = 74};
            clowns[0] = tallGuy;
            tallGuy.TalkAboutYourself();
            Console.WriteLine(tallGuy.FunnyThingIHave);
            tallGuy.Honk();
            Console.WriteLine(tallGuy.AnotherFunnyThingIHave);
            IClown tallClown = new TallGuy("A red nose");
            clowns[1] = tallClown;
            tallClown.Honk();
            Console.WriteLine("==============================");
            Chief chief = new Chief(clowns);
            chief.GiveMeYourStuff();
            Console.ReadKey();
        }
    }

    class Chief
    {
        private IClown[] clowns;
        public void GiveMeYourStuff()
        {
            foreach (IClown clown in clowns)
            Console.WriteLine($"{clown} gives {clown.FunnyThingIHave}"); 
        }

        public Chief(IClown[] clowns)
        {
            this.clowns = clowns;
        }
    }
}
