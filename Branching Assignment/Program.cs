using System;
using System.Diagnostics.Eventing.Reader;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //writes a welcome message
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");

            //asks for weight of package
            //if under weight continues, if over ends the process
            Console.WriteLine("Please input package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            //askes for input for dimensions//

            Console.WriteLine("Please input package width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //adds the dimensions together for a total for if statement//

            int total = packageWidth + packageHeight + packageLength;
            Console.WriteLine(total);

            //multiplys and divides the dimensions for the quote//

            int quote = packageWidth * packageHeight * packageLength * packageWeight / 100;

            //if statement taking the total and comparing it to the min requirements for shipping//
            //else gives user a total for package//

            if (total > 50)
            {
               Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is:" + "$" + quote.ToString("0.00") + "Thank you!");
            }
        }
    }
}
