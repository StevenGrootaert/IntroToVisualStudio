using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int myAge = 19;
            myAge += 1;
            Console.WriteLine("Hello I'm " + myAge);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int myDogsAge = 4;
            myDogsAge += 1;
            Console.WriteLine("My dog is " + myDogsAge);
        }
    }
}
