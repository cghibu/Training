using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coloane_Excel
{
    [TestClass]
    public class ExcelTest
    {
        int baza = 26; //baza
        int startpos = 65; //pos of A char
        public string GetLetter(int index)
        {

            string result="";
            char c=(char)65;
            int temp=0;
            if (index < baza)
            {
                temp= startpos + index - 1;
                c = (char)temp;
                result = c.ToString();
                return result;
            }
            else
            {
                int mod = index % baza;
                if (mod > 0)
                {
                    temp = startpos + mod - 1;
                    c = (char)temp;
                    result = c.ToString();
                }
                else
                {
                    temp = startpos + baza - 1;
                    c = (char)temp;
                    result = c.ToString();
                    return result;
                }
                
            }
            index = index / baza;
            result = GetLetter(index)+result;
            return result;
        }

          
        
        public string GetColumnLabel(int colNum) {

            string label="";
            label = GetLetter(colNum);
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
