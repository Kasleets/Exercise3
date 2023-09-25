using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Regular_Animals
{

    public class Wolf : Animal
    {
        public bool IsHostile { get; set; } // unique property for this class

        public Wolf(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool ishostile) :
        base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            IsHostile = ishostile;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hooooooowl!");
        }
    }

}
