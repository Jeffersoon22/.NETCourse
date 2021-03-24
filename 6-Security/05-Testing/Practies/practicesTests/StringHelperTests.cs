using Microsoft.VisualStudio.TestTools.UnitTesting;
using practices;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;




namespace practices.Tests
{
    [TestClass()]
    public class StringHelperTests
    {
        private Mock<IHttpService> httpMock = new Mock<IHttpService>();
        [TestMethod()]
        public void ContainsVowelTest()
        {
            string TestString = "we must seize the means of production";
            var expected = true;
            var stringHelper = new StringHelper(httpMock.Object);
            var result = stringHelper.ContainsVowel(TestString);
            Assert.AreEqual(expected, result);
        }



        [TestMethod()]
        public void ContainsSubstringTest()
        {
            string TestString = "we must seize the means of production";
            string SubString = "production";
            var expected = true;
            var stringHelper = new StringHelper(httpMock.Object);
            var result = stringHelper.ContainsSubstring
                (TestString, SubString);
            Assert.AreEqual(expected, result);
        }




        [TestMethod()]
        public void ReverseStringTest()
        {
            string TestString = "we must seize the means of production";
            var expected = "noitcudorp fo snaem eht ezies tsum ew";
            var stringHelper = new StringHelper(httpMock.Object);
            var result = stringHelper.ReverseString(TestString);
            Assert.AreEqual(expected, result);
        }
    }
}