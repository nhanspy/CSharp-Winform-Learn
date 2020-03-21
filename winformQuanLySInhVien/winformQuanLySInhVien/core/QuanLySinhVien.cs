using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformQuanLySInhVien.core
{
    class QuanLySinhVien
    {
        List<sinhVien> sinhViens;

        QuanLySinhVien()
        {
            sinhViens = new List<sinhVien>();
        }

        public void themSinhVien(bool gioiTinh, int ma , string ten, string lop, float diem)
        {
            sinhVien sv;
            if (gioiTinh)
            {
                sv = new sinhVienNam(ma,ten,lop,diem);
            }
            else
            {
                sv = new sinhVienNu(ma, ten, lop, diem);
            }

            sinhViens.Add(sv);
        }

        public void inSoSinhVien()
        {
            Console.WriteLine(sinhViens.Count);
        }

        public void inSinhVien()
        {
            foreach (sinhVien sv in sinhViens) {
                sv.inSinhVien();
            }
        }
    }
}
