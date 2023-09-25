using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    // Note: 14: if all animals needs a new attribute, we would add it to the Animal class
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public bool IsMale { get; set; }
        public bool IsFeral { get; set; }
        public bool IsPredator { get; set; }

        public abstract void DoSound();
    
        public Animal(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Type = type;
            IsMale = isMale;
            IsFeral = isFeral;
            IsPredator = isPredator;
        }
    }

}
