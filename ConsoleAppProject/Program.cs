using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// ZARRAR AFZAL
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("               by Zarrar Afzal                    ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Menu();

        }

        private static void Menu()
        {
            Console.WriteLine("!-!-!-!-!"); 
            Console.WriteLine("PLEASE SELECT APP");
            Console.WriteLine("1) APP01-DISTANCE CONVERTER");
            Console.WriteLine("2) APP02-BMI CALCULATOR");
            Console.WriteLine("3) APP03-STUDENT GRADE CALCULATOR");
            Console.WriteLine("4) APP04-SOCIAL NETWORK");
            Console.WriteLine("!-!-!-!-!");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DistanceConverter converter = new DistanceConverter();

                converter.ConvertDistance();
            }
            else if (choice == "2")
            {
                BMI bmi = new BMI();


                bmi.Run();
            }
            else if (choice == "3")
            {
                StudentGrades grades = new StudentGrades();
                grades.Run();
            }
            else if (choice == "4")
            {
                SocialNetwork social = new SocialNetwork();
                social.DisplayMenu();
            }
            else
            {
                Console.WriteLine(" 1 2 or 3");
            }
        }
    }
}
