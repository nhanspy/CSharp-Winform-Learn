using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_bai_2_polymorphism
{
    class Cat : Animal
    {
        public Cat() : base () { }

        override public void xuat()
        {
            Console.WriteLine("this is a Cat");
        }

        override public void speak()
        {
            Console.WriteLine("Meo meo meo");
        }

    }
}
