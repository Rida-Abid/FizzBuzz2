using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzz2.Test
{
    [TestClass]
    public class ProcessTest
    {
        [TestMethod]
        public void TestwithMissingParameters()
        {
            var uut = new Logic();
            var result = uut.Process(3, 5, 50);
            Assert.IsNotNull(result);
            Assert.AreEqual(50, result.Count());
            Assert.AreEqual("1", result.FirstOrDefault());
            Assert.AreEqual("fizz", result[2]);
            Assert.AreEqual("buzz", result[4]);
            Assert.AreEqual("fizzbuzz", result[14]);
        }

        [TestMethod]
        public void TestwithSameParameters()
        {
            var uut = new Logic();
            var result = uut.Process(3, 3, 3);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual("1", result.FirstOrDefault());
            Assert.AreEqual("fizzbuzz", result[2]);

        }

        [TestMethod]
        public void TestwithFirstTwoParametersSame()
        {
            var uut = new Logic();
            var result = uut.Process(5, 5, 60);
            Assert.IsNotNull(result);
            Assert.AreEqual(60, result.Count());
            Assert.AreEqual("1", result.FirstOrDefault());
            Assert.AreEqual("fizzbuzz", result[4]);

        }

        [TestMethod]
        public void TestwithLastTwoParametersSame()
        {
            var uut = new Logic();
            var result = uut.Process(3, 8, 8);
            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Count());
            Assert.AreEqual("1", result.FirstOrDefault());
            Assert.AreEqual("fizz", result[2]);
            Assert.AreEqual("buzz", result[7]);

        }

        [TestMethod]
        public void TestwithFirstAndLastParametersSame()
        {
            var uut = new Logic();
            var result = uut.Process(5, 9, 5);
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            Assert.AreEqual("1", result.FirstOrDefault());
            Assert.AreEqual("fizz", result[4]);
            
        }

        [TestMethod]
        public void TestwithAnyOneParameterAsZero()
        {
            var uut = new Logic();
            var result = uut.Process(0, 5, 50);
            Assert.IsNotNull(result);
            Assert.AreEqual(50, result.Count());
            Assert.AreEqual("0", result.FirstOrDefault());
            

        }

        [TestMethod]
        public void TestwithNegativemaxCount()
        {
            var uut = new Logic();
            var result = uut.Process(3, 5, -50);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Please enter a maxCount of more than 0", result.FirstOrDefault());
        }




    }
    
}