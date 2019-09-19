using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarar variabel
            double decimalTal;
            //Användaren får mata in sitt tal
            Console.Write("Ange ditt decimaltal: ");
            //Konverterar
            decimalTal = double.Parse(Console.ReadLine());
            //Avrundar till närmsta heltal
            decimalTal = Math.Round(decimalTal);
            //Utmatning på skärm
            Console.WriteLine(decimalTal);
        }
    }
}
