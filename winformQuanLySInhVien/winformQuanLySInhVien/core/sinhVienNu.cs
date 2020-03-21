using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformQuanLySInhVien.core
{

    class sinhVienNu : sinhVien
    {
        readonly bool gioiTinh;
        public sinhVienNu() 
        {
            gioiTinh = true;
        }

        public sinhVienNu(int ma, string ten, string lop, float diem) : base(ma, ten, lop, diem)
        {
            gioiTinh = true;
        }

        public void inGioiTinh()
        {
            Console.WriteLine("Gioi tinh Nu");
        }
    }
}
