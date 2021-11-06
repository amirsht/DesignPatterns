using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Lawyer law = new()
            {
                Name = "'law' Full Name",
                Role = "Traffic lawyer",
                Court = "Haifa"
            };

            Lawyer law2 = law; // Create Reference of law
            law.Name = "Amir Shtaiman"; //Change name of both law & law2

            Lawyer lawClone = (Lawyer)law.Clone(); //Create clone of law
            lawClone.Name = "Moshe the clone"; 

            Console.WriteLine($"Origin: {law.GetDetails()}");
            Console.WriteLine($"Origin Law2: {law2.GetDetails()}");
            Console.WriteLine($"After Clone: {lawClone.GetDetails()}");

            Typist typist = new()
            {
                Name = "Eyal Shani",
                Role = "Typist",
                WordsPerMinute = 120
            };

            Typist typistClone = (Typist)typist.Clone();
            typistClone.Name = "Moshe the clone";
            typistClone.WordsPerMinute = 69; //Not mention Role, it will copy above


            Console.WriteLine($"\n\nOrigin: {typist.GetDetails()}");
            Console.WriteLine($"After Clone: {typistClone.GetDetails()}");

            Console.ReadKey();
        }
    }
}
