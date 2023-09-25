using Exercise3.Animals;
using Exercise3.InputErrors;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)                         //creating a list of UserError objects and testing
        {
            Console.WriteLine("Hello, World!");

            PersonHandler personHandler = new PersonHandler();

            Person Stefan = personHandler.CreatePerson(25, "Stefan", "Potash", 185.2, 87.5);
            Console.WriteLine($"Created a person: {Stefan.FName} {Stefan.LName} of Age: {Stefan.Age} of Height: {Stefan.Height} of Weight: {Stefan.Weight}");

            personHandler.SetAge(Stefan, 33);
            Console.WriteLine($"Updated Age: {Stefan.Age}");
            Console.WriteLine($"Created a person: {Stefan.FName} {Stefan.LName} of Age: {Stefan.Age} of Height: {Stefan.Height} of Weight: {Stefan.Weight}\n");


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
            Wolfman wolfman = new Wolfman("Stefan", 28, 270, "Cursed", true, false, true, false);
            wolfman.Talk();





        }
    }
}