namespace _1_Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double premiereTypeAmount = 12.00;
            double normalTypeAmount = 7.50;
            double discountTypeAmount = 5.00;
            double finalIncomes = 0.0;

            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            if (type is "Premiere")
            {
                finalIncomes = row * column * premiereTypeAmount;

            }
            else if (type is "Normal")
            {
                finalIncomes = row * column * normalTypeAmount;
            }
            else if (type is "Discount")
            {
                finalIncomes = row * column * discountTypeAmount;
            }
            Console.WriteLine("{0:f2} leva", finalIncomes);
        }
    }
}
//In a cinema hall, the chairs are arranged in a rectangular shape with r-rows and c-columns.
//There are three types of screenings with tickets at different prices:
//  V •	Premiere – premiere screening, at a price of 12.00 leva.
//  V •	Normal – standard screening, at a price of 7.50 leva.
//  V •	Discount – screening for children and students at a reduced price of 5.00 leva.


//Write a program that reads the type of screening (string),

//the number of
//rows and the number of
//columns in the hall (integers) entered by the user,
//and calculates the total ticket revenue at a full hall.
//The result should be presented in a format similar to the examples provided, showing 2 decimal places.  
//Example Input/Output
//To ensure the result is displayed with precisely two decimal places,
//use the following syntax: Console.WriteLine("{0:f2} leva", income).
