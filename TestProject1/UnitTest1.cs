using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;
using WinFormsApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Generator generator = new Generator(0, 1);
            Assert.AreEqual(1, generator.values.Count);

        }
        [TestMethod]
        public void TestRun()

        {
            for(int i=1; i<10;i++)
            {
                Generator generator = new Generator(10,i);
                var result = generator.Run(0);
                Assert.IsTrue(result.items.Count==0);
            }
        }
    }
    
}