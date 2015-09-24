using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class Coloane
    {
        public double CalculateArea(double[] coo1, double[] coo2, double[] coo3) {

                double[] triangle = new double[3] { 0, 0, 0, };
                triangle[0] = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(coo1[0] - coo2[0]), 2) + Math.Pow(Math.Abs(coo1[1] - coo2[1]), 2)), 6);
                triangle[1] = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(coo1[0] - coo3[0]), 2) + Math.Pow(Math.Abs(coo1[1] - coo3[1]), 2)), 6);
                triangle[2] = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(coo2[0] - coo3[0]), 2) + Math.Pow(Math.Abs(coo2[1] - coo3[1]), 2)), 6);

            if (triangle[0] != 0 && triangle[1] != 0 && triangle[2] != 0)
            {
                double p = Math.Round(((triangle[0] + triangle[1] + triangle[2]) / 2), 6);
                double result = Math.Round((Math.Sqrt(p * (p - triangle[0]) * (p - triangle[1]) * (p - triangle[2]))), 6);
                return result;
            }
            
            return 0;
       }
        [TestMethod]
        public void TestColoane1() // exemplul simplu din text
        {
            double[] coo1 = new double[2] { 0, 0 };
            double[] coo2 = new double[2] { 0, 1 };
            double[] coo3 = new double[2] { 1, 1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(0.5, surface);

        }

        [TestMethod]
        public void TestColoane12() //cadranul 1, cadranul 1, cadranul 1
        {
            double[] coo1 = new double[2] { 11, 2 };
            double[] coo2 = new double[2] { 12.9, 100 };
            double[] coo3 = new double[2] { 0, 16 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(552.299978, surface);

        }
        [TestMethod]
        public void TestColoane13() //cadranul 2, cadranul 2, cadranul 2
        {
            double[] coo1 = new double[2] { 11, -2 };
            double[] coo2 = new double[2] { 12.9, -100 };
            double[] coo3 = new double[2] { 0, -16 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(552.299978, surface);

        }
        [TestMethod]
        public void TestColoane14() //cadranul 3, cadranul 3, cadranul 3
        {
            double[] coo1 = new double[2] { -11,- 2 };
            double[] coo2 = new double[2] { -12.9,-100 };
            double[] coo3 = new double[2] { -1, -16 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(503.29992, surface);

        }
        [TestMethod]
        public void TestColoane15() //cadranul 4, cadranul 4, cadranul 4
        {
            double[] coo1 = new double[2] { -11, 2 };
            double[] coo2 = new double[2] { 12.9, -100 };
            double[] coo3 = new double[2] { 35, -16 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(2130.900052, surface);

        }
        [TestMethod]
        public void TestColoane2() //cadranul 1, cadranul 2, cadranul 4
        {
            double[] coo1 = new double[2] {1,1};
            double[] coo2 = new double[2] {1,-1};
            double[] coo3 = new double[2] { -1, 1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(2.000002, surface);

        }
        [TestMethod]
        public void TestColoane21() //cadranul 1, cadranul 2, cadranul 3
        {
            double[] coo1 = new double[2] { 1, 1 };
            double[] coo2 = new double[2] { 1, -1 };
            double[] coo3 = new double[2] { -1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(2.000002, surface);

        }
        [TestMethod]
        public void TestColoane22() //cadranul 1, cadranul 2, cadranul 2
        {
            double[] coo1 = new double[2] { 1, 1 };
            double[] coo2 = new double[2] { 1, -1 };
            double[] coo3 = new double[2] { 1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(0, surface);

        }
        [TestMethod]
        public void TestColoane23() //cadranul 1, cadranul 1, cadranul 2
        {
            double[] coo1 = new double[2] { 1, 1 };
            double[] coo2 = new double[2] { 1, 1 };
            double[] coo3 = new double[2] { 1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(0, surface);

        }

        [TestMethod]
        public void TestColoane24() //cadranul 1, cadranul 1, cadranul 3
        {
            double[] coo1 = new double[2] { 1, 1 };
            double[] coo2 = new double[2] { 1, 1 };
            double[] coo3 = new double[2] { -1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(0, surface);

        }
        [TestMethod]
        public void TestColoane25() //cadranul 1, cadranul 1, cadranul 4
        {
            double[] coo1 = new double[2] { 1, 1 };
            double[] coo2 = new double[2] { 1, 1 };
            double[] coo3 = new double[2] { -1, 1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(0, surface);

        }

        [TestMethod]
        public void TestColoane3() //cadranul 2, cadranul 1, cadranul 3
        {
            double[] coo1 = new double[2] { 12.564453, -1 };
            double[] coo2 = new double[2] { 1, 43.332221 };
            double[] coo3 = new double[2] { -1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(300.671138, surface);

        }
        [TestMethod]
        public void TestColoane31() //cadranul 2, cadranul 1, cadranul 4
        {
            double[] coo1 = new double[2] { 12.564453, -1 };
            double[] coo2 = new double[2] { 1, 43.332221 };
            double[] coo3 = new double[2] { -1, 1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(289.106701, surface);

        }
        [TestMethod]
        public void TestColoane4() //cadranul 3, cadranul 1 , cadranul 2
        {
            double[] coo1 = new double[2] { -12.564453, -1 };
            double[] coo2 = new double[2] { 1, 43.332221 };
            double[] coo3 = new double[2] { 1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(300.67119, surface);

        }
        [TestMethod]
        public void TestColoane41() //cadranul 3, cadranul 1, cadranul 4
        {
            double[] coo1 = new double[2] { 12.564453, -1 };
            double[] coo2 = new double[2] { 1, 43.332221 };
            double[] coo3 = new double[2] { -1, 1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(289.106701, surface);

        }
        [TestMethod]
        public void TestColoane5() //cadranul 4, cadranul 1, cadranul 2
        {
            double[] coo1 = new double[2] { -12.564453, 1 };
            double[] coo2 = new double[2] { 1, 43.332221 };
            double[] coo3 = new double[2] { 1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(300.671155, surface);

        }
        [TestMethod]
        public void TestColoane51() //cadranul 4, cadranul 1, cadranul 3
        {
            double[] coo1 = new double[2] { -12.564453, 1 };
            double[] coo2 = new double[2] { 1, 43.332221 };
            double[] coo3 = new double[2] { -1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(258.338953, surface);

        }
        [TestMethod]
        public void TestColoane52() //cadranul 4, cadranul 3, cadranul 2
        {
            double[] coo1 = new double[2] { -12.564453, 1 };
            double[] coo2 = new double[2] { -1,- 43.332221 };
            double[] coo3 = new double[2] { 1, -1 };
            double surface = -1;

            surface = CalculateArea(coo1, coo2, coo3);

            Assert.AreEqual(289.106701, surface);

        }
    }

}
