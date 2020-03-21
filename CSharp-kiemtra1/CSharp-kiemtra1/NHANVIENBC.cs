using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kiemtra1
{
    class NHANVIENBC : NHANVIEN, INHANVIEN
    {
        private double HeSoLuong;
        private Double muctamung;

        double INHANVIEN.muctamung { get => this.muctamung; set => this.muctamung = 0.5; }

        public double HESOLUONG { get => HeSoLuong; set => HeSoLuong = value; }
        public double MUCTAMUNG { get => muctamung; set => muctamung = value; }

        public NHANVIENBC (string hoTen, DateTime ngaySinh, string gioiTinh, long soCM, string maNV, DateTime ngayVao, double luongCoBan, double heSoLuong)
            : base(hoTen, ngaySinh, gioiTinh, soCM,maNV,ngayVao,luongCoBan)
        {
            this.HeSoLuong = heSoLuong;
        }

        public NHANVIENBC()
        {
        }

        public override double phucap()
        {
            return base.tinhthamnien() < 5 ? 200000 : 500000;
        }

        public override double tinhluong()
        {
            return this.HeSoLuong * base.LUONGCOBAN + this.phucap() - this.tamUngLuong();
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap he so luong: ");
            this.HeSoLuong = Convert.ToDouble(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("------Xuat NV BC-------");
            Console.WriteLine("He so luong: " + this.HeSoLuong);
            Console.WriteLine("-----------------------");
        }

        public double tamUngLuong()
        {
            return (this.HeSoLuong * base.LUONGCOBAN + this.phucap()) * this.muctamung;
        }
    }
}
