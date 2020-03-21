using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kiemtra1
{
    class NHANVIENHD : NHANVIEN, INHANVIEN
    {
        private int NgayCong;
        private double muctamung;



        public int NGAYCONG { get => NgayCong; set => NgayCong = value; }
        double INHANVIEN.muctamung { get => this.muctamung; set => this.muctamung = 0.3; }

        //public double MUCTAMUNG { get => muctamung; set => muctamung = value; }

        public NHANVIENHD() : base()
        {
        }

        public NHANVIENHD(string hoTen, DateTime ngaySinh, string gioiTinh, long soCM, string maNV, DateTime ngayVao, double luongCoBan, int ngayCong) 
            : base (hoTen, ngaySinh, gioiTinh, soCM, maNV, ngayVao, luongCoBan)
        {
            NgayCong = ngayCong;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap ngay cong: ");
            NgayCong = Convert.ToInt16(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("-------xuat NV HD------");
            Console.WriteLine("Ngay cong: " + this.NgayCong);
            Console.WriteLine("Phu cap: " + this.phucap());
            Console.WriteLine("Thuc linh: " + this.tinhluong());
            Console.WriteLine("--------------------");
        }

        public override double phucap()
        {
            return base.tinhthamnien() < 2 ? 200000 : 300000;
        }

        public override double tinhluong()
        {
            return this.NgayCong * (base.LUONGCOBAN / this.NgayCong) + this.phucap() - this.tamUngLuong();
        }

        public double tamUngLuong()
        {
            return (this.NgayCong * (base.LUONGCOBAN / this.NgayCong) + this.phucap()) * muctamung; 
        }
    }
}
