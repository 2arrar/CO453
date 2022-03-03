using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class App01Test
    {
        DistanceConverter converter = new DistanceConverter();
        [TestMethod]
        public void TestFeetoToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ForUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();
            double expectedDistance = 10560;
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ForUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 10560;
            converter.CalculateDistance();
            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ForUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.METRES;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();
            double expectedDistance = 3218.68;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ForUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.MILES;
            converter.FromDistance = 3218.69;
            converter.CalculateDistance();
            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, (int)converter.ToDistance);
        }
        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ForUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;
            converter.FromDistance = 2.0;
            converter.CalculateDistance();
            double expectedDistance = 6.56168;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ForUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;
            converter.FromDistance = 6.56168;
            converter.CalculateDistance();
            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
