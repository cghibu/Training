using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coloane_Excel
{
    [TestClass]
    public class UnitTest1
    {

        public string GetColumnLabel(int colNum) {

            int resLength = 0;
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V","W", "X", "Y", "Z" };
            int Set = alphabet.Length;
            double order = (Math.Log(colNum, Set));
            double whole = Math.Truncate(order);
            if (whole == order) resLength = (int)whole;
            else resLength = (int)whole + 1;
            string[] resultlabel = new string[resLength];

            for (int i = 1; i <= resLength; i++) {

                int div = colNum / alphabet.Length;
                int mod = colNum % alphabet.Length;
                if (div < alphabet.Length) 

                resultlabel[i]= new (alphabet[div]);


            }


            return "A";
        }
        [TestMethod]
        public void ValidInputInAlphabet()
        {

            int colNum = 17;

            string result = GetColumnLabel(colNum);

            Assert.AreEqual("L", result, true);
            

        }
    }
}
