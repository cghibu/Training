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
                if (AreaHight > 0 & AreaWidth > 0 & BrickLength >0 & BrickLength <= AreaHight & BrickLength <= AreaWidth)
                {

                    //Calculus
                    try
                    {
                        int AreaSurface = AreaHight * AreaWidth;
                        int BrickSurface = BrickLength * BrickLength;
                        double AmountBricks = Math.Ceiling((double)AreaSurface / (double)BrickSurface);
                        return (int)AmountBricks;

                    }
                    catch (OverflowException)
                    {
                        try
                        {
                            long LAreaSurface = Convert.ToInt64(AreaHight) * Convert.ToInt64(AreaWidth);
                            long LBrickSurface = Convert.ToInt64(BrickLength) * Convert.ToInt64(BrickLength);
                            double LAmountBricks = Math.Ceiling((double)LAreaSurface / (double)LBrickSurface);
                            return (int)LAmountBricks;
                        }
                        catch (InvalidCastException f)
                        {
                            if (f.Source != null) LogError(f.Source);
                            return -1;
                        }
                    }
                    
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

            Assert.AreEqual(57, Result);
        }
        [TestMethod]
        public void ValidValuesTest3() //random valid values < 10000
        {

            int Ahight = 9997;
            int AWidth = 6760;
            int BLength = 219;

            int Result = CalculateBricks(Ahight, AWidth, BLength);

            Assert.AreEqual(1410, Result);
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
