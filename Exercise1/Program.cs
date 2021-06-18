using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine($"Person details - {person} ");
            person.Age += 1;
            Console.WriteLine($"Person details - {person} ");
            Console.ReadLine();
        }
    }
}