using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___Tall_Guy
{
    class TallGuy:IClown
    {
        public string Name;
        public int Height;
        private string funnyThingIHave = "A pink hat";
        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public string AnotherFunnyThingIHave { get; private set; }
        public void Honk()
        {
            Console.WriteLine("Honk honk!!!");
        }



        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }

        public TallGuy(string anotherFunnyThingIHave)
        {
            AnotherFunnyThingIHave = anotherFunnyThingIHave;
        }
    }
}
