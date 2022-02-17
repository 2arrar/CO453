using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This application converts measures of distances
    /// </summary>
    /// <author>
    /// 2arrar v1.0
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5200;

        private double miles;

        private double feet;

        // This is the run sequence
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
            OutputHeading();
        }

        
        //Prompt the user to enter the distance in Miles
        //Input the Miles as a double number
        //Summary
        private void InputMiles()
        {
            Console.Write("Please enter number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + "feet!");
        }

        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();

            feet = miles * FEET_IN_MILES;

            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("  Convert Miles to Feet  ");
            Console.WriteLine("     by ZARRAR AFZAL     ");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
