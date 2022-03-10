using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public int Bmi { get; set; }

        public string Choice { get; set; }
        public string choice2;

        public double WeightStones { get; set; } //change to int if too kwazy
        public double WeightPounds { get; set; } //same here

        public double HeightFeet { get; set; }
        public double HeightInches { get; set; }

        public double Weight { get; set; }
        public double Height { get; set; }

        // Run Command
        public void Run()
        {
            //OutputHeading();

            // experimental do command- if no worky go to orig
            do
            {
                Choice = SelectUnits();
            }
            while (Choice == null);

            if (Choice == "metric")
            {
                InputMetric();
            }
            else 
            {
                InputImperial();
            }

            CalculateBMI();
            OutputBMI();
            OutputBLAME();
        }

        public void OutputHeading()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("        BMI CALCULATOR      ");
            Console.WriteLine("       /BODY MASS INDEX/    ");
            Console.WriteLine("       USING 2020 MODEL     ");
            Console.WriteLine("    created by ZARRAR AFZAL ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public string SelectUnits()
        {
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");
            Console.WriteLine("Please Select one of the Following Measurements");
            Console.WriteLine("No.| NAME  |    WEIGHT     |  HEIGHT      ");
            Console.WriteLine("1) IMPERIAL - STONES+POUNDS FEET/INCH");
            Console.WriteLine("2) METRIC   - KILOGRAM      METRES");
            Console.WriteLine("!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");
            Console.WriteLine("Please enter 1 or 2");
            Choice = Console.ReadLine();
            if (Choice == "1")
            {
                return "imperial";
            }
            else if (Choice == "2")
            {
                return "metric";
            }
            else
            {
                Console.WriteLine("Simple instructions, 1 or 2.");
                return null;
            }
        }


        public double InputMeasurement(string prompt, double measurement)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            //if no worky use orig
            if(Double.TryParse(value, out measurement))
            {
                measurement = Convert.ToDouble(value);
                if(measurement < 0)
                {
                    measurement = InputMeasurement("Negative, invalid input", measurement);
                    Console.Beep();
                }
                return measurement;
            }
            else
            {
                measurement = InputMeasurement("Negative, invaLid input", measurement);
                Console.Beep();
                return measurement;
            }
        }


        /// <summary>
        /// Method for gathering Imperial inputs
        /// </summary>
        private void InputImperial()
        {
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");
            Console.WriteLine(" WEIGHT STONES/POUNDS + HEIGHT FEET/INCH ");
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");

            WeightStones = InputMeasurement("ENTER WEIGHT IN STONES: ", WeightStones);
            WeightPounds = InputMeasurement("ENTER WEIGHT IN POUNDS: ", WeightPounds);
            Console.WriteLine("!-!-!-!-!");

            //height bit
            HeightFeet = InputMeasurement("ENTER HEIGHT IN FEET: ", HeightFeet);
            HeightInches = InputMeasurement("ENTER HEIGHT IN INCH: ", HeightInches);
            
        }

        private void InputMetric()
        {
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");
            Console.WriteLine(" WEIGHT KILOGRAMS    +   HEIGHT METRES   ");
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");

            Weight = InputMeasurement("ENTER WEIGHT IN KILOGRAM: ", Weight);
            Console.WriteLine("!-!-!-!-!");
            Height = InputMeasurement("ENTER HEIGHT IN METRES", Height);
        }


        /// <summary>
        /// To calculate users BMI
        /// </summary>
        public void CalculateBMI()
        {
            if (Weight == 0)
            {
                Weight = (WeightStones * 14 + WeightPounds) * 703;
                Height = HeightFeet * 12 + HeightInches;
            }
            Bmi = (int)(Weight / (Height * Height));
        }

        /// <summary>
        /// To provide an output of BMI total and to
        /// suggest implications of result OW/UW/NOR,etc
        /// 
        /// UNDERWEIGHT <18.50
        /// NORMAL 18.5 TO 24.9
        /// OVERWEIGHT 25.0 TO 29.9
        /// OBESE CLASS I 30.0 TO 34.9
        /// OBESE CLASS II 35 TO 39.9
        /// OBESE CLASS III >=40.0
        /// </summary>
        private void OutputBMI()
        {
            Console.WriteLine("!-!-!-!-!-!-!-!");
            Console.WriteLine($"Your BMI totals to {Bmi}");
            Console.WriteLine("!-!-!-!-!-!-!-!");

            //if statement =adjust decimals to newer model
            if (Bmi < 18.5)
            {
                Console.WriteLine("BMI IMPLIES YOU ARE UNDER-WEIGHT!");
            }
            else if (Bmi < 24.9)
            {
                Console.WriteLine("BMI IMPLIES YOU ARE NORMAL");
            }
            else if (Bmi < 29.9)
            {
                Console.WriteLine("BMI IMPLIES YOU ARE OVERRWEIGHT");
            }
            else if (Bmi < 34.9)
            {
                Console.WriteLine("BMI IMPLIES YOU ARE OBESE CLASS 1");
                HighBMI();
            }
            else if (Bmi < 39.9)
            {
                Console.WriteLine("BMI IMPLIES YOU ARE OBESE CLASS 2");
                HighBMI();
            }
            else
            {
                Console.WriteLine("BMI IMPLIES YOU ARE OBESE CLASS 3");
                HighBMI();
            }

        }

        private void OutputBLAME()
        {
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");
            Console.WriteLine("                 Be aware                ");
            Console.WriteLine("BAME principle states: "); 
            Console.WriteLine("Those under the conditions:");
            Console.WriteLine("-Black");
            Console.WriteLine("-Asian");
            Console.WriteLine("-Other ethnics");
            Console.WriteLine();
            Console.WriteLine("  It is believed you pose a higher risk  ");
            Console.WriteLine(" of obesity and other relating positions ");
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");
        }

        private void HighBMI()
        {
            Console.Beep();
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");
            Console.WriteLine("                   ALERT                 ");
            Console.WriteLine("        HIGH BMI HAS BEEN CALCULATED     ");
            Console.WriteLine("High BMI can lead to serious health problems");
            Console.WriteLine(" Please Consult a doctor for further help");
            Console.WriteLine("-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-");

        }
 

       
    }
}
