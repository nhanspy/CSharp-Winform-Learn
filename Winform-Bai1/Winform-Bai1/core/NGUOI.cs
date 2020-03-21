using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Bai1.core
{
    class NGUOI
    {
        private String HoTen;
        private DateTime NgaySinh;
        private String GioiTinh;
        private long SoCM;

        //properties
        public String HOTEN { get; set; }
        public String NGAYSINH { get; set; }
        public String GIOITINH { get; set; }
        public long SOCM { get; set; }
        //-----------
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
        public void xuat()//console
        {
            Console.WriteLine("Ho va ten: " + this.HoTen);
            Console.WriteLine("Ngay sinh: " + this.NgaySinh);
            Console.WriteLine("Gioi tinh: " + this.GioiTinh);
            Console.WriteLine("So CMND: " + this.SoCM);
            Console.WriteLine("Tuoi: " + this.tinhTuoi());
        }

        public void nhap()
        {
            Console.Write("Nhap ho va ten: ");
            this.HoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            this.GioiTinh = Console.ReadLine();
            Console.Write("Nhap so chung minh nhan dan: ");
            this.SoCM = Convert.ToInt16(Console.ReadLine());
        }



    }
}
