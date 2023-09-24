namespace _02_Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            string clothing = "";
            string shoes = "";

            if (degrees >= 10 && degrees <=18 )
            {
                if (timeOfTheDay is "Morning")
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfTheDay is "Afternoon")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfTheDay is "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24 )
            {
                if (timeOfTheDay is "Morning")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfTheDay is "Afternoon")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfTheDay is "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees >= 25)
            {
                if (timeOfTheDay is "Morning")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfTheDay is "Afternoon")
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfTheDay is "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
        }
    }
}
//----------------------------------------------------------------------------------------------
//Time of day / degrees          | Morning               |  Afternoon	       | Evening          |
//----------------------------------------------------------------------------------------------
//10 <= temperature <= 18        | Clothing = Sweatshirt |Clothing = Shirt     |Clothing = Shirt  |
//                               | Shoes = Sneakers      |Shoes = Moccasins    |Shoes = Moccasins |
//----------------------------------------------------------------------------------------------
//18 < temperature <= 24         | Clothing = Shirt      |Clothing = T-Shirt   |Clothing = Shirt  |
//                               | Shoes = Moccasins     |Shoes = Sandals      |Shoes = Moccasins |
//-----------------------------------------------------------------------------------------------
//temperature >= 25              | Clothing = T-Shirt    |Clothing = Swim Suit |Clothing = Shirt  |
//                               | Shoes = Sandals       |Shoes = Barefoot     |Shoes = Moccasins |
//-------------------------------------------------------------------------------------------------
//2.Summer Clothing
//Summer weather can be quite unpredictable, and Victor needs your assistance.
//Write a program that, based on the time of day and the temperature,
//recommends to Victor what clothes to wear.
//Your friend has different plans for each stage of the day that require varied clothing,
//as indicated in the table.
//Two lines are read from the console:
//•	Temperature - an integer in the range[10... 42]
//•	Text, time of day - with possibilities - "Morning", "Afternoon", "Evening"

