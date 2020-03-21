using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformQuanLySInhVien.core
{
    class sinhVien 
    {
        int maSv { get; set; }
        string tenSv { get; set; }
        string lop { get; set; }
        float diem { get; set; }
        sinhVien sv { get; set };

        public sinhVien(int ma, string ten, string lop, float diem)
        {
            this.maSv = ma;
            this.tenSv = ten;
            this.lop = lop;
            this.diem = diem;
        }

        public sinhVien()
        {
            sv = new sinhVien();
        }

        public sinhVien SinhVien {get; set;}

        public void inSinhVien()
        {
            Console.Write("Ma sinh vien: {0} \n Ten Sinh vien: {1} \n Lop: {2}\n Diem trung binh: {3}", maSv, tenSv, lop, diem);
        }

        public string xepLoai()
        {
            return diem >= 9.5 ? "A+" : diem >= 8.5 ? "A" : diem >= 7.5 ? "B+" : diem >= 7 ? "B" : diem >= 6.5 ? "B-" : "CDF";
        }

        public sinhVien getSinhVien()
        {
            return sv;
        }

    }
}
