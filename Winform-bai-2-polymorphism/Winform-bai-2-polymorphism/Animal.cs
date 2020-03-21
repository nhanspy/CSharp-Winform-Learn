using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_bai_2_polymorphism
{
    abstract class Animal
    {
        public Animal() { }

        virtual public void xuat()
        {
            Console.WriteLine("This is a Animal");
        }
        abstract public void speak();
    }
}
