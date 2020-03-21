using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Bai1
{
    class NGUOI
    {
        protected String HoTen;
        protected DateTime NgaySinh;
        protected String GioiTinh;
        protected long SoCM;

        //properties
        public String HOTEN
        {
            get { return this.HoTen; }
            set { this.HoTen = value; }
        }
        public DateTime NGAYSINH
        {
            get { return this.NgaySinh; }
            set { this.NgaySinh = value; }
        }
        public String GIOITINH
        {
            get { return this.GioiTinh; }
            set { this.GioiTinh = value; }
        }
        public long SOCM { get; set; }
        //-----------

        public NGUOI(){}
        
        public NGUOI(string hoTen, DateTime ngaySinh, string gioiTinh, long soCM)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoCM = soCM;
        }

        public NGUOI(NGUOI nguoi)
        {
            HoTen = nguoi.HoTen;
            NgaySinh = nguoi.NgaySinh;
            GioiTinh = nguoi.GioiTinh;
            SoCM = nguoi.SoCM;
        }

        public int tinhTuoi()
        {
            return DateTime.Today.Year - this.NgaySinh.Year;
        }


        // Nhap xuat tren Console
        virtual public void xuat()//console
        {
            Console.WriteLine("----Xuat-----");
            Console.WriteLine("Ho va ten: " + this.HoTen);
            Console.WriteLine("Ngay sinh: " + this.NgaySinh);
            Console.WriteLine("Gioi tinh: " + this.GioiTinh);
            Console.WriteLine("So CMND: " + this.SoCM);
            Console.WriteLine("Tuoi: " + this.tinhTuoi());
        }

        virtual public void nhap()
        {
            Console.Write("Nhap ho va ten: ");
            this.HoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            this.GioiTinh = Console.ReadLine();
            Console.Write("Nhap so chung minh nhan dan: ");
            this.SoCM = Convert.ToInt32(Console.ReadLine());
        }

        virtual public void speak()
        {
            Console.Write("Im a people...");
        }
    }
}
