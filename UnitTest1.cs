using System;
using System.IO;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace TestProject2
{
    [TestFixture]
    [AllureNUnit]
    public class Tests
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Environment.CurrentDirectory = Directory.GetParent(Path.GetDirectoryName(GetType().Assembly.Location)).Parent.Parent.FullName;
            Console.WriteLine(Environment.CurrentDirectory);
        }

        [Test]
        public void Test1()
        {
            int a = 5;
            int b = 6;
            int c = a + b;
            Assert.AreEqual(7, c);
        }

        [Test]
        public void Test2()
        {
            int a = 5;
            int b = 6;
            int c = a + b;
            Assert.AreEqual(11, c);
        }
    }
}