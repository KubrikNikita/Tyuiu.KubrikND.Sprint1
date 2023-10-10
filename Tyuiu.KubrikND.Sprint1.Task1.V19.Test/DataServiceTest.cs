using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint1.Task1.V19.Lib;

namespace Tyuiu.KubrikND.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);
        }
    }
}
