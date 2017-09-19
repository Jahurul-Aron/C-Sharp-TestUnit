using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzbuzzerClassLib;


namespace FizzbuzzClasslibTest
{
    [TestClass]
    public class FizzbuzzTest
    {
        [TestMethod]
        public void Buzzer_when1_return1()
        {
            //arrange
            int input = 1;
            //act
            string output = Fizzbuzz.Getvalue(input);

            //Assert
            Assert.AreEqual("1", output);
        }
        [TestMethod]
        public void Buzzer_when2_return2()
        {
            //arrange
            int input = 2;
            //act
            string output = Fizzbuzz.Getvalue(input);

            //Assert
       Assert.AreEqual("2", output);
        }
        [TestMethod]
        public void Buzzer_when3_returntoFizz()
        {
            //arrange
            int input = 3;
            //act
            string output = Fizzbuzz.Getvalue(input);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Fizz", output);
        }
    }
}
