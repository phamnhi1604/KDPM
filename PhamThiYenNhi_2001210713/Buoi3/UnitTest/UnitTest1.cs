using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void TC1_testTong2SoNguyen()
        {
            Tong sn = new Tong();
            int rs_Actual = sn.tinhtong(5, 7);
            int rs_Expect = 12;
            Assert.AreEqual(rs_Expect, rs_Actual);
        }

        [TestMethod]
        public void TC2_testTong2SoNguyen()
        {
            Tong sn = new Tong();
            int rs_Actual = sn.tinhtong(2, 7);
            int rs_Expect = 12;
            Assert.AreEqual(rs_Expect, rs_Actual); 
        }

        [TestMethod]
        public void TC1_TimMinMax()
        {
            TimMinMax mm = new TimMinMax();
            int rsMax, rsMin;
            mm.FMinMax(3, 7, 3, out rsMax, out rsMin);
            Assert.AreEqual(7, rsMax);
            Assert.AreEqual(3, rsMin);
        }
        [TestMethod]
        public void TC2_TimMinMax()
        {
            TimMinMax mm = new TimMinMax();
            int rsMax, rsMin;
            mm.FMinMax(3, 7, 3, out rsMax, out rsMin);
            Assert.AreEqual(7, rsMax);
            Assert.AreEqual(2, rsMin);
        }


        [TestMethod]
        public void TC1_tinhTienDien()
        {
            TienDien td = new TienDien();
            td.tinhtienDien
        }
    }
}
