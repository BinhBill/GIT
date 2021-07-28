using System;

namespace GIAI_PHUONG_TRINH_BAC_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap c:");
            c = int.Parse(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("PT da cho Vo Nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2.0 * a);
                Console.WriteLine($"phuong trinh co nghiem la: {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine($"nghiem phuong trinh la X1 = {x1} va X2 = {x2}");
            }


 







        }
                               

            
    }
}
