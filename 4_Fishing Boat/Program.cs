namespace _4_Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group_Budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double springPrice = 3000.00;
            double summerPrice = 4200.00;
            //double autumnPrice = 4200.00;
            double winterPrice = 2600.00;
            double result = 00.00;

            double sixPeopleDiscount = 10.00 / 100;
            double sevenToElevenPeopleDiscount = 15.00 / 100;
            double twelveAndAbovePoepleDiscount = 25.00 / 100;
            double evenDiscount = 5.00 / 100;

            double neededAmount = 0.00;
            double discount = 0.00;
            if (season is "Spring")
            {
                neededAmount = springPrice;

                if (fishermenCount <= 6 && fishermenCount > 0)
                {
                    discount = neededAmount * sixPeopleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    else
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
                else if (fishermenCount >= 7 && fishermenCount <= 11)
                {
                    discount = neededAmount * sevenToElevenPeopleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    else
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
                else if (fishermenCount >= 12)
                {
                    discount = neededAmount * twelveAndAbovePoepleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    else
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                neededAmount = summerPrice;

                if (fishermenCount <= 6 && fishermenCount > 0)
                {
                    discount = neededAmount * sixPeopleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    if (season == "Summer")
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
                else if (fishermenCount >= 7 && fishermenCount <= 11)
                {
                    discount = neededAmount * sevenToElevenPeopleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    if (season == "Summer")
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
                else if (fishermenCount >= 12)
                {
                    discount = neededAmount * twelveAndAbovePoepleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    if (season == "Summer")
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
            }
            else if (season is "Winter")
            {
                neededAmount = winterPrice;

                if (fishermenCount <= 6 && fishermenCount > 0)
                {
                    discount = neededAmount * sixPeopleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    else
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
                else if (fishermenCount >= 7 && fishermenCount <= 11)
                {
                    discount = neededAmount * sevenToElevenPeopleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    else
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
                else if (fishermenCount >= 12)
                {
                    discount = neededAmount * twelveAndAbovePoepleDiscount;
                    neededAmount -= discount;
                    if (fishermenCount % 2 != 0)
                    {
                        evenDiscount = 0.00;
                    }
                    else
                    {
                        discount = neededAmount * evenDiscount;
                        neededAmount -= discount;
                    }
                }
            }
            result = group_Budget - neededAmount;

            if (result >= 0 )
            {
                Console.WriteLine($"Yes! You have {result:f2} leva left.");
                // Console.WriteLine($"Not enough money, you need {result:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(result*-1):f2} leva.");
            }
        }
    }
}
//You will have to read three values from the Console:
//Input
//   V •	Group Budget - integer in the range [1... 8000]
//   V •	Season - string: "Spring", "Summer", "Autumn", "Winter"
//   V •	Fishermen Count - integer in the range [4... 18]
//   V •	If the group is up to 6 people including – a discount of 10%.
//   V •	If the group is from 7 to 11 people – a discount of 15%.
//   V •	If the group is from 12 people and more – a discount of 25%. 
//   V •	The price for renting the boat in the spring is 3000 BGN.
//   V •	The price for renting the boat in the summer and autumn is 4200 BGN.
//   V •	The price for renting the boat in winter is 2600 BGN.
//   V •    Furthermore, the fishermen receive an extra 5% discount if the total count of fishermen is even.

//This additional discount is applied after deducting the discounts mentioned above, except during the autumn season.
//In autumn, this extra discount does not apply.

//Write a program to calculate whether the fishermen will be able to gather enough money for the fishing trip. 

//Output
//The result should be printed on the Console on a single line:
//•	If the budget is sufficient:
//"Yes! You have {moneyLeft} leva left."
//•	If the budget is not enough:
//"Not enough money! You need {moreMoney} leva."
//The value of the currency must be formatted to the second decimal place.

//Tony and his friends were passionate about fishing.
//They were so enthusiastic about it that they opted to go fishing by boat.
//The rental cost of the boat depends on both the season and the number of fishermen.
