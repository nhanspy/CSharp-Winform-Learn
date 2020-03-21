using System;

namespace CSharp_kiemtra1
{
    class Program
    {
        static void Main(string[] args)
        {
            DANHSACHNHANVIEN nhanviens = new DANHSACHNHANVIEN();
            char C;


            while (true)
            {
                Console.Write("Tiep tuc (Y/n) : ");
                C = Char.Parse(Console.ReadLine());

                if (!(C == 'Y' || C == 'y')) break;

                int loainv;

                Console.WriteLine("Chon loai nhan vien");
                Console.WriteLine("1. Nhan vien BC");
                Console.WriteLine("2. Nhan vien HD");
                loainv = Convert.ToInt32(Console.ReadLine());

                NHANVIEN nv;

                if (loainv == 1)
                {
                    nv = new NHANVIENBC();
                    nv.nhap();
                } else
                {
                    nv = new NHANVIENHD();
                    nv.nhap();
                }

                nhanviens.them(nv);
            }
            Console.WriteLine("Tong luong : " + nhanviens.tinhtongluong());
            //nhanviens["nv1"].xuat();
            Console.ReadLine();
        }
    }
}
