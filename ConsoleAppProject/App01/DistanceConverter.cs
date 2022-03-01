
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

        public const double FEET_IN_METRES = 0.3048;

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



        // Text Display of selected Units
        // Initial Conversion method
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


        // Distance Calculations
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
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// To allow for a unit to be selected,
        /// also repeat selected unit
        /// </summary>

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
            else
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Error, potential stack overflow prevented");
                Console.WriteLine("Make Sure Value input is 1-3 next time");
                Console.WriteLine("Restarting App in 5s");
                Console.Beep();
                System.Threading.Thread.Sleep(5000); // 5 Seconds delay

                Console.Clear();

                DistanceConverter converter = new DistanceConverter();

                converter.ConvertDistance();
            }
            return null;
        }



        /// <summary>
        /// Display Menu items and take
        /// and repeat input choice
        /// </summary>
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
        /// Issue an error if input value below 0/negative
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            if (Double.TryParse(value, out double fromDistance))
            {
                fromDistance = Convert.ToDouble(value);
                if (fromDistance < 0)
                {
                    fromDistance = InputDistance("Error, please input a positive value -> ");
                }
                return fromDistance;
            }
            else
            {
                fromDistance = InputDistance("Error, pls input a positive value -> ");
                return fromDistance;
            }
            
        }

       
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