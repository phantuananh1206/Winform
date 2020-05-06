using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checktn
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //Console.WriteLine(" do dai cua mang : " + numbers.Length);

            Dictionary<int, string> thuvien = new Dictionary<int, string>();
            thuvien.Add(1, "Tin dai cuong");
            thuvien.Add(2, "Tin ung dung");
            thuvien.Add(3, "winform");

            Console.WriteLine(thuvien.ContainsKey(4));

            Console.ReadKey();
        }
    }
}
