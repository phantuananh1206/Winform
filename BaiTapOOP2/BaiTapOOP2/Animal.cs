using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP2
{
    abstract class Animal
    {
        public Animal()
        {

        }

        virtual public void Xuat()
        {
            Console.WriteLine("This is the Animal");
        }
        abstract public void Speak();
    }
}
