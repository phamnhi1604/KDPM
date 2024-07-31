using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest;
namespace UnitTest
{
    /// <summary>
    /// Summary description for UnitTest_BTTL
    /// </summary>
    [TestClass]
    public class UnitTest_BTTL
    {
        public UnitTest_BTTL()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Bai1

        [TestMethod]
        public void TestTamGiacDeu()
        {
            var tamGiac = new ktTamGiac();
            Assert.AreEqual("Tam giác đều", tamGiac.XacDinhTamGiac(5, 5, 5));
        }

        [TestMethod]
        public void TestTamGiacCan()
        {
            var tamGiac = new ktTamGiac();
            Assert.AreEqual("Tam giác cân", tamGiac.XacDinhTamGiac(5, 5, 8));
        }

        [TestMethod]
        public void TestTamGiacVuong()
        {
            var tamGiac = new ktTamGiac();
            Assert.AreEqual("Tam giác vuông", tamGiac.XacDinhTamGiac(3, 4, 5));
        }

        [TestMethod]
        public void TestTamGiacVuongCan()
        {
            var tamGiac = new ktTamGiac();
            Assert.AreEqual("Tam giác vuông cân", tamGiac.XacDinhTamGiac(1, 1, Math.Sqrt(2)));
        }

        [TestMethod]
        public void TestTamGiacThuong()
        {
            var tamGiac = new ktTamGiac();
            Assert.AreEqual("Tam giác thường", tamGiac.XacDinhTamGiac(4, 5, 6));
        }

        [TestMethod]
        public void TestKhongPhaiTamGiac()
        {
            var tamGiac = new ktTamGiac();
            Assert.AreEqual("Không phải tam giác", tamGiac.XacDinhTamGiac(1, 2, 3));
        }

        [TestMethod]
        public void TestCanhAmHoacZero()
        {
            var tamGiac = new ktTamGiac();
            Assert.AreEqual("Không phải tam giác", tamGiac.XacDinhTamGiac(0, -1, 5));
        }

        #endregion

        #region bai 4

        #endregion
    }
}
