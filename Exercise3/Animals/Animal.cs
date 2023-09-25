using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    // Note: 14: if all animals needs a new attribute, we would add it to the Animal class
    public abstract class Animal // abstract class, can't be instantiated, only inherited from
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public bool IsMale { get; set; }
        public bool IsFeral { get; set; }
        public bool IsPredator { get; set; }

        public abstract void DoSound(); // a Method that all animals have in common, doing an override for each animal

        public Animal(string name, int age, double weight, string type, bool isMale, bool isFeral, bool isPredator) // constructor for all animals
        {
            Name = name;
            Age = age;
            Weight = weight;
            Type = type;
            IsMale = isMale;
            IsFeral = isFeral;
            IsPredator = isPredator;
        }

        public virtual string Stats()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(Weight)}: {Weight}, {nameof(Type)}: {Type}, {nameof(IsMale)}: {IsMale}, {nameof(IsFeral)}: {IsFeral}, {nameof(IsPredator)}: {IsPredator}";
        }

    }
}
