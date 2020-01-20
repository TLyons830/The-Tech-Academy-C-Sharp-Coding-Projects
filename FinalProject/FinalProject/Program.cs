using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Context())
            {
                TestScore scoreOne = new TestScore();
                scoreOne.TestId = 1;
                scoreOne.Score = 88.5F;

                TestScore scoreTwo = new TestScore();
                scoreTwo.TestId = 2;
                scoreTwo.Score = 95F;

                TestScore scoreThree = new TestScore();
                scoreThree.TestId = 3;
                scoreThree.Score = 65.5F;

                ctx.TestScores.Add(scoreOne);
                ctx.TestScores.Add(scoreTwo);
                ctx.TestScores.Add(scoreThree);
                ctx.SaveChanges();

                Console.WriteLine("Press a enter to view your three test results.");
                Console.ReadLine();
                
                var queryOne = from b in ctx.TestScores where b.TestId == 1 select b.Score;
                foreach (var score in queryOne)
                {
                    Console.WriteLine("\nYour first score was: "+score);
                }

                var queryTwo = from b in ctx.TestScores where b.TestId == 2 select b.Score;
                foreach (var score in queryTwo)
                {
                    Console.WriteLine("\nYour second score was: " + score);
                }

                var queryThree = from b in ctx.TestScores where b.TestId == 3 select b.Score;
                foreach (var score in queryThree)
                {
                    Console.WriteLine("\nYour third score was: " + score);
                }


                float averageScore = (from scores in ctx.TestScores select scores.Score).Average();
                Console.WriteLine("\n\nYour average score was : "+averageScore);

                Console.ReadLine();
            }

            
            

        }
    }
}
