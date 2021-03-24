using Tutorials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace Tutorials.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private Mock<IHttpService> httpServiceMock = new Mock<IHttpService>();

        [TestMethod()]
        public void AddTest()
        {

            //arrange
            double a = 75;
            double b = 25;
            double expected = 100;

            var calculator = new Calculator(httpServiceMock.Object);

            //act

            var result = calculator.Add(a, b);

            //assert

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SubstractTest()
        {

            //arrange
            double a = 75;
            double b = 25;
            
            double originalA = 75;
            double originalB = 25;
            double expected = 50;

            var calculator = new Calculator(httpServiceMock.Object);


            //act

            var result = calculator.Substract(a,b);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            //arrange
            var fakeResult = 0;
            httpServiceMock.Setup(x => x.SendResult(fakeResult))
                .Returns("Very successful HTTP result");



            double a = 2;
            double b = 2;
            double expected = 4;

            var calculator = new Calculator(httpServiceMock.Object);

            //act

            var result = calculator.Multiply(a, b);

            //assert

            Assert.AreEqual(expected, result);
        }

        
    }
}