using System;

namespace ThangNam
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;

            Console.WriteLine("Nhap thang:");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            nam = int.Parse(Console.ReadLine());
            // thang 31 ngay:  1,3,5,7,8,10,12
            // thang 30 ngay: 4,6,9,11
            // thang 28, 29 ngay: 2
            int soNgayTrongThang = 31;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                soNgayTrongThang = 30; 
            }

            else if (thang == 2)
            {
                //xet coi co phai nam nhuan hay khong chia tahnh 2 truong hop 
                // xem co phai cuoi the ki khong 
                //cuoi the ki thi phai chia het chia 400
                // con khong cuoi the ki chi can chia het cho 100 va 4.
                if ((nam % 100 != 0 && nam % 4 == 0) || (nam % 400 == 0))
                  {
                    soNgayTrongThang = 29;
                }
                else
                {
                    soNgayTrongThang = 28;
                }
                Console.WriteLine($"so ngay trong thang: {soNgayTrongThang}");

            }
        }
    }
}
