using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Bird_Animals
{
    public class Pelican : Bird
    {
        public double BeakVolume { get; set; } // unique property for this class
        public Pelican(string name, int age, double weight, string type, bool isMale, bool isFeral, bool isPredator, bool fly, double beakVolume) :
                        base(name, age, weight, type, isMale, isFeral, isPredator, fly)
        {
            BeakVolume = beakVolume;
        }
        public override string Stats()
        {
            return base.Stats() + $" {nameof(BeakVolume)}: {BeakVolume} ml";
        }
    }
    
}
