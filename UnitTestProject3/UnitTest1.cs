using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        public double catmananca(int capre, int zile, double kile, int catecapre, int catezile) {

                return catecapre * catezile * kile / (capre * zile);
               
          
    }
        [TestMethod]
        public void TestCapre1()
        {
            int capre = 10;
            int zile = 2;
            double kile = 200;
            int catecapre = 12;
            int catezile = 2;

            double catekile = catmananca(capre, zile, kile, catecapre, catezile);

            Assert.AreEqual(240, catekile,0);

        }
        [TestMethod]
        public void TestCapre2()
        {
            int capre = 111;
            int zile = 22;
            double kile = 1856.36;
            int catecapre = 2250;
            int catezile = 12;

            double catekile = catmananca(capre, zile, kile, catecapre, catezile);

            Assert.AreEqual(20524.86, catekile,0.01);

        }
        [TestMethod]
        public void TestCapre3()
        {
            int capre = 111789;
            int zile = 22533;
            double kile = 0;
            int catecapre = 1;
            int catezile = 1;

            double catekile = catmananca(capre, zile, kile, catecapre, catezile);

            Assert.AreEqual(0, catekile, 0);

        }
        [TestMethod]
        public void TestCapre4()
        {
            int capre =1;
            int zile = 1;
            double kile = 0;
            int catecapre = 1;
            int catezile = 1;

            double catekile = catmananca(capre, zile, kile, catecapre, catezile);

            Assert.AreEqual(0, catekile, 0);

        }
        [TestMethod]
        public void TestCapre5()
        {
            int capre = 1;
            int zile = 1;
            double kile = 1213415167.89;
            int catecapre = 1;
            int catezile = 1;

            double catekile = catmananca(capre, zile, kile, catecapre, catezile);

            Assert.AreEqual(1213415167.89, catekile, 0);

        }

    }


}
