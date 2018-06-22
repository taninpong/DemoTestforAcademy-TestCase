using System;
using Xunit;
using ConsoleApp1;

namespace TestClass
{
   
    public class UnitTest1
    {
        [Fact]
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