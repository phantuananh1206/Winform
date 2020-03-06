using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Program
    {
            struct sinhvien
        {
            public String hoTen;
            DateTime ngaySinh;
            public sinhvien(String ht, DateTime ns)
            {
                hoTen = ht;
                ngaySinh = ns;
            }
            public void Xuat()
            {
                Console.WriteLine("Ho ten : " + hoTen);
                Console.WriteLine("Ngay sinh : " + ngaySinh.ToString());
            }
        }
        enum thuTrongTuan
        {
            thuhai = 1,
            thuba = 2,
            thutu = 3,
            thunam = 4,
            thusau = 5,
            thubay = 6,
            chunhat

        }
        public static String thutrongtuan(int thu)
        {
            if (thu == 1)
                return "Thứ hai";
            else if (thu == 2)
                return "Thứ ba";
            else if (thu == 3)
                return "Thứ tư";
            else if (thu == 4)
                return "Thứ năm";
            else if (thu == 5)
                return "Thứ sáu";
            else if (thu == 6)
                return "Thứ bảy";
            else
                return "Chủ nhật";
        }

        public static String thucuatuan(String thu)
        {
            switch (thu)
            {
                case "Monday":
                    return "Thứ hai";
                case "Tuesday":
                    return "Thứ ba";
                case "Wednesday":
                    return "Thứ tư";
                case "Thursday":
                    return "Thứ năm";
                case "Friday":
                    return "Thứ sáu";
                case "Saturday":
                    return "Thứ bảy";
                case "Sunday":
                    return "Chủ nhật";
                default:
                    return "Hello cưng";
            }
        }
        public static String hanglietke(DayOfWeek thu)
        {
            switch (thu)
            {
                case DayOfWeek.Monday:
                    return "Thứ hai";
                case DayOfWeek.Tuesday:
                    return "Thứ ba";
                case DayOfWeek.Wednesday:
                    return "Thứ tư";
                case DayOfWeek.Thursday:
                    return "Thứ năm";
                case DayOfWeek.Friday:
                    return "Thứ sáu";
                case DayOfWeek.Saturday:
                    return "Thứ bảy";
                case DayOfWeek.Sunday:
                    return "Chủ nhật";
                default:
                    return "Hello cưng";
            }
        }

        public static void changeValue(ref int a)
        {
            a = a + 1;
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int tong(params int[] value)
        {
            int s = 0;
            for (int i = 0; i < value.Length; i++)
                s += value[i];
            return s;
        }
        static void Main(string[] args)
        {
            StringDictionary dictionary = new StringDictionary();
            dictionary.Add("a", "Anh Phan");
            dictionary.Add("b", "Xi Ha");
            dictionary.Add("c", "Huy Duc");
            //Console.WriteLine(dictionary["a"]);
            //foreach (String key in dictionary.Keys)
            //    Console.WriteLine(dictionary[key]);
            //foreach (String value in dictionary.Values)
            //    Console.WriteLine(value);
            //foreach (DictionaryEntry Entry in dictionary) //cách lấy cả key và value
            //    Console.WriteLine("Key: " + Entry.Key + " Value: " + Entry.Value);

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Anh Phan");
            hashtable.Add(2, "Xi Ha");
            hashtable.Add(3, "Huy Duc");
            foreach (DictionaryEntry Entry in hashtable) //cách lấy cả key và value
                Console.WriteLine("Key: " + Entry.Key + " Value: " + Entry.Value);

            List<String> list2 = new List<string>();
            list2.Add("Phan Tuan Anh");

            sinhvien sv2 = new sinhvien();

            Dictionary<int, String> dictionary2 = new Dictionary<int, string>();
            dictionary2.Add(1, "Ha Thi Xi");
            Dictionary<int, sinhvien> dictionary3 = new Dictionary<int, sinhvien>();
            dictionary3.Add(2,sv2);
            String ht = dictionary3[2].hoTen;
            
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(sv2);
            sinhvien sv1 =(sinhvien) arrayList[0]; //Cần phải ép kiểu
            String ht2 = sv1.hoTen;

            List<sinhvien> list3 = new List<sinhvien>();
            list3.Add(sv2);
            String hoTenn = list3[1].hoTen; // Không cần ép kiểu





            ArrayList list = new ArrayList();
            int i = 10;
            String hoTen = "Ha Thi Xi";
            long soCMND = 206321161;

            list.Add(i);
            list.Add(hoTen);
            list.Add(soCMND);
            list.RemoveAt(0);
            list.Insert(1, "abc");
            for (int j = 0; j < list.Count; j++)
                Console.WriteLine(list[j]);
            foreach (object value in list)
                Console.WriteLine(value);
            sinhvien sv = new sinhvien("Phan Tuan Anh", DateTime.Parse("12/06/1999"));
            sv.Xuat();
            //int a = 0;
            //changeValue(ref a);
            //Console.WriteLine(Convert.ToString(a));
            //Console.WriteLine(sum(2,3));
            //Console.WriteLine(tong(2, 3, 3, 3));
            //const int SOPHANTU = 2;
            //int[] M = new int[SOPHANTU];
            //M[0] = 1;
            //M[1] = 2;
            //foreach (int item in M)
            //    Console.WriteLine(item);
            //int[,] MM = { { 1, 3, 5 }, { 2, 4, 6 } };

            //for (int i = 0; i < MM.GetLength(0); i++)
            //    for (int j = 0; j < MM.GetLength(1); j++)
            //        Console.WriteLine(MM[i, j]);
            //int[,,] MMM = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            //foreach (int item2 in MMM)
            //    Console.WriteLine(item2);

            //char[][] MMMM = new char[3][];

            //MMMM[0] = new char[] { 'A', 'B', 'C', 'D' };
            //MMMM[1] = new char[] { 'E', 'F' };
            //MMMM[2] = new char[] { 'G', 'H', 'K' };
            //for (int i = 0; i < MMMM.Length; i++)
            //    for (int j = 0; j < MMMM[i].Length; j++)
            //        Console.WriteLine(MMMM[i][j]);
            //DateTime d = DateTime.Today;
            //int thu = (int)d.DayOfWeek;
            //Console.WriteLine(thutrongtuan(thu));
            //Console.WriteLine((int)d.DayOfWeek);
            //if ((int)d.DayOfWeek == 1)
            //    Console.WriteLine("Thứ hai");
            //else if ((int)d.DayOfWeek == 2)
            //    Console.WriteLine("Thứ ba");
            //else if ((int)d.DayOfWeek == 3)
            //    Console.WriteLine("Thứ tư");
            //else if ((int)d.DayOfWeek == 4)
            //    Console.WriteLine("Thứ năm");
            //else if ((int)d.DayOfWeek == 5)
            //    Console.WriteLine("Thứ sáu");
            //else if ((int)d.DayOfWeek == 6)
            //    Console.WriteLine("Thứ bảy");
            //else 
            //    Console.WriteLine("Chủ nhật");

            ////Console.WriteLine(thuTrongTuan.chunhat);



            Console.ReadKey();
        }
    }
}


   
        
     

