using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MinhQuan56;

namespace MinhQuan56Tester
{
    [TestClass]
    public class UnitTest1
    {
        private MinhQuan_56 c;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestMethod1()
        {
            c = new MinhQuan_56(10,5);
        }
        [TestMethod]
        public void Test_Cong()
        {
            int expected, actual;
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }




        
        [TestMethod]
        public void Test_Tru()
        {
            int expected, actual;
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }




       
        [TestMethod]
        public void Test_Nhan()
        {
            int expected, actual;
            expected = 50;
            actual = c.Execute("x");
            Assert.AreEqual(expected, actual);
        }






       
        [TestMethod]
        public void Test_Chia()
        {
            int expected, actual;
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }






        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new MinhQuan_56(10, 0);
            c.Execute("/");
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TextMinhQuan56.csv", "TextMinhQuan56#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            int a, b, expected, actual;

            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new MinhQuan_56(a, b);
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

    }
}
