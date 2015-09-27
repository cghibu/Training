using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class Student
    {
        public uint CateRepetari(uint n) {

            uint result = n * n;
            return result;

        }


        [TestMethod]
        public void TestStudent1()
        {

            uint n = 21;
           
            uint result = CateRepetari(n);

            Assert.AreEqual((uint)441, result);


        }
        [TestMethod]
        public void TestStudent2()
        {

            uint n = 1;

            uint result = CateRepetari(n);

            Assert.AreEqual((uint)1, result);


        }
        [TestMethod]
        public void TestStudent3()
        {

            uint n = 0;

            uint result = CateRepetari(n);

            Assert.AreEqual((uint)0, result);


        }
    }
}
