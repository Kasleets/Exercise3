using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Regular_Animals
{
    public class Horse : Animal
    {

        public string Breed { get; set; } // unique property for this class

        public Horse(string name, int age, double weight, string type, bool isMale, bool isFeral, bool isPredator, string breed) :
            base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neighuhuh!");
        }
        public override string Stats()
        {
            return base.Stats() + $" {nameof(Breed)}: {Breed}";
        }
    }
}
