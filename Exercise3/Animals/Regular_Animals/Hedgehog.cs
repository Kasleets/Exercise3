using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Regular_Animals
{
    public class Hedgehog : Animal
    {
        public int Spikes { get; set; } // unique property for this class
        public Hedgehog(string name, int age, double weight, string type, bool isMale, bool isFeral, bool isPredator, int spikes) :
            base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            Spikes = spikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squeak!");
        }
        public override string Stats()
        {
            return base.Stats() + $" {nameof(Spikes)}: {Spikes} individual spikes";
        }
    }
}
