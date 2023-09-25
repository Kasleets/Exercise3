using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Hedgehog : Animal

    {
        public string? Spikes { get; set; }
        public Hedgehog(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, string? Spikes) : 
            base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            Spikes = "It has spikes!";
        }

        public override void DoSound()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
