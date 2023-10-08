using System.Collections.Generic;

namespace _09_Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string typeofroom = Console.ReadLine();
            string assessment = Console.ReadLine();
            double baseAmount = 0.00;
            double priceForOnePErsonRoom = 118.00;
            double priceForAppartment = 155.00;
            double priceForPresidentAppartment = 235.00;
            int discount = 0;
            double priceBeforeAssestment = 0.00; ;
            double finalPrice = 0.00;
            int nightToPay = daysToStay - 1;

            if (typeofroom == "room for one person")
            {                
                baseAmount = (daysToStay - 1) * priceForOnePErsonRoom;
                discount = 0;
                priceBeforeAssestment = baseAmount - baseAmount / 100 * discount;

            }
            else if (typeofroom == "apartment")
            {
                baseAmount = (nightToPay) * priceForAppartment;
                if (nightToPay < 10 )
                {
                    discount = 30;
                }
                else if (nightToPay >= 10  && nightToPay <= 15 )
                {
                    discount = 35;
                }
                else if (nightToPay > 15 )
                {
                    discount = 50;
                }
                priceBeforeAssestment = baseAmount - baseAmount / 100 * discount;

            }
            else if (typeofroom == "president apartment")
            {
                baseAmount = (nightToPay ) * priceForPresidentAppartment;
                if (nightToPay < 10 )
                {
                    discount = 10;
                }
                else if (nightToPay >= 10  && nightToPay <= 15 )
                {
                    discount = 15;
                }
                else if (nightToPay > 15 )
                {
                    discount = 20;
                }
                priceBeforeAssestment = baseAmount - baseAmount / 100 * discount;
            }

            if (assessment == "positive")
            {
                finalPrice = priceBeforeAssestment + priceBeforeAssestment / 100 * 25;
            }
            else if (assessment == "negative")
            {
                finalPrice = priceBeforeAssestment - priceBeforeAssestment / 100 * 10;
            }

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}

// V •	First line   - days to stay - integer in the range [0...365]
//•	Second line – type of room - "room for one person", "apartment" or "president apartment"
//•	Third line - assessment - "positive" or "negative"

//Atanas decided to spend his vacation in Bansko and go skiing. Before he goes, however, he must book a hotel
//and calculate how much his stay will cost.
//The following types of accommodation are available, each with its corresponding prices for stay:
//	"room for one person" - 118.00 BGN per night
//	"apartment" - 155.00 BGN per night 
//	"President Apartment" – 235.00 BGN per night
//Based on the number of days he plans to stay in the hotel (example: 11 days = 10 nights) and the type of room he chooses, he may be eligible for various discounts. 
//The available reductions are as follows:
//type of room        | Less than 10 days	| between 10 and 15 days inclusive | 	more than 15 days  |
//-----------------------------------------------------------------------------------------------------
//room for one person | 0 Discount          | 0 discount                       | 0 Discount            |
//-----------------------------------------------------------------------------------------------------
//apartment	          | 30% of the price   |	35% of the price	           | 50% of the final price|
//-----------------------------------------------------------------------------------------------------
//president apartment |	10% of the price   | 15% of the price                  |	20% of the price   |
//After the stay, Atanas' assessment of the hotel's services can be positive or negative.  If his assessment is "positive", Atanas adds 25% of it to the price with the already deducted discount. If his assessment is "negative", he deducts 10% from the price. 
//Input
//The input is read from the console and consists of three lines:
