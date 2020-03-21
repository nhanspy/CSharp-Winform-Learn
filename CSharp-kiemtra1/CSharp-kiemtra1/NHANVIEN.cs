using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kiemtra1
{
    abstract class  NHANVIEN : NGUOI
    {
        private String MaNV;
        private DateTime NgayVao;
        private double LuongCoBan;

        public DateTime NGAYVAO { get => NgayVao; set => NgayVao = value; }
        public double LUONGCOBAN { get => LuongCoBan; set => LuongCoBan = value; }
        public string MANV { get => MaNV; set => MaNV = value; }

        protected NHANVIEN(string hoTen, DateTime ngaySinh, string gioiTinh, long soCM, string maNV, DateTime ngayVao, double luongCoBan) 
            : base(hoTen,ngaySinh,gioiTinh,soCM)
        {
            MaNV = maNV;
            NgayVao = ngayVao;
            LuongCoBan = luongCoBan;
        }

        protected NHANVIEN() : base()
        {
        }

        public NHANVIEN(NHANVIEN nv) : base(new NGUOI(nv.HOTEN, nv.NGAYSINH, nv.GIOITINH, nv.SOCM))
        {
            this.MaNV = nv.MaNV;
            this.NgayVao = nv.NgayVao;
            this.LuongCoBan = nv.LuongCoBan;
        }

        public int tinhthamnien()
        {
            return DateTime.Today.Year - this.NgayVao.Year;
        }

        virtual public void xuat()
        {
            base.xuat();
            Console.WriteLine("-----Xuat Nhan Vien -------");
            Console.WriteLine("Ma nhan vien: " + this.MaNV);
            Console.WriteLine("Ngay vao: "+ this.NgayVao);
            Console.WriteLine("Luong co ban" + this.LuongCoBan);
            Console.WriteLine("--------------------");
        }

        virtual public void nhap()
        {
            base.nhap();
            Console.Write("Nhap Ma NV: ");
            this.MaNV = Console.ReadLine();
            Console.Write("Nhap ngay vao: ");
            this.NgayVao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban: ");
            this.LuongCoBan = Convert.ToDouble(Console.ReadLine());
        }

        abstract public double phucap();
        abstract public double tinhluong();


    }
}
