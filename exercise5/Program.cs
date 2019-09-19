using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("Vad heter du?: ");

            name = Console.ReadLine();

            Console.Write("Hur gammal är du?: ");
            age = Convert.ToInt32(Console.ReadLine());

            int daysLived = age * 365;

            Console.WriteLine("Hej " + name + "! Du är " + age + "år eller " + daysLived + " dagar!");
        }
    }
}
