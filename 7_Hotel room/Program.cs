using System;
using System.Diagnostics;

namespace _7_Hotel_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nigthCount = int.Parse(Console.ReadLine());

            double studioAmount = 0.00;
            double appartmentAmount = 0.00;

            double discountStudio = 0.00;
            double discountAppartment = 0.00;

            if (month == "May" || month == "October")
            {
                studioAmount = nigthCount * 50.00;
                appartmentAmount = nigthCount * 65;
                if (nigthCount>7  && nigthCount <= 14 )
                { 
                    discountStudio = studioAmount / 100 * 5;
                    studioAmount -= discountStudio;
                }
                else if (nigthCount > 14)
                {                   
                    discountStudio = studioAmount / 100 * 30;
                    studioAmount -= discountStudio;
                    discountAppartment = appartmentAmount / 100 * 10;
                    appartmentAmount -= discountAppartment;
                }

            }
            else if (month == "June" || month == "September")
            {
                studioAmount = nigthCount * 75.20;
                appartmentAmount = nigthCount * 68.70;
                if (nigthCount >  14)
                { 
                    discountStudio = studioAmount / 100 * 20;
                    studioAmount -= discountStudio;
   
                    discountAppartment = appartmentAmount / 100 * 10;
                    appartmentAmount -= discountAppartment;
                }               
            }
            else if (month == "July" || month == "August")
            {
                studioAmount = nigthCount*76.00;
                appartmentAmount = nigthCount * 77.00;
                if (nigthCount > 14)
                {
                    discountAppartment = appartmentAmount / 100 * 10;
                    appartmentAmount -= discountAppartment;
                }
            }

            Console.Write($"Apartment: {appartmentAmount:f2} lv.");
            Console.Write($" Studio: {studioAmount:f2} lv.");

        }
    }
}
//Input
//The input is read from the console and contains exactly 2 lines entered by the user:
//      V •	Month - string("May", "June", "July", "August", "September" or "October")
//      V •	Count of nights - an integer in the range [1 ... 200]
// May and October	                       | June and September	             | July and August                      |
//------------------------------------------------------------------------------------------------------------------
//Studio    – 50 BGN   > 7d- 5% , > 14-30% | Studio    – 75.20 BGN  >14 -20% | Studio    – 76 BGN/night             |
//Apartment – 65 BGN   >14 -10%            | Apartment – 68.70 BGN  >14 -10% | Apartment – 77 BGN/night   >14 -10%  |
//------------------------------------------------------------------------------------------------------------------

//The prices are determined by the month of the stay:
//A hotel provides 2 types of rooms, studio and apartment.
//Your task is to create a program that computes the total cost of a stay for both the studio and the apartment.

//The following discounts are also available:
//  •	For a studio, for more than  7 nights in May and October:  5 % discount.
//  •	For a studio, for more than 14 nights in May and October: 30 % discount.
//  •	For a studio, for more than 14 nights in June and September: 20 % discount.
//  •	For an apartment, for more than 14 nights, no matter the month: 10 % discount.

//Output
//Print 2 lines on the console:
//•	On the first line: " Apartment: {price for the entire stay} lv."
//•	On the second line: " Studio: {price for the entire stay} lv."
//The price for the entire stay formatted to the second decimal place.


