using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Models.Tests
{
    [TestClass()]
    public class HoaDonTests
    {
        [TestMethod()]
        public void KiemTraHopLeTestException()
        {
            HoaDon hoaDon = new HoaDon()
            {
                MaHoaDon = 1,
                TenHoaDon = "Hoa don thanh toan",
                TongTien = 52000,
                PhieuGiamGia = 5,
                TinhTrang = "thanh toan"
            };

            try
            {
                hoaDon.KiemTraHopLe();
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Tinh trang khong hop le");
                return;
            }

            Assert.Fail("No exception !");
        }

        [TestMethod()]
        public void TongTienGiamGiaTest()
        {
            HoaDon hoaDon = new HoaDon()
            {
                MaHoaDon = 1,
                TenHoaDon = "Hoa don thanh toan",
                TongTien = 100000,
                PhieuGiamGia = 10,
                TinhTrang = "Dang Thanh Toan"
            };

            Assert.AreEqual(90000, hoaDon.SoTienChenhLechTest());
        }

        [TestMethod()]
        public void SoTienChenhLechTest()
        {
            HoaDon hoaDon = new HoaDon()
            {
                MaHoaDon = 1,
                TenHoaDon = "Hoa don thanh toan",
                TongTien = 100000,
                PhieuGiamGia = 10,
                TinhTrang = "Dang Thanh Toan"
            };

            Assert.AreEqual(1000, hoaDon.SoTienChenhLech());
        }
    }
}