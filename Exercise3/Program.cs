using Exercise3.Animals;
using Exercise3.Animals.Bird_Animals;
using Exercise3.Animals.Regular_Animals;
using Exercise3.Animals.Special_Animals;
using Exercise3.InputErrors;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)                         //creating a list of UserError objects and testing
        {
            #region Assignment part 3.1 Incapsulation

            Console.WriteLine("Hello, World!");

            PersonHandler personHandler = new PersonHandler();

            Person Stefan = personHandler.CreatePerson(25, "Stefan", "Potash", 185.2, 87.5);
            Console.WriteLine($"Created a person: {Stefan.FName} {Stefan.LName} of Age: {Stefan.Age} of Height: {Stefan.Height} of Weight: {Stefan.Weight}");

            personHandler.SetAge(Stefan, 33);
            Console.WriteLine($"Updated Age: {Stefan.Age}");
            Console.WriteLine($"Created a person: {Stefan.FName} {Stefan.LName} of Age: {Stefan.Age} of Height: {Stefan.Height} of Weight: {Stefan.Weight}");


            Person Monika = personHandler.CreatePerson(27, "Monika", "Touric", 172.7, 52);
            personHandler.SetWeight(Monika, 57.4);
            Console.WriteLine($"Created a person: {Monika.FName} {Monika.LName} of Age: {Monika.Age} of Height: {Monika.Height} of Weight: {Monika.Weight}");
            Console.WriteLine($"Updated Weight: {Monika.Weight}\n");

            //try
            //{
            //    person1.FName = "E";
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            #endregion

            
            #region Assignment part 3.2 Polymorphism Testing all input errors if they display correctly and their implementation

            List<UserError> userErrors = new List<UserError>();                 //creating a list of UserError objects
            {
                new NumericInputError();
                new TextInputError();
                new EmptyInputError();
                new NullInputError();
                new SpecialCharacterInputError();


            };

            //// Testing all input errors if they display correctly
            //userErrors.Add(new NumericInputError());
            //userErrors.Add(new TextInputError());
            //userErrors.Add(new EmptyInputError());
            //userErrors.Add(new NullInputError());
            //userErrors.Add(new SpecialCharacterInputError());

            //displaying all usererrors to user
            foreach (UserError userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }




            //testing a Wolfman with parameters and his talking method
            //Wolfman wolfman = new Wolfman("Stefan", 28, 270, "Cursed", true, false, true, false);
            //wolfman.Talk();
            #endregion

            #region Assignment part 3.3 Inheritance and 3.4 More Polymorphism

            Console.WriteLine("\nI am printing Animal list now:\n");
            List<Animal> animals = new List<Animal>();                  //creating a list of Animal objects
            {
                animals.Add(new Dog("Rex", 5, 25, "Dog", true, false, true, false));
                animals.Add(new Hedgehog("Sonic", 3, 1, "Hedgehog", true, true, false, 789));
                animals.Add(new Horse("Spirit", 7, 300, "Horse", true, false, false, "Arabian"));
                animals.Add(new Pelican("Pelikso", 3, 6.4, "Pelican", true, true, false, true, 150));
                animals.Add(new Swan("Svante", 2, 7, "Swan", false, true, false, true, 40));
                animals.Add(new Wolf("Wolfie", 4, 50, "Wolf", true, true, true, true));
                animals.Add(new Worm("Wormy", 1, 0.7, "Worm", false, true, false, "It is a decompositor"));
                animals.Add(new Dog("Rekio", 12, 5, "Dog", true, false, true, true));
                animals.Add(new Flamingo("Flammy", 2, 3, "Flamingo", true, true, false, true, 80));
                animals.Add(new Wolfman("Stefan", 28, 270, "Cursed Wolfman", true, false, true, false));
            };

            foreach (var animal in animals)                             //looping through all animals in the list
            {
                if (animal is IPerson)                                  //if animal is a person, cast it to a person and call the talk method
                {
                    IPerson person = (IPerson)animal;                   //casting animal to a person
                    person.Talk();                                      //calling the talk method
                }

            // Note: 14: 15: 16: 17: You won't directly access methods unique to Dog from a list of Animal without type casting. Need another if statement
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.RandomMethod());
                }

                Console.WriteLine(animal.Stats());                      //displaying all animals stats
                animal.DoSound();                                       //calling the dosound method for all animals
                Console.WriteLine();                                    //adding a line between each animal
            }


            // Note: 9: Creating a list just for dogs. You can't add a horse to this list because of type safety in C#
            // Note: 10: In order to add a horse to this list, you would have to change the type of the list to Animal
            Console.WriteLine("\nI'm printing a test dog list now: \n");
            Console.WriteLine();
            List<Dog> dogs = new List<Dog>();
            {
                dogs.Add(new Dog("Rex", 5, 7, "Dog", true, false, true, false));
                dogs.Add(new Dog("Rekio", 12, 5, "Dog", true, false, true, true));
                dogs.Add(new Dog("Felix", 3, 3, "Dog", true, false, true, false));
                dogs.Add(new Dog("Max", 5, 25, "Dog", true, false, true, true));
                dogs.Add(new Dog("Liks", 8, 2, "Dog", true, false, true, false));

            };


            //printing all dogs to console
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Stats());
                dog.DoSound();
                Console.WriteLine();
            }

            #endregion



        }
    }
}