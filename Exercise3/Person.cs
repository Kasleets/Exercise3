using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Person
    {
        private int age;
        private string fName = string.Empty;
        private string lName = string.Empty;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The age cannot be 0 or less.");
                }
                else age = value;
            }

        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Count(char.IsLetter) >= 2 && value.Count(char.IsLetter) <= 10)                    //making sure that there are no white spaces and such and in between 2 and 10 signs
                {
                    fName = value;
                }
                else throw new ArgumentException("First name cannot be shorter than 2 or 15 signs");

            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Count(char.IsLetter) >= 3 && value.Count(char.IsLetter) <= 15)                   //making sure that there are no white spaces and such and in between 3 and 15 signs
                {
                    lName = value;
                }
                else throw new ArgumentException("The last name needs to have in between 3 to 15 signs");
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("You can't be shorter than 0 cm!");
                }
                else height = value;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("You can't weigh nothing!");
                }
                else weight = value;
            }
        }

    }
}
