using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP2
{
    class Dog:Animal
    {
        public Dog() : base() { 
        
        }

        override public void Xuat()
        {
            Console.WriteLine("This is A Dog");
        }
        override public void Speak()
        {
            Console.WriteLine("Go Go Go !");
        }
    }
}
