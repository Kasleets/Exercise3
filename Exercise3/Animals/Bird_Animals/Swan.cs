using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Bird_Animals
{
    public class Swan : Bird
    {
        public double NeckLength { get; set; } // unique property for this class
        public Swan(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool fly, double neckLength) : 
                    base(name, age, weight, type, isMale, isFeral, isPredator, fly)
        {
            NeckLength = neckLength;
        }
    }
}
