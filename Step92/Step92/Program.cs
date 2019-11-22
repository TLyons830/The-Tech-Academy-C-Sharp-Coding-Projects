using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());
            if (weight > 50.0)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (weight <= 50.0)
            {
                Console.WriteLine("Please enter the package width:");
                float width = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                float length = Convert.ToSingle(Console.ReadLine());

                float estimateTotal = ((width + height + length) * (weight) / 100);
                string estimateDIsplay = String.Format("Your estimated total for shipping this package is: {0:C}", estimateTotal);

                Console.WriteLine(estimateDIsplay);
                Console.WriteLine("Thank you.");
            }
            

            Console.ReadLine();
        }
    }
}
