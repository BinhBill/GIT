using System;

namespace USCLN
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;


            Console.WriteLine("Nhap so cho a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so cho b:");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Nhap so cho a:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap so cho b:");
                b = int.Parse(Console.ReadLine());
            }    
            
            if(a == 0 || b == 0) 
            {

                Console.WriteLine(a + b);
            } 
            while (a != b) // Su dung phep tru tim UCLN
            {
                if(a>b)
                {
                    a -= b; //a = a - b
                }
                else
                {
                    b -= a; //b = b - a
                }
                Console.WriteLine($"UCLN: {a}");
                // ket qua tra ve a or b deu dung. vi cuoi cung a luon = b.
            }
            


        }
    }
}
