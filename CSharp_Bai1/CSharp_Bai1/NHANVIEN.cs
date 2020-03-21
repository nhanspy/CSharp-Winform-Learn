using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Bai1
{
    class NHANVIEN : NGUOI
    {
        private String MaNV;
        private DateTime NgayVao;
        private double LuongCoBan;

        public double LUONGCOBAN { get => LuongCoBan; set => LuongCoBan = value; }
        public DateTime NGAYVAO { get => NgayVao; set => NgayVao = value; }
        public string MANV { get => MaNV; set => MaNV = value; }

        public NHANVIEN():base() { }

        public NHANVIEN(string hoTen, DateTime ngaySinh, string gioiTinh, long socm, string maNV, DateTime ngayVCQ, double luongCoBan):
            base(hoTen,ngaySinh,gioiTinh,socm)
        {
            MaNV = maNV;
            NgayVao = ngayVCQ;
            LuongCoBan = luongCoBan;
        }

        override public void nhap()
        {
            base.nhap();
            Console.Write("Nhap MaNV: ");
            this.MaNV = Console.ReadLine();
            Console.Write("Nhap Ngay Vao: ");
            this.NgayVao = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap Luong Co Ban: ");
            this.LuongCoBan = Convert.ToDouble(Console.ReadLine());
        }

        override public void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma nhan vien: " + this.MaNV);
            Console.WriteLine("Ngay vao: " + this.NgayVao);
            Console.WriteLine("Luong Co ban: " + this.LuongCoBan);
            Console.WriteLine("Thanh Tien: " + this.tinhThamNien());
        }

        public NHANVIEN(NHANVIEN nv):base(new NGUOI(nv.HOTEN, nv.NGAYSINH, nv.GIOITINH, nv.SOCM))
        {
            this.MaNV = nv.MaNV;
            this.NgayVao = nv.NgayVao;
            this.LuongCoBan = nv.LuongCoBan;
        }

        public int tinhThamNien()
        {
            return Convert.ToInt16(DateTime.Today.Year - NgayVao.Year);
        }

        override public void speak()
        {
            Console.Write("Im a shain...");
        }
    }
}
