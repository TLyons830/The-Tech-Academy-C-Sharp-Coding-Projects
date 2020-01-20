using System;

namespace FinalProjectOption1
{
    public class TestScore
    {
        public int TestId { get; set; }
        public float Score { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter which test result you would like to view: 1, 2, or 3.");
            Console.WriteLine("\n");
            int userTestNum = Convert.ToInt32(Console.ReadLine());

        }
    }
}
