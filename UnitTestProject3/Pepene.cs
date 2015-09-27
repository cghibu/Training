using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class Pepene
    {

        public string Pepenele(int numar) {
            if (numar > 0 && numar !=2 )
            {
                int mod = numar % 2;
                if (mod == 0) return "DA";
                return "NU";
                                
            }
            else return "NU";
        }

        [TestMethod]
        public void TestPepene1()
        {
            int numar = 12;
            string result = Pepenele(numar);
            Assert.AreEqual("DA",result);           
           
        }
        [TestMethod]
        public void TestPepene2()
        {
            int numar = 17;
            string result = Pepenele(numar);
            Assert.AreEqual("NU",result);

        }
        [TestMethod]
        public void TestPepene3()
        {
            int numar = -1;
            string result = Pepenele(numar);
            Assert.AreEqual("NU", result);

        }

        [TestMethod]
        public void TestPepene4()
        {
            int numar = 0;
            string result = Pepenele(numar);
            Assert.AreEqual("NU", result);

        }

        [TestMethod]
        public void TestPepene5()
        {
            int numar = 2;
            string result = Pepenele(numar);
            Assert.AreEqual("NU", result);

        }
    }

}
