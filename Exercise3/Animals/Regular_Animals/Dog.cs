using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Regular_Animals
{
    public class Dog : Animal
    {
        public bool IsWorking { get; set; } // unique property for this class
        public Dog(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool isWorking) :
            base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            IsWorking = isWorking;
        }
        public override void DoSound()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}
