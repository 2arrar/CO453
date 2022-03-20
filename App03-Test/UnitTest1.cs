using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace App03_Test
{
    [TestClass]
    public class TestApp3
    {
        private readonly StudentGrades studentgrades = new StudentGrades();

        private readonly int[] testMarks;

        private Grades[] testGrades;

        public TestApp3()
        {
            testMarks = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            testGrades = new Grades[10];
        }

        [TestMethod]
        public void TestConvert0toGradeF()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39toGradeF()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(39);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert40toGradeD()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(40);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49toGradeD()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(49);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert50toGradeC()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(50);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert59toGradeC()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(59);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert60toGradeB()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(60);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69toGradeB()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(69);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert70toGradeA()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(70);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100toGradeA()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = studentgrades.ConvertMarktoGrade(100);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            studentgrades.Marks = testMarks;
            double expectedMean = 55;

            studentgrades.CalculateMean();
            Assert.AreEqual(expectedMean, studentgrades.Mean);
        }

        [TestMethod]
        public void TestCalculateGradeProfile()
        {
            studentgrades.Marks = testMarks;
            for (int i = 0; i < 10; i++)
            {
                testGrades[i] = studentgrades.ConvertMarktoGrade(testMarks[i]);
            }
            studentgrades.Grades = testGrades;

            studentgrades.CalculateGradeProfile();
            bool expectedGradeProfile;
            expectedGradeProfile = ((studentgrades.Gradeprofile[0] == 30) &&
                                     (studentgrades.Gradeprofile[1] == 10) &&
                                     (studentgrades.Gradeprofile[2] == 10) &&
                                     (studentgrades.Gradeprofile[3] == 10) &&
                                     (studentgrades.Gradeprofile[4] == 40));

            Assert.IsTrue(expectedGradeProfile);
        }
    }
}
