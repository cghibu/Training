using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bricks
{
    [TestClass]
    public class UnitTest1
    {
        void LogError(string description)
        {
            //log to file here
        }
        int CalculateBricks(int AreaHight, int AreaWidth, int BrickLength)
        {

            // Basic Validation

            try
            {
                if (AreaHight > 0 && AreaWidth > 0 && BrickLength >0 && BrickLength <= AreaHight && BrickLength <= AreaWidth)
                {

                    //Calculus
                                       
                        double BricksLong= Math.Ceiling((double)AreaHight / (double)BrickLength);
                        double BricksWide = Math.Ceiling((double)AreaWidth / (double)BrickLength);
                        int AmountBricks = (int)BricksLong * (int)BricksWide;
                        return (int)AmountBricks;
                 }             
               else
               {
                    LogError("Invlaid input");
                    return -2;
                }
            }
            catch (Exception)
            {
                LogError("Other error");
                return -3;
            }
        }
        [TestMethod]
        public void ValidValuesTest0() //random valid values <100
        {

            int Ahight = 6;
            int AWidth = 6;
            int BLength = 4;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(4, Result);
        }
        [TestMethod]
        public void ValidValuesTest1() //random valid values <100
        {

            int Ahight = 100;
            int AWidth = 300;
            int BLength = 20;
            
            int Result= CalculateBricks(Ahight,AWidth,BLength);

            Assert.AreEqual(75, Result);
        }
        [TestMethod]
        public void ValidValuesTest2() //random valid values < 1000
        {

            int Ahight = 900;
            int AWidth = 800;
            int BLength = 113;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(64, Result);
        }
        [TestMethod]
        public void ValidValuesTest3() //random valid values < 10000
        {

            int Ahight = 9997;
            int AWidth = 6760;
            int BLength = 219;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(1426, Result);
        }
        [TestMethod]
        public void InvalidValuesTest1() //negative area hight
        {
            int Ahight = -100;
            int AWidth = 300;
            int BLength = 20;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void InvalidValuesTest2() //negative area width
        {
            int Ahight = 100;
            int AWidth = -300;
            int BLength = 20;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void InvalidValuesTest3() //negative brick size
        {
            int Ahight = 100;
            int AWidth = 300;
            int BLength = -20;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void InvalidValuesTest4() //zero area hight
        {
            int Ahight = 0;
            int AWidth = 300;
            int BLength = 20;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void InvalidValuesTest5()//zero area width
        {
            int Ahight = 100;
            int AWidth = 0;
            int BLength = 20;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void InvalidValuesTest6()//zero brick size
        {
            int Ahight = 100;
            int AWidth = 300;
            int BLength = 0;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void InvalidValuesTest8()//Min int values
        {
            int Ahight = Int32.MinValue;
            int AWidth = Int32.MinValue;
            int BLength = Int32.MinValue;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void InvalidValuesTest9()//all zero
        {
            int Ahight = 0;
            int AWidth = 0;
            int BLength = 0;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void BoundryTest1() //Min positive values
        {
            int Ahight = 1;
            int AWidth = 1;
            int BLength =1;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(1, Result);

        }
        [TestMethod]
        public void BoundryTest2() //Max values
        {
            int Ahight = Int32.MaxValue;
            int AWidth = Int32.MaxValue;
            int BLength = Int32.MaxValue;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(1, Result);

        }
        [TestMethod]
        public void BoundryTest3() //Brick larger than hight
        {
            int Ahight = 10;
            int AWidth = 100;
            int BLength = 11;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }
        [TestMethod]
        public void BoundryTest4() //Brick larger than width
        {
            int Ahight = 120;
            int AWidth = 17;
            int BLength = 18;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(-2, Result);

        }

    }

}
