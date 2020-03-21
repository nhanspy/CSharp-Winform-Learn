using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_bai_2_polymorphism
{
    class Dog : Animal
    {
        public Dog() : base() { }

        override public void xuat()
        {
            Console.WriteLine("This is a Dog");
        }

        override public void speak()
        {
            Console.WriteLine("Gau gau gau");
        }
    }
}
