using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class trenuri
    {
        public uint CalculDistanta(uint dintiala) {


            //pasarea zboara cu 2x pentru timpul pana la coliziunea trenurilor
            //distanta de parcurs pana la coliziune e d/2/2
            //trenurile se intalnesc la mijlocul distantei, dupa un timp t 
            //timpul pana la coliziune e distanta pana la coliziune pe viteza trenului tc=d/4x
            //distanta pasarii e viteza pasarii inmultit cu timpul pana la coliziune dp=2x*d/4x
            //viteza pasarii e in fn de viteza trenului, asa ca se simplifica viteza trenului si nu conteaza in calcul
            //dp=d/2 
           // uint trainspeed = 0;
           // uint birdspeed = 2 * trainspeed;
           // uint dtocollision = dintiala / 4; //distance till collision
           // uint timetocollision = dtocollision / trainspeed;
           // uint birddistance = timetocollision * birdspeed;
           // birddistance = dtocollision / trainspeed * birdspeed;
            //birddistance = dintiala * 2;

            return dintiala/2;

            
        }
        [TestMethod]
        public void TestMethod1()
        {

            uint dinitiala = 100;

            uint dpasare = CalculDistanta(dinitiala);

            Assert.AreEqual((uint)50, dpasare);

        }
        public void TestMethod2()
        {

            uint dinitiala = 0;

            uint dpasare = CalculDistanta(dinitiala);

            Assert.AreEqual((uint)0, dpasare);

        }
    }
}
