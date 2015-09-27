using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class Ciuperci
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

           CollectionAssert.AreEqual(test,rezultat);
        }
        [TestMethod]
        public void Ciuperci2()
        {
            uint ntotal = 0;
            uint ratiorosii = 3;

            uint[] test = new uint[2];
            test[0] = 0;
            test[1] = 0;
            uint[] rezultat = CateCiuperciSunt(ntotal, ratiorosii);

            CollectionAssert.AreEqual(test, rezultat);
        }
        [TestMethod]
        public void Ciuperci3()
        {
            uint ntotal = 10;
            uint ratiorosii = 0;

            uint[] test = new uint[2];
            test[0] = 0;
            test[1] = 10;
            uint[] rezultat = CateCiuperciSunt(ntotal, ratiorosii);

            CollectionAssert.AreEqual(test, rezultat);
        }
        [TestMethod]
        public void Ciuperci4()
        {
            uint ntotal = 0;
            uint ratiorosii = 0;

            uint[] test = new uint[2];
            test[0] = 0;
            test[1] = 0;
            uint[] rezultat = CateCiuperciSunt(ntotal, ratiorosii);

            CollectionAssert.AreEqual(test, rezultat);
        }
        [TestMethod]
        public void Ciuperci5()
        {
            uint ntotal = 51;
            uint ratiorosii = 4;

            uint[] test = new uint[2];
            test[0] = 41;
            test[1] = 10;
            uint[] rezultat = CateCiuperciSunt(ntotal, ratiorosii);

            CollectionAssert.AreEqual(test, rezultat);
        }
        [TestMethod]
        public void Ciuperci6()
        {
            uint ntotal = 1;
            uint ratiorosii = 1;

            uint[] test = new uint[2];
            test[0] = 1;
            test[1] = 0;
            uint[] rezultat = CateCiuperciSunt(ntotal, ratiorosii);

            CollectionAssert.AreEqual(test, rezultat);
        }
        [TestMethod]
        public void Ciuperci7()
        {
            uint ntotal = 2;
            uint ratiorosii = 2;

            uint[] test = new uint[2];
            test[0] = 2;
            test[1] = 0;
            uint[] rezultat = CateCiuperciSunt(ntotal, ratiorosii);

            CollectionAssert.AreEqual(test, rezultat);
        }
        [TestMethod]
        public void Ciuperci8()
        {
            uint ntotal = 3;
            uint ratiorosii = 5;

            uint[] test = new uint[2];
            test[0] = 3;
            test[1] = 0;
            uint[] rezultat = CateCiuperciSunt(ntotal, ratiorosii);

            CollectionAssert.AreEqual(test, rezultat);
        }
    }
}
