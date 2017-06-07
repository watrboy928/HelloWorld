using System;
using OutputClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            Output outputClass = new Output();
            Assert.AreEqual(outputClass.output, "Hello World");
        }

        [TestMethod]
        public void TestConstructor()
        {
            Output outputClass = new Output("Hello World!!!");
            Assert.AreEqual(outputClass.output, "Hello World!!!");
        }

        //these unit tests actually found bugs in my code (unit tests are very important in my opinion)
        [TestMethod]
        public void TestGetJSONString()
        {
            Output outputClass = new Output();
            Assert.AreEqual(outputClass.getJSONString(), @"{output : 'Hello World'}");

            Output outputClass2 = new Output("Hello friend");
            Assert.AreEqual(outputClass2.getJSONString(), @"{output : 'Hello friend'}");
        }

    }
}
