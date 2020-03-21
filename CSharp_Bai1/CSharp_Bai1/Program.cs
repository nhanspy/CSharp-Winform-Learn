using System;

namespace CSharp_Bai1
{
    class Program
    {

        static void Main(string[] args)
        {
            NGUOI nv = new NHANVIENBC();
            nv.nhap();
            nv.xuat();
            Console.ReadKey();
        }
    }
}
