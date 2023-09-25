using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Exercise3.Animals.Regular_Animals;

namespace Exercise3.Animals.Special_Animals
{
    public class Wolfman : Wolf, IPerson //wolfman is a wolf and a person, using an interface
    {
        public Wolfman(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool ishostile) :
        base(name, age, weight, type, isMale, isFeral, isPredator, ishostile)
        {
            IsHostile = false;  //wolfman is cursed, he is not hostile
        }
        public void Talk()
        {
            Console.WriteLine("I am a wolfman, I can talk with you, don't kill me!");
        }
    }
}
