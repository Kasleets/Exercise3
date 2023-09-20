namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine($"Updated Weight: {Monika.Weight}");




            //try
            //{
            //    person1.FName = "E";
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
        }
    }
}