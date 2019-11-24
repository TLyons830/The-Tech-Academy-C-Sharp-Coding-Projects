using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step103
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = { "AAA", "BBB", "CCC", "DDD" };
            Console.WriteLine("Input some text.");
            string userText = Console.ReadLine();

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                arrayOfStrings[i] = arrayOfStrings[i] + userText;
            }

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine("\n" + arrayOfStrings[i]);
            }

            int a = 1;
            while (a == 1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("This is a pointless infinte loop.");
                a = 2; //No longer infinite 
            }

            Console.WriteLine(" ");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i <= numbers.Length -5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(" ");

            List<string> names = new List<string>() { "TYLER", "DAVIS", "PAUL", "SUE" };

            Console.WriteLine("Type in one of the following names 'TYLER', 'DAVIS,' 'PAUL', 'SUE.'\nAnd we will display the index at which the name is found.");
            string userName = Console.ReadLine();
            userName = userName.ToUpper();
            Console.WriteLine(" ");
            bool namePresent = names.Contains(userName);
            while (!namePresent)
            {
                Console.WriteLine("Name not found. Type in one of the following names 'TYLER', 'DAVIS,' 'PAUL', 'SUE.'\nAnd we will display the index at which the name is found.");
                userName = Console.ReadLine();
                userName = userName.ToUpper();
                namePresent = names.Contains(userName);
            }
            if (namePresent)
            {
                int indexNum = names.IndexOf(userName);
                Console.WriteLine("Index: " +indexNum);
            }
            Console.WriteLine(" ");

            List<string> dogs = new List<string>() { "YOGI", "RAMBO", "RIDLEY", "CALVIN", "YOGI" };
            Console.WriteLine("Type in one of the following dog names 'RAMBO', 'YOGI,' 'CALVIN', 'RIDLEY.'\nAnd we will display the index at which the name is found.");
            string dogName = Console.ReadLine();
            dogName = dogName.ToUpper();
            Console.WriteLine(" ");
            bool dogPresent = dogs.Contains(dogName);
            while (!dogPresent)
            {
                Console.WriteLine("Name not found. Type in one of the following dog names 'RAMBO', 'YOGI,' 'CALVIN', 'RIDLEY.'\nAnd we will display the index at which the name is found.");
                dogName = Console.ReadLine();
                dogName = dogName.ToUpper();
                dogPresent = dogs.Contains(dogName);
            }
            if (dogPresent)
            {
                for (int i = 0; i < dogs.Count; i++)
                {
                    if (dogs[i] == dogName)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine(" ");

            List<string> packers = new List<string>() { "AARON", "DAVANTE", "AARON", "JIMMY", "BLAKE" };

            int count = 0;
            foreach (string packer in packers)
            {
                for (int i = 0; i < packers.Count; i++)
                {
                    for (int j = i; j < packers.Count - 1; j++)
                    {
                        if(packers[i] == packers[j + 1])
                        {
                            count = count + 1;
                        }
                    }
                }
                Console.WriteLine(packer + " Instances: "+count);
            }

            Console.ReadLine();
        }
    }
}
