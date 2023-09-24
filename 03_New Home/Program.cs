using System.Security.Cryptography;

namespace _03_New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] flowerstype = { "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus" };
            string typeOfFlowers = Console.ReadLine();
            int flowersCount  =int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosesPrice = 5.00;
            double priceDahlias = 3.80;
            double priceTulips = 2.80;
            double priceNarcissus = 3.00;
            double priceGladiolus = 2.50;

            double discount = 0.00;
            double decrese = 0.0;
            double result = 0.00;

            double neededAmount = 0.0;
            if (typeOfFlowers is "Roses")
            {
                if (flowersCount > 80)
                {
                    neededAmount = flowersCount * rosesPrice;
                    discount = 10.00/100;
                    neededAmount = neededAmount - neededAmount * discount;
                }
                else
                {
                    neededAmount = flowersCount * rosesPrice;
                    discount = 0.00;
                }
            }
            else if (typeOfFlowers is "Dahlias")
            {
                if (flowersCount > 90)
                {
                    neededAmount = flowersCount * priceDahlias;
                    discount = 15.00/100;
                    neededAmount = neededAmount - neededAmount * discount;
                }
                else
                {
                    neededAmount = flowersCount * priceDahlias;
                    discount = 0.00;
                }
            }
            else if (typeOfFlowers is "Tulips")
            {
                if (flowersCount > 80)
                {
                    neededAmount = flowersCount * priceTulips;
                    discount = 15.00/100;
                    neededAmount = neededAmount - neededAmount * discount;
                }
                else
                {
                    neededAmount = flowersCount * priceTulips;
                    discount = 0.00;
                }
            }
            else if (typeOfFlowers is "Narcissus")
            {
                if (flowersCount < 120)
                {
                    neededAmount = flowersCount * priceNarcissus;
                    decrese = 15.00/100;
                    neededAmount = neededAmount + neededAmount * decrese;
                }
                else
                {
                    neededAmount = flowersCount * priceNarcissus;
                    decrese = 0.00;
                }
            }
            else if (typeOfFlowers is "Gladiolus")
            {
                if (flowersCount < 80)
                {
                    neededAmount = flowersCount * priceGladiolus;
                    decrese = 20.00 / 100;
                    neededAmount = neededAmount + neededAmount * decrese;
                }
                else
                {
                    neededAmount = flowersCount * priceGladiolus;
                    decrese = 0.00;
                }
            }

            if (budget >= neededAmount)
            {
                result = budget - neededAmount;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeOfFlowers} and {result:F2} leva left.");
            }
            else
            {
                result = neededAmount - budget;
                Console.WriteLine($"Not enough money, you need {result:F2} leva more.");
            }
        }
    }
}
//Console.WriteLine("{0:f2} leva", finalIncomes);
//Martin and Nelly are buying a new house not far from Sofia.
//Nelly loves flowers so much that she convinces you to write a program to calculate how much it will cost
//them, to plant a certain number of flowers and whether the available budget will be enough for them. 
//Different flowers come at different prices. 

//Three lines should be read from the console:
//  V •	Type of flowers - text with options - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
//  V •	Flowers count - an integer in the range [10... 1000]
//  V •	Budget - an integer in the range[50... 2500]
//-------------------------------------------------------------------------------------------------------------------------
//Flower                    |Roses               | Dahlias             |Tulips            |Narcissus      | Gladiolus     |
//Price per piece in BGN	| 5 > 80 =10% Disc   | 3.80 > 90 = 15% Disc| 2.80> 80 =15%Disc|3 < 120 +15 %  | 2.50< 80 +20% |
//-------------------------------------------------------------------------------------------------------------------------
//The following discounts exist:
//•	If Nelly buys more than 80 Roses -   10% discount from the final price
//•	If Nelly buys more than 90 Dahlias - 15% discount from the final price
//•	If Nelly buys more than 80 Tulips -  15% discount from the final price
//•	If Nelly buys less than 120 Narcissus -   the price is increased by 15%
//•	If Nelly buys less than 80 Gladiolus -    the price in increased by 20%

//Print the result on the console on a single line:
//•	If their budget is enough - "Hey, you have a great garden with {flowersCount} {flowersType} and {sumLeft} leva left."
//•	If their budget is NOT enough, "Not enough money, you need {neededMoney} leva more."
//The sum should be formatted to the second decimal place.
