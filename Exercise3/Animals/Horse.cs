﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Horse : Animal
    {
        public string Breed { get; set; }

        public Horse(string name, int age, int weight, string type, bool isMale, bool isFeral, bool isPredator, string breed) : 
            base(name, age, weight, type, isMale, isFeral, isPredator)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
        Console.WriteLine("Neighuhuh!");
        }
    }
}