using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coloane_Excel
{
    [TestClass]
    public class UnitTest1
    {
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        int iteratie = 0;
        public List<string> GetLetter(int index)
        {

            List < string > result = new List<string>();
            int div = index / alphabet.Length;
            int mod = index % alphabet.Length;
            iteratie++;

            if (div < 1)
            {
                if (mod == 0) result.Add(alphabet[alphabet.Length - 1]);
                else result.Add(alphabet[mod - 1]);
               
            }
            else {
                result.InsertRange(0, GetLetter(div));
                if (mod == 0) result.Add(alphabet[alphabet.Length - 1]);
                else result.Add(alphabet[mod - 1]);
                             
            }
            return result;


        }          
        
        public string[] GetColumnLabel(int colNum) {


            List<string> label = new List<string>();
            label=GetLetter(colNum);
            return label.ToArray();          
        }
        [TestMethod]
        public void ValidInputInAlphabet()
        {

            int colNum = 17;
            string[] good = { "Q" };
            string[] result = GetColumnLabel(colNum);
             CollectionAssert.AreEqual(good, result);
            

        }

        [TestMethod]
        public void ValidInputInAlphabet2()
        {

            int colNum = 27;
            string[] good = { "A","A" };
            string[] result = GetColumnLabel(colNum);
            CollectionAssert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet22()
        {

            int colNum = 50;
            string[] good = { "A", "X" };
            string[] result = GetColumnLabel(colNum);
            CollectionAssert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet23()
        {

            int colNum = 60;
            string[] good = { "B", "H" };
            string[] result = GetColumnLabel(colNum);
            CollectionAssert.AreEqual(good, result);


        }
        [TestMethod]
        public void ValidInputInAlphabet3()
        {

            int colNum = 680;
            string[] good = { "Z", "D" };
            string[] result = GetColumnLabel(colNum);
            CollectionAssert.AreEqual(good, result);


        }

    }
}
