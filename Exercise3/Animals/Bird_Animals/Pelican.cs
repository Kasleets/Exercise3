using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals.Bird_Animals
{
    public class Pelican : Bird
    {
        public int BeakVolume { get; set; }
        public Pelican(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, bool fly, int beakVolume) :
                        base(name, age, weight, type, isMale, isFeral, isPredator, fly)
        {
            BeakVolume = beakVolume;
        }
    }

}
