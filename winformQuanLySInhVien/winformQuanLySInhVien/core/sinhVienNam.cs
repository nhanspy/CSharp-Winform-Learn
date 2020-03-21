using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformQuanLySInhVien.core
{
    class sinhVienNam : sinhVien
    {
        readonly bool gioiTinh;
        sinhVien sv;
        public sinhVienNam()
        {
            gioiTinh = true;
            sv = new sinhVienNam();
        }

        public sinhVienNam(int ma, string ten, string lop, float diem) : base(ma, ten,lop,diem)
        {
            gioiTinh = false;
        }

        public void inGioiTinh()
        {
            Console.WriteLine("Sinh vien Nam");
        }
    }
}
