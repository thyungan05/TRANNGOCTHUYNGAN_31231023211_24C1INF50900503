using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANNGOCTHUYNGAN_31231023211_24C1INF50900503
{
    internal class Session_04_01
    {
        public static void Main4_1()
        {
            //Session04_01();
            Session04_02();
            //Session04_03();
            Console.ReadKey();
        }
        public static void Session04_01()
        {
            //To check whether a given number is even or odd
            Console.Write("Nhap vao so de kiem tra: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} la so chan");
            }
            else
            {
                Console.WriteLine($"{a} la so le");
            }
        }
        public static void Session04_02()
        {
            Console.WriteLine("Nhap vao 3 so: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ba so ban vua nhap la: {a}, {b}, {c}");
            if ((a > b) && (a > c))
            {
                Console.WriteLine($"{a} la so lon nhat trong ba so ban vua nhap");
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine($"{b} la so lon nhat trong ba so ban vua nhap");
            }
            else
            {
                Console.WriteLine($"{c} la so lon nhat trong ba so ban vua nhap");
            }
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            { 
            max = c;
            }
            Console.WriteLine($"{max} la so lon nhat trong ba so ban vua nhap");


       }
        public static void Session04_03()
        {
            Console.WriteLine("Xac dinh diem do nam trong goc nao");
            Console.Write("Nhap vao he truc cua x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao he truc cua y: ");
            int y = int.Parse(Console.ReadLine());
            while (x == 0  || y == 0)
            {
                Console.WriteLine("Nhap lai x, y sao cho x, y phai khac 0: ");
                Console.Write("Nhap vao he truc cua x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao he truc cua y: ");
                y = int.Parse(Console.ReadLine());
            }
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine($"Diem co toa do ({x},{y}) nam trong goc thu nhat");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine($"Diem co toa do ({x},{y}) nam trong goc thu hai");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine($"Diem co toa do ({x},{y}) nam trong goc thu ba");
            }
            else
            {
                Console.WriteLine($"Diem co toa do ({x},{y}) nam trong goc thu tu");
            }
        }
    }
}
