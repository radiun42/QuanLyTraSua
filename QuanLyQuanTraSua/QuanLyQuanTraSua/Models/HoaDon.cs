using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Models
{
    public class HoaDon
    {
        private int maHoaDon;
        private string tenHoaDon;
        private decimal tongTien;
        private string tinhTrang;
        private int phieuGiamGia;

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TenHoaDon { get => tenHoaDon; set => tenHoaDon = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int PhieuGiamGia { get => phieuGiamGia; set => phieuGiamGia = value; }

        public void KiemTraHopLe()
        {
            if (tongTien < 0)
                throw new Exception("Tong tien bi am");
            if (!tinhTrang.Equals("Dang Thanh Toan") || !tinhTrang.Equals("Da Thanh Toan") || !tinhTrang.Equals("Huy Thanh Toan"))
                throw new Exception("Tinh trang khong hop le");
        }

        public decimal SoTienChenhLechTest()
        {
            if (phieuGiamGia <= 0 || phieuGiamGia > 100)
                throw new ArgumentOutOfRangeException("Phieu giam gia nho hon bang 0 hoac lon hon 100");
            return TongTien * (100 - phieuGiamGia) / 100;
        }

        public decimal SoTienChenhLech()
        {
            if (phieuGiamGia <= 0 || phieuGiamGia > 100)
                throw new ArgumentOutOfRangeException("Phieu giam gia nho hon bang 0 hoac lon hon 100");

            decimal tienDaGiam = this.SoTienChenhLechTest();

            return TongTien + tienDaGiam;
        }
    }
}
