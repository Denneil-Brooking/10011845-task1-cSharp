using System;

namespace _10011845_task1_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        //CLEAR
        Console.Clear();
        //Print keywords for user
        Console.WriteLine("KEYWORDS");
        Console.WriteLine("To convert Farenheit to Celsius Type F");
        Console.WriteLine("To convert Celsius to Farenheit Type C");
        
        //Make needed vars
        string Farenheit = "F";
        string Celsius = "C";

        //Ask user for code input
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Please Type in one of the keywords");
        string Input = Console.ReadLine();
        //Inform them of choise
        
        //if user inputs F
        if (Input == Farenheit)
        {   
            Console.WriteLine($"You Input {Input} you wish to convert Farenheit to Celsius");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please type in the Number of the Farenheit you wish to convert to Celsius");
            Double F = Double.Parse (Console.ReadLine());
            Double connum = Math.Round(F * 9 / 5 + 32);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"{F} Ferenheit = {connum} Celsius");
        }
        //if user inputs C
        if (Input == Celsius)
        {
            Console.WriteLine($"You Input {Input} you wish to convert Celsius to Farenheit");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please type in the number of Celsius you wish to convert to Farenheit");
            Double C = Double.Parse (Console.ReadLine());
            Double connum = Math.Round(C -32 * 5 / 9);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"{C} Celsius = {connum} Farenteit");
        }
        if (Input == null) 
        {
            Console.WriteLine("You did not enter a correct Keyword or conversion number, Please run the program again");
        
        }
        //CLOSE
        Console.WriteLine("Program ending, Thank you");
        Console.ReadKey();
        }
    }
}
