using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    // Note: 13: If all birds need a new attribute, we would add it here to Bird class
    public class Bird : Animal // Bird inherits from Animal
    {
        public bool Fly { get; set; } // unique property for Bird

        public Bird(string name, int age, double weight, string type, bool isMale, bool isFeral, bool isPredator, bool fly) :
                    base(name, age, weight, type, isMale, isFeral, isPredator) 
        {
            Fly = fly;
        }

        public override void DoSound() // override DoSound() from Animal
        {
            Console.WriteLine("Chirp chirp!");      // unique sound for Bird
        }
        public override string Stats()
        {
            return base.Stats() + $" {nameof(Fly)}: {Fly}";
        }
    }
}
