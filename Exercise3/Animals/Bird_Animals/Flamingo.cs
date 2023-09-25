using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Bird_Animals
{
    public class Flamingo : Bird
    {
        public double LegLength { get; set; } // unique property for this class
        public Flamingo(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool fly, double legLength) :
                        base(name, age, weight, type, isMale, isFeral, isPredator, fly)
        {
            LegLength = legLength;
        }
    }
}
