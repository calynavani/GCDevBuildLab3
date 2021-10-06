using System;

namespace GCDevBuildExponentsLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAB SUMMARY
            // Tell us what kind of loop you used and describe how your solution would have changed if you had used a different type of loop.
            // I used a for loop and while loop. I could have use a do while loop.However I felt that would have been petty.
            // I don't think my soultion would have changed at all as long as there weren't any typos.


            Console.WriteLine("Let's learn our squares and cubes :)\n");
            


            bool goOn = true;
            while (goOn)
            {
                string result1 = GetInput("Enter an interger: ");
                Console.WriteLine();
                int num = int.Parse(result1);
                int maxNumAllowed = Convert.ToInt32(Math.Floor(Math.Cbrt(Int32.MaxValue)));
                
                double squared = GetSquared(num);
                double cubed = GetCubed(num);

                if (num <= 0)
                {
                    Console.WriteLine("This is an invalid number");
                    Console.WriteLine($"Please enter a number that is greater than 0 and is positive");

                }
               
               

                else if (num > maxNumAllowed)
                {
                    Console.WriteLine("This is an invalid number");
                    Console.WriteLine($"Please enter a number that is less than {maxNumAllowed}");
                }
                else
                {

                    Console.WriteLine("Number \t \tSquared \t Cubed ");
                    Console.WriteLine("======= \t======= \t =======");
                    
                    for (int x = 1; x < num; x++)
                    {

                        Console.WriteLine($"{x}\t\t{x * x}\t\t {x * x * x}");

                    }
                    Console.WriteLine($"{num}\t\t{squared}\t\t {cubed}");
                }
                
                goOn = Continue();
            }
        }

        public static string GetInput(string promptToUser)
        {
            Console.Write(promptToUser);
            string userNum = Console.ReadLine();

            return userNum;
            
        }

        public static double GetSquared(double num)
        {
            double squared = num * num;
            return squared;
        }
        public static double GetCubed(double num)
        {
            double cubed = num * num * num;
            return cubed; ;
        }
        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? y/n ");
            
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;


            }
            else
            {
                Console.WriteLine("I'm sorry I didnt understand that");
                Console.WriteLine("Let's try again.");
                return Continue(); 
            }

        }
    }
}

