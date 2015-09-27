using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class DobandaDescrescatoare
    {
        public double CalculateLoanDescending(double amount, double yearlyrate, double periodinmonths, uint monthtocalculate)
        {

            if (amount > 0 && yearlyrate >= 0 && periodinmonths > 0 && monthtocalculate > 0 && monthtocalculate <= periodinmonths)
            {
                double amountpermonth = Math.Round(amount / periodinmonths, 3);
                double interestratepermonth = Math.Round(yearlyrate / 12, 3);
                double interestpermonth = Math.Round(((interestratepermonth / 100) * (periodinmonths - monthtocalculate + 1) * amountpermonth), 3);
                return amountpermonth + interestpermonth;
            }
            return 0;

        }

        [TestMethod]
        public void TestMethod1()
        {

            double amount = 100000;
            double yearlyrate = 7.5;
            double periodinmonths = 60;
            uint monthtocalculate = 5;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(2250, result, 0.01);

        }

        [TestMethod]
        public void TestMethod2()
        {

            double amount = -1;
            double yearlyrate = 7.5;
            double periodinmonths = 60;
            uint monthtocalculate = 5;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(0, result, 0.01);

        }
        [TestMethod]
        public void TestMethod3()
        {

            double amount = 1;
            double yearlyrate = -7.5;
            double periodinmonths = 60;
            uint monthtocalculate = 5;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(0, result, 0.01);

        }
        [TestMethod]
        public void TestMethod4()
        {

            double amount = 1;
            double yearlyrate = 7.5;
            double periodinmonths = -60;
            uint monthtocalculate = 5;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(0, result, 0.01);

        }
        [TestMethod]
        public void TestMethod5()
        {

            double amount = 100000;
            double yearlyrate = 7.5;
            double periodinmonths = 60;
            uint monthtocalculate = 1;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(2291.667, result, 0.01);

        }
        [TestMethod]
        public void TestMethod6()
        {

            double amount = 100000;
            double yearlyrate = 7.5;
            double periodinmonths = 60;
            uint monthtocalculate = 60;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(1677.083, result, 0.01);

        }
        [TestMethod]
        public void TestMethod7()
        {

            double amount = 100000;
            double yearlyrate = 100;
            double periodinmonths = 60;
            uint monthtocalculate = 35;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(5277.778, result, 0.01);

        }
        [TestMethod]
        public void TestMethod8()
        {

            double amount = 100000;
            double yearlyrate = 7.5;
            double periodinmonths = 60;
            uint monthtocalculate = 120;

            double result = CalculateLoanDescending(amount, yearlyrate, periodinmonths, monthtocalculate);
            Assert.AreEqual(0, result, 0.01);

        }
    }
    }
