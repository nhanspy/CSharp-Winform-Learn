using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Bai1
{
    class NHANVIENBC : NHANVIEN
    {
        private double HeSoLuong;

        public double HESOLUONG { get => HeSoLuong; set => HeSoLuong = value; }

        public NHANVIENBC() : base() { }

        public NHANVIENBC(string hoTen, DateTime ngaySinh, string gioiTinh, long socm, string maNV, DateTime ngayvao, double luongcoban, double hesoluong) :
            base(hoTen, ngaySinh, gioiTinh, socm, maNV, ngayvao, luongcoban)
        {
            this.HeSoLuong = hesoluong;
        }

        override public void nhap()
        {
            base.nhap();
            Console.Write("Nhap he so luong: ");
            this.HeSoLuong = Convert.ToDouble( Console.ReadLine());
        }

        override public void xuat()
        {
            base.xuat();
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Phu cap: " + tinhPhuCap());
            Console.WriteLine("Luong: " + tinhLuong());
        }

        private Double tinhLuong()
        {
            return HESOLUONG * LUONGCOBAN + tinhPhuCap();
        }

        private double tinhPhuCap()
        {
            return base.tinhThamNien() < 5 ? 200000 : 500000;
        }

        override public void speak()
        {
            Console.Write("Im a BC no Shain...");
        }
    }
}
