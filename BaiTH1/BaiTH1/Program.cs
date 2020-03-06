using System;

namespace BaiTH1
{
    
    class Program
    {
        static int[] M;
        static int N;
        static int[,] MM;
        static int Col;
        static int Row;
        public static void Nhap()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("M[" + i + "]="); // tham so hoa ("M[{0}]=",i);
                M[i] = Convert.ToInt16(Console.ReadLine());
            }
        }
        public static void Xuat()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("M[{0}]={1}", i, M[i]+"\t");
            }
        }
        public static bool Tim(int x)
        {
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] == x)
                    return true;
            }
            return false;
        }
        public static void SapXep()
        {
            for (int j = 0; j < M.Length; j++)
            {
                for (int k = j + 1; k < M.Length; k++)
                {
                    if (M[j] > M[k])
                    {
                        int tmp = M[j];
                        M[j] = M[k];
                        M[k] = tmp;
                    }
                }
            }
        }
        public static int [] Xoa(int k, int [] MN)
        {
            for (int p = 0; p < MN.Length; p++)
            {
                if (MN[p] == k)
                {
                    for (int q = p; q < MN.Length - 1; q++)
                    {
                        MN[q] = MN[q + 1];
                    }
                    MN[MN.Length - 1] = 0;
                }
            }
            return MN;
        }
        public static void Nhap2()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write("MM[{0},{1}]= ",i,j);
                    MM[i,j] = Convert.ToInt16(Console.ReadLine());
                }            
            }
        }
        public static void Xuat2()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write("MM[{0},{1}]={2}", i, j,MM[i,j]);
                }
            }
        }
        static void Main(string[] args)
        {
            //khai bao cua thay
            //int n,p,q;
            //Console.Write("Nhap chieu cao cua hinh tam giac : ");
            //n = Convert.ToInt16(Console.ReadLine());
            //for (p = 0; p <= n; p++)
            //{
            //    int m = n - p;
            //    Console.WriteLine("{0,"+m+ "}", " ");
            //    for (q = 1; q <= 2 * p - 1; q++)
            //        Console.Write("*");
            //    Console.Write("\n");
            //}

            //My solution
            //Console.Write("Chieu cao : ");
            //int h = int.Parse(Console.ReadLine());
            //int w = h + (h - 1);
            //for (int i = 0; i < h; i++)
            //{
            //    for (int j = 0; j <= w; j++)
            //    {
            //        if (j > h - 1 - i && j <= w - (h - 1 - i))
            //            Console.Write("*");
            //        else Console.Write("a");
            //    }
            //    Console.WriteLine("");
            //}


            Console.Write("Nhap do dai cua mang : ");
            N = Convert.ToInt16(Console.ReadLine());
            M = new int[N];
            Nhap();
            Xuat();
            int x;
            Console.Write("\nNhap x can tim = ");
            x = Convert.ToInt16(Console.ReadLine());
            if (Tim(x))
                Console.WriteLine("Tim thay pt x trong mang ");
            else
                Console.WriteLine("Khong tim thay pt x");
            SapXep();
            Console.WriteLine("Mang sau khi sap xep : ");
            Xuat();

            int k;
            Console.Write("\nNhap phan tu can xoa : ");
            k = Convert.ToInt16(Console.ReadLine());
            Xoa(k,M);
            Console.WriteLine("Mang sau khi xoa : ");
            Xuat();

            Console.Write("\nNhap hang va cot cua mang 2 chieu : ");
            Row = Convert.ToInt16(Console.ReadLine());
            Col = Convert.ToInt16(Console.ReadLine());   
            MM = new int[Row, Col];
            Nhap2();
            Xuat2();

            int[,] M2 = { { 2, 4, 6 }, { 3, 5, 7 } };
            foreach (int value in M2)
                Console.WriteLine("Phan tu mang : " + value);

            char[][] JM = new char[2][];
            JM[0] = new char[] { 'A', 'B' };
            JM[1] = new char[] { 'C', 'D' };
            //foreach(char []M in M2)
            //    foreach(char value in)

            Console.ReadKey();
        }
    }
}
