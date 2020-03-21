using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kiemtra1
{
    class NGUOI
    {
        private String HoTen;
        private DateTime NgaySinh;
        private String GioiTinh;
        private long SoCM;

        public DateTime NGAYSINH { get => NgaySinh; set => NgaySinh = value; }
        public string GIOITINH { get => GioiTinh; set => GioiTinh = value; }
        public long SOCM { get => SoCM; set => SoCM = value; }
        public string HOTEN { get => HoTen; set => HoTen = value; }

        public NGUOI()
        {
        }

        public NGUOI(string hoTen, DateTime ngaySinh, string gioiTinh, long soCM)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoCM = soCM;
        }

        public NGUOI(NGUOI nguoi)
        {
            this.HoTen = nguoi.HoTen;
            this.NgaySinh = nguoi.NgaySinh;
            this.GioiTinh = nguoi.GioiTinh;
            this.SoCM = nguoi.SoCM;
        }

        public int tinhtuoi()
        {
            return DateTime.Today.Year - this.NgaySinh.Year;
        }

        public void xuat()
        {
            Console.WriteLine("-----Xuat Nguoi-------");
            Console.WriteLine("Ho va ten: " + this.HoTen);
            Console.WriteLine("Ngay sinh: "+ this.NgaySinh);
            Console.WriteLine("Gioi tinh: "+ this.GioiTinh);
            Console.WriteLine("So CM: " + this.SoCM);
            Console.WriteLine("----------------------");
        }

        public void nhap()
        {
            Console.Write("Nhap Ho v ten: ");
            this.HoTen = Console.ReadLine();
            Console.Write("Nhap Ngay sinh: ");
            this.NgaySinh = DateTime.Parse( Console.ReadLine() );
            Console.Write("Nhap Gioi tinh: ");
            this.GioiTinh = Console.ReadLine();
            Console.Write("Nhap So CM: ");
            this.SoCM = Convert.ToInt64(Console.ReadLine());
        }
    }
}
