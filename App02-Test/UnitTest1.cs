using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;


namespace App02_Test
{
    [TestClass]
    public class UnitTest1
    {
        BMI bmi = new BMI();
        [TestMethod]
        public void TestUnderweightImperialMin()
        {
            BMI bmi = new BMI();
            bmi.WeightStones = 7;
            bmi.WeightPounds = 2;

            bmi.HeightFeet = 6;
            bmi.HeightInches = 4;

            bmi.CalculateBMI();

            double expectedBMI = 12;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]
        public void TestUnderweightMetricMin()
        {
            BMI bmi = new BMI();
            bmi.Weight = 45.5;
            bmi.Height = 1.93;
            bmi.CalculateBMI();

            double expectedBMI = 12;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestUnderweightImperialMax()
        {
            BMI bmi = new BMI();
            bmi.WeightStones = 7;
            bmi.WeightPounds = 2;
            bmi.HeightFeet = 5;
            bmi.HeightInches = 2;
            bmi.CalculateBMI();

            double expectedBMI = 18;
            Assert.AreEqual(expectedBMI, bmi.Bmi);

        }

        [TestMethod]

        public void TestUnderweightMEtricMax()
        {
            BMI bmi = new BMI();
            bmi.Weight = 45.5;

            bmi.Height = 1.574;

            bmi.CalculateBMI();

            double expectedBMI = 18;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestNormalImperialMin()
        {
            BMI bmi = new BMI();

            bmi.WeightStones = 7;
            bmi.WeightPounds = 2;

            bmi.HeightFeet = 5;
            bmi.HeightInches = 0;
            bmi.CalculateBMI();

            double expectedBMI = 19;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestNormalMetricMin()
        {
            BMI bmi = new BMI();

            bmi.Weight = 45.5;
            bmi.Height = 1.524;

            bmi.CalculateBMI();

            double expectedBMI = 19;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestNormalImperialMax()
        {
            BMI bmi = new BMI();

            bmi.WeightStones = 8;
            bmi.WeightPounds = 13;

            bmi.HeightFeet = 5;
            bmi.HeightInches = 0;

            bmi.CalculateBMI();
            double expectedBMI = 24;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestNormalMetricMAX()
        {
            BMI bmi = new BMI();

            bmi.Weight = 56.8;

            bmi.Height = 1.524;
            bmi.CalculateBMI();

            double expectedBMI = 24;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestOverweightImperialMin()
        {
            BMI bmi = new BMI();

            bmi.WeightStones = 9;
            bmi.WeightPounds = 4;

            bmi.HeightFeet = 5;
            bmi.HeightInches = 0;
            bmi.CalculateBMI();

            double expectedBMI = 25;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestOverweightMEtricMin()
        {
            BMI bmi = new BMI();

            bmi.Weight = 70.5;

            bmi.Height = 1.524;

            bmi.CalculateBMI();
            double expectedBMI = 30;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestOverweightImperialMax()
        {
            BMI bmi = new BMI();

            bmi.WeightStones = 10;
            bmi.WeightPounds = 10;
            bmi.HeightFeet = 5;
            bmi.HeightInches = 0;

            bmi.CalculateBMI();

            double expectedBMI = 29;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestOverweightMetricMax()
        {
            BMI bmi = new BMI();

            bmi.Weight = 68.2;
            bmi.Height = 1.524;

            bmi.CalculateBMI();
            double expectedBMI = 29;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestObeseImperialMin1()
        {
            BMI bmi = new BMI();

            bmi.WeightStones = 11;
            bmi.WeightPounds = 1;
            bmi.HeightFeet = 5;
            bmi.HeightInches = 0;
            bmi.CalculateBMI();

            double expectedBMI = 30;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestObeseMetricMin1()
        {
            BMI bmi = new BMI();

            bmi.Weight = 70.5;

            bmi.Height = 1.524;
            bmi.CalculateBMI();

            double expectedBMI = 30;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestObeseImperialMax2()
        {
            BMI bmi = new BMI();
            bmi.WeightStones = 12;
            bmi.WeightPounds = 7;
            bmi.HeightFeet = 5;
            bmi.HeightInches = 0;
            bmi.CalculateBMI();

            double expectedBMI = 34;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestObeseMetricMax1()
        {
            BMI bmi = new BMI();
            bmi.Weight = 79.5;

            bmi.Height = 1.524;

            bmi.CalculateBMI();

            double expectedBMI = 34;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }

        [TestMethod]

        public void TestObeseImperialMin2()
        {
            BMI bmi = new BMI();
            bmi.WeightStones = 12;
            bmi.WeightPounds = 12;

            bmi.HeightFeet = 5;
            bmi.HeightInches = 0;

            bmi.CalculateBMI();
            double expectedBMI = 35;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        }


        [TestMethod]
        public void TestObeseMetricMin2()
        {
            BMI bmi = new BMI();

            bmi.Weight = 81.8;
            bmi.Height = 1.524;
            bmi.CalculateBMI();

            double expectedBMI = 35;
            Assert.AreEqual(expectedBMI, bmi.Bmi);
        


        }
    }
}
