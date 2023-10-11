using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint1.Task4.V29.Lib;

namespace Tyuiu.KubrikND.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1 / 12;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
