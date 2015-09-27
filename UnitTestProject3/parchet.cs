using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class parchet
    {
        public uint CalculatePlaques(double room_length, double room_width, double plaque_length, double plaque_width) {

            if (room_length <= 0 || room_width <= 0 || plaque_length <= 0 || plaque_width <= 0) return 0;
            double room_area = room_length * room_width;
            double plaque_area = plaque_length * plaque_width;
            if (room_area >= plaque_area)
                    {
                        double result = Math.Ceiling((room_area / plaque_area) + (room_area / plaque_area) * 15 / 100);
                        return (uint)result;
                    }
            else return 1;
                     
     }


        [TestMethod]
        public void TestParchet1() //all 0
        {
            double room_length = 0;
            double room_width = 0;
            double plaque_length = 0;
            double plaque_width = 0;

            uint result = CalculatePlaques(room_length, room_width, plaque_length, plaque_width);
            Assert.AreEqual((uint)0, result);



        }

        [TestMethod]
        public void TestParchet2() // some natural values
        {
            uint room_length = 10;
            uint room_width = 15;
            uint plaque_length = 2;
            uint plaque_width = 1;

            uint result = CalculatePlaques(room_length, room_width, plaque_length, plaque_width);
            Assert.AreEqual((uint)87, result);



        }
        [TestMethod] 
        public void TestParchet3() // some real values
        {
            double room_length = 10.3;
            double room_width = 15.1;
            double plaque_length = 2.25;
            double plaque_width = 1.6;

            uint result = CalculatePlaques(room_length, room_width, plaque_length, plaque_width);
            Assert.AreEqual((uint)50, result);

        }

        [TestMethod]
        public void TestParchet4() //all negatives
        {
            double room_length = -10.3;
            double room_width = -15.1;
            double plaque_length = -2.25;
            double plaque_width = -1.6;

            uint result = CalculatePlaques(room_length, room_width, plaque_length, plaque_width);
            Assert.AreEqual((uint)0, result);

        }
        [TestMethod]
        public void TestParchet5() //one dimension negative for both
        {
            double room_length = 10.3;
            double room_width = -15.1;
            double plaque_length = 2.25;
            double plaque_width = -1.6;

            uint result = CalculatePlaques(room_length, room_width, plaque_length, plaque_width);
            Assert.AreEqual((uint)0, result);

        }
        [TestMethod]
        public void TestParchet6() // room smaller than plaque
        {
            double room_length = 2;
            double room_width = 3.5;
            double plaque_length = 8;
            double plaque_width = 1.2;

            uint result = CalculatePlaques(room_length, room_width, plaque_length, plaque_width);
            Assert.AreEqual((uint)1, result);

        }

    }
}
