using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testclass = new ImplementClass();
            var resual = testclass.ImplementTest();
        }


        [Fact]
        public void xxx()
        {

        }
    }
}
