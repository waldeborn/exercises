using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne, nameTwo;
            
            Console.Write("Vad heter den första personen?: ");
            nameOne = Console.ReadLine();

            Console.Write("Vad heter den andra personen?: ");
            nameTwo = Console.ReadLine();

            Console.WriteLine(nameOne + " är bra på att programmera. " + nameTwo + " är riktigt  jäkla usel!");
        }
    }
}
