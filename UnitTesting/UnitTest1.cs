using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VedioRental;

namespace DbTest
{
    [TestClass]
    public class UnitTest1
    {
        //defining an object with in the class Database from VedioRental
        VedioRental.Database.Database DBTest = new VedioRental.Database.Database();
        [TestMethod]
        public void TestDBConection()
        {
            // Variable of actual and expected connection String 
            var ActualDBCon = DBTest.constring;
            var ExpexctedDBCon = @"Data Source=DESKTOP-89NTJEN\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True";
            //Assert - checking the output is which expected
            Assert.AreEqual(ExpexctedDBCon, ActualDBCon);
        }
    }
}
