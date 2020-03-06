using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP2
{
    class Cat:Animal
    {
        public Cat():base()
        {

        }
        override public void Xuat()
        {
            Console.WriteLine("This is A Cat");
        }
        override public void Speak()
        {
            Console.WriteLine("Meo Meo Meo !");
        }
    }
}
