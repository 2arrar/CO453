﻿
using System;
namespace ConsoleAppProject.App01
{
        /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// 2arrar v0.1
    /// </author>
    public class DistanceConverter

    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
          fromUnit = MILES;
          toUnit = FEET;
        }



        
        public void ConvertDistance()
        {
          OutputHeading();

            fromUnit = SelectUnit(" Please select the From distance unit > ");
            toUnit = SelectUnit(" Please select the To distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");

            CalculateDistance();
          
            OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }




        /// <summary>
        /// Prompt user to input of miles
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
            
        }

        //45;00 timestamp
 


       
        /// <summary>
        /// To display output of measurements
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}!");
        }


        /// <summary>
        /// To have a heading display
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("     DiStAnCe    CoNvErTeR       ");
            Console.WriteLine("        by Zarrar Afzal          ");
            Console.WriteLine("--------------------------------\n");

        }
    }
  
}