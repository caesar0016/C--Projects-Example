using System;

namespace DataTpeApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int numberOfCats = 3;
            const string animal = "Cat/s";
            const double budget = 50.25;


            Console.WriteLine("Welcome to the Program /nMenu:");

            Console.Write("Enter short: ");
            short askShort = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Enter int: ");
            int askInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Long: ");
            long askLong = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter double: ");
            double askDouble = Convert.ToDouble(Console.ReadLine());    

            Console.Write("Enter char: ");
            char askChar = Convert.ToChar(Console.ReadLine());



            //This is for the constant. Just describing the cats and its budgets
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("How many " + animal + " do you have? " + numberOfCats);
            Console.WriteLine("The budget allocated for cat food we have? " + budget);

                    











































        }
    }
}