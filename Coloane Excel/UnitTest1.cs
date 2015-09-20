using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coloane_Excel
{
    [TestClass]
    public class UnitTest1
    {
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string[] GetLastLetter(int index, int alphabetlength, int recurrsion)
        {
            string[] result = new string[recurrsion];
            int div = index / alphabetlength;
            int mod = index % alphabetlength;

            if (recurrsion >= 1) result[recurrsion - 1] = alphabet[mod - 1];
            else throw new IndexOutOfRangeException();
            if (div <= alphabetlength) {
                if (div >= 1) result[recurrsion - recurrsion] = alphabet[div - 1];
                else if (recurrsion > 1 ) result[recurrsion - recurrsion] = alphabet[recurrsion]; 
                else return result;
                return result;
            }
            else
            {
                return GetLastLetter(div, alphabetlength, recurrsion - 1);

            }
              
            
        }
        public string[] GetColumnLabel(int colNum) {

            int resLength = 0;
            int Set = alphabet.Length;
            double order = (Math.Log(colNum, Set));
            double whole = Math.Truncate(order);
            if (whole == order) resLength = (int)whole;
            else resLength = (int)whole + 1;
            return GetLastLetter(colNum, Set, resLength);
                      
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
        public void ValidInputInAlphabet3()
        {

            int colNum = 680;
            string[] good = { "A", "A","D" };
            string[] result = GetColumnLabel(colNum);
            CollectionAssert.AreEqual(good, result);


        }

    }
}
