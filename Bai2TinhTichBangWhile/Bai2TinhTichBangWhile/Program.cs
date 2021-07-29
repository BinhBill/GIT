using System;

namespace Bai2TinhTichBangWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Nhap N");
            N = int.Parse(Console.ReadLine());
            int S = 0;
            int i = 1;
            while (i <= N)
            {
                S = S + i*i;
                i++;
                //S(i) = S(i-1) + i^2
            }
            Console.WriteLine($"tong cua S: {S}");
           
        }
    }
}
