using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {

        public uint[] CateCiuperciSunt(uint ntotal, uint ratiorosii) {

            uint nrosii = 0;
            uint nalbe = 0;
            nalbe = ntotal/(1+ratiorosii);
            nrosii = ntotal - nalbe;
            uint[] result = new uint[2];
            result[0] = nrosii;
            result[1] = nalbe;
            return result;

        }

        [TestMethod]
        public void Ciuperci1()
        {
            uint ntotal = 100;
            uint ratiorosii = 3;

            uint[] test = new uint[2];
            test[0] = 75;
            test[1] = 25;
            uint[] rezultat = CateCiuperciSunt(ntotal,ratiorosii);

            Assert.AreEqual(test,rezultat);
        }
    }
}
