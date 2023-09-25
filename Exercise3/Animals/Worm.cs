using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Worm : Animal
    {
        public string Decompositor { get; set; }
        public Worm(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, string decompositor ) : 
            base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            Decompositor = decompositor;
        }
        public override void DoSound()
        {
            Console.WriteLine("Worms give no sounds");
        }
    }
}
