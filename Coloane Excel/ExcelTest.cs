using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coloane_Excel
{
    [TestClass]
    public class ExcelTest
    {
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public string GetLetter(int index)
        {

            string result="";
            if (index < alphabet.Length)
            {
                result = alphabet[index - 1];
                return result;
            }
            else
            {
                int mod = index % alphabet.Length;
                if (mod > 0)
                     result = alphabet[mod - 1];
                else
                {
                    result = alphabet[alphabet.Length - 1];
                    return result;
                }
                
            }
            index = index / alphabet.Length;
            result = GetLetter(index)+result;
            return result;
        }

          
        
        public string GetColumnLabel(int colNum) {


            string label="";
            label=GetLetter(colNum);
            return label;
        }
        [TestMethod]
        public void ValidInputInAlphabet()
        {

            int colNum = 17;
            string good = "Q";
            string result = GetColumnLabel(colNum);
             Assert.AreEqual(good, result);
            

        }
        [TestMethod]
        public void ValidInputInAlphabet1()
        {

            int colNum = 26;
            string good = "Z";
            string result = GetColumnLabel(colNum);
            Assert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet2()
        {

            int colNum = 27;
            string good =  "AA";
            string result = GetColumnLabel(colNum);
            Assert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet22()
        {

            int colNum = 50;
            string good = "AX";
            string result = GetColumnLabel(colNum);
            Assert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet23()
        {

            int colNum = 60;
            string good = "BH";
            string result = GetColumnLabel(colNum);
            Assert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet3()
        {

            int colNum = 680;
            string good = "ZD";
            string result = GetColumnLabel(colNum);
            Assert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet33()
        {

            int colNum = 16384;
            string good = "XFD";
            string result = GetColumnLabel(colNum);
            Assert.AreEqual(good, result);


        }
    }
}
