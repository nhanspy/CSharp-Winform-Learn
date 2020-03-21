using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kiemtra1
{
    class DANHSACHNHANVIEN
    {
        Dictionary<String, NHANVIEN> danhsach;

        String[] arr = { "Tran Nhan", "Le B", "Le C" };
        
        public NHANVIEN this[String key]
        {
            set
            {
                //if (index >= 0 && index < arr.Length) arr[index] = value;
                if (danhsach.ContainsKey(key)) danhsach[key] = value;
                else danhsach.Add(key,value);
            }
            get
            {
                //if (index >= 0 && index < arr.Length) return arr[index];
                if (danhsach.ContainsKey(key)) return danhsach[key];
                else return null;
            }
        }

        public DANHSACHNHANVIEN()
        {
            this.danhsach = new Dictionary<string, NHANVIEN>();
        }

        public void them(NHANVIEN nv)
        {
            danhsach.Add(nv.MANV, nv);
        }

        public void xoa(String manv)
        {
            danhsach.Remove(manv);
        }

        public NHANVIEN tim(String manv)
        {
            return danhsach[manv];
        }

        public double tinhtongluong()
        {
            double tong = 0;
            foreach (NHANVIEN nv in danhsach.Values)
                tong += nv.tinhluong();
            return tong;
        }

        public void xuat()
        {
            foreach (NHANVIEN nv in danhsach.Values)
            {
                nv.xuat();
            }
        }
    }
}
