using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Bird_Animals
{
    public class Flamingo : Bird
    {
        public Flamingo(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool fly) : 
                        base(name, age, weight, type, isMale, isFeral, isPredator, fly)
        {

        }
    }
}
