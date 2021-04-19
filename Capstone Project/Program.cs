using System;

namespace Capstone_Project
//************************************************************
// Application    The Capstone Project
// Author         Bradford, JJ
// Description    An application that allows the user to calculate their BMI
//                and see if they are living a healthy lifestyle. 
// Date Created   4/1/2021
// Date Revised   4/10/2021
//************************************************************
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Variables 
            string name, weight, str_feet, str_inches;
            double pounds,feet,inches,total_inches, BMI;

            //
            // Theme
            //
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetWindowSize(150, 40);
            Console.Clear();


            // Title Of Program
            Console.Title = "BMI Calculator";
            
            // Welcome The User
            Console.WriteLine("\tWelcome to the BMI Calculator");
            Console.WriteLine(" This program will ask you your height and body weight"+
                  " and in result you will be given your Body Mass Index.");

            // Get User's Name
            Console.Write("\n Lets begin with what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("\n It's nice to meet you, " + name+ ".");

            // Get User's Age
            Console.WriteLine("How old are you?");
            Console.ReadLine();

            // Get User's Gender
            Console.WriteLine("What is your sex?");
            Console.ReadLine();
            
            // Get User's Weight
            Console.Write("How much do you weigh in pounds?");
            weight = Console.ReadLine();

            while (!Double.TryParse(weight, out pounds))
            {
                Console.Write("Please enter you weight as a number:");
                weight = Console.ReadLine();
            }
            {
                // Get User's Height In Feet
                Console.WriteLine("Now the program needs your height in feet and inches");
                Console.Write("Feet:");
                str_feet = Console.ReadLine();
               while (!Double.TryParse(str_feet,out feet))
                {
                    Console.Write("Please enter you feet as a number:");
                    str_feet = Console.ReadLine();
                }
                // Get User's Height In inches
                Console.Write("inches:");
                str_inches = Console.ReadLine();

                while (!Double.TryParse(str_inches, out inches ))
                {
                    Console.Write("Please enter you inches as a number:");
                    str_inches = Console.ReadLine();
                }
            }

            Console.WriteLine("Press Enter to get your results");
            Console.Read();
            

            // Calculate total inches
            total_inches = feet * 12+ inches;

            // Calculate BMI
            BMI = (pounds / Math.Pow(total_inches, 2)) * 703;
            BMI = Math.Round(BMI, 2);

            Console.WriteLine("Based on your infromation, your BMI is " + BMI +  ".");
            Console.WriteLine("Note that if you are under the age of 20 that you should consider " +
                "your exact age and sex in relation to other children in that category");

            // Exit
            Console.Write("\nThanks for using our program. Please ");
            Console.Write("Press enter to quit.");
            Console.ReadLine();



        }
    }
}
