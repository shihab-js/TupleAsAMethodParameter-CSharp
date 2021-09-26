using System;

namespace TupleAsAMethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a tuple
            var person = Tuple.Create(1, "Shihab", "Programmer");

            //Pass tuple in a method
            DisplayPerson(person);

        }
        //create DisplayPerson Method
        static void DisplayPerson(Tuple<int,string,string> person)
        {
            Console.WriteLine($"Id = {person.Item1}");
            Console.WriteLine($"Name = {person.Item2}");
            Console.WriteLine($"Profession = {person.Item3}");
        }
    }
}
