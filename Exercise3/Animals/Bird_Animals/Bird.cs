using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Bird_Animals
{
    // Note: 13: If all birds need a new attribute, we would add it here to Bird class
    public class Bird : Animal
    {
        public bool Fly { get; set; } // unique property for Bird

        public Bird(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool fly) :
                    base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            Fly = fly;
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp chirp!");      // unique sound for Bird
        }
    }
}
