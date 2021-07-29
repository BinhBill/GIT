using System;

namespace Tinh_S_n__Cau_1_BT_nhom
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Nhap N");
            N = int.Parse(Console.ReadLine());
            int S = 1;
            int i = 1;
            while (i <= N)
            {
                S = S + i;
                i++;
            }
            Console.WriteLine($"tong cua S: {S}");
            //S la tong cua S+i ( vi du i 5 thi chay tu 12345 tong cua i la 15 
            // cong cho S la 1 nua la 16)
  
        }
    }
}
