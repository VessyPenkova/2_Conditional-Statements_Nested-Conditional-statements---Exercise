using System.Collections.Generic;

namespace _05__Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget = double.Parse(Console.ReadLine());
           string season = Console.ReadLine();

            string destination = "";
            string holidayType = "";

            double amountSpent = 0.00;

            double bulgariaSummer = 30.00 / 100;
            double bulgariaWinter = 70.00 / 100;

            double balkansSummer = 40.00 / 100;
            double balkansWinter = 80.00 / 100;

            double Europe = 90.00 / 100;

            if (budget <= 100.00)
            {
                destination = "Bulgaria";
                if (season is "summer")
                {          
                    holidayType = "Camp";
                    amountSpent = budget*bulgariaSummer;
                }
                else if (season is "winter")
                {
                    holidayType = "Hotel";
                    amountSpent = budget*bulgariaWinter;
                }
            }
            else if (budget <= 1000.00)
            {
                destination = "Balkans";
                if (season is "summer")
                {     
                    holidayType = "Camp";
                    amountSpent = budget * balkansSummer;
                }
                else if (season is "winter")
                {
                    holidayType = "Hotel";
                    amountSpent = budget * balkansWinter;
                }
            }
            else if (budget > 1000.00)
            {
                destination = "Europe";
                holidayType = "Hotel";
                amountSpent = budget * Europe;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {amountSpent:f2}");
        }
    }
}
//Input
//The input is read from the console - two lines, provided by the user:
//  V •	First line - Budget, floating point number in the range [10.00...5000.00].
//  V •	Second line - One of two possible seasons:  "summer" or "winter"

//Oddly, many individuals tend to plan their vacations well in advance.
//A young programmer, for instance, possesses a specific budget and a certain amount of free time during a particular season.
//Your task is to create a program that takes the budget and the season as inputs from the console,
//and produces an output detailing where the programmer will relax and how much he will spend.

//The budget determines the choice of destination,
//The season impacts how much of the budget will be spent.
//In the summer
// • Camping 
//In the winter
// • Hotel stay.

//However, if the destination is in Europe, a hotel stay will be selected no matter of the season.

//Each camping site or hotel has a price associated with it, which corresponds to a specific percentage of the budget: 

//•	If the budget is 100 leva or less - the destination will be somewhere in Bulgaria
//  •	Summer - 30% of the budget
//  •	Winter - 70% of the budget

//•	If the budget is 1 000 leva or less - the destination will be somewhere in the Balkans
//  •	Summer - 40% of the budget
//  •	Winter - 80% of the budget

//•	More than 1 000 leva - somewhere in Europe
//  •	When traveling around Europe, regardless of the season,
//  •   Spend  - 90% of the budget.

//Output
//Two lines must be printed as an output, on the console.

//•	First line - "Somewhere in {destination}" among "Bulgaria", "Balkans" and "Europe"
//•	Second line - "{holidayType} - {amountSpent}"
//•	Holidays can be between "Camp" and "Hotel"
//•	The amount must be rounded to the second decimal place.
