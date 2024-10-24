using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANNGOCTHUYNGAN_31231023211_24C1INF50900503
{
    internal class Session_04_02
    {
        public static void Main()
        {
            //Session04_01();
            //Session04_02();
            //Session04_03();
            //Session04_04();
            //Session04_06();
            Session04_07();
            //Session04_08();
            Console.ReadKey();
        }
        public static void Session04_01()
        {
            //Check whether a triangle is Equilateral, Lsosceles or Scalene 
            Console.WriteLine("Hay nhap vao ba canh cua tam giac can kiem tra: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ba canh tam giac ban vua nhap la: {a}, {b}, {c}");
            if (a == b && b == c)
            {
                Console.Write("Tam giac do la tam giac deu");
            }
            else if ((a == b && a != c) || (b == c && b != a) || (c == a && b != a)) //này else if ghi điều kiện tam giác thường thì dễ hơn
            {
                Console.Write("Tam giac do la tam giac can");
            }
            else if ((a*a == b*b + c*c) || (b*b == c*c + a*a) || (c*c == a*a + b*b))
            {
                Console.Write("Tam giac do la tam giac vuong");
            }
            else
            {
                Console.Write("Tam giac do la tam giac thuong");
            }
        }
        public static void Session04_02()
        {
            //Write a program to read 10 numbers and find their average and sum.
            int i;
            int n;
            int tong = 0;
            double avg;
            Console.WriteLine("Hay nhap vao may tinh 10 so");
            for (i = 1; i <= 10; i++)
            {
                Console.Write($"So thu {i}: ");
                n = int.Parse( Console.ReadLine() );
                tong += n;
            }
            avg = tong / 10.0;
            Console.WriteLine($"Tong cua 10 so = {tong}");
            Console.WriteLine($"Trung binh cong cua 10 so = {avg}");
            Console.ReadKey();
        }
        public static void Session04_03()
        {
            //To display the multiplication table of a given integer
            Console.Write("Nhap vao so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong cua so {n} la: ");
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
            Console.ReadKey();
        }
        public static void Session04_04()
        {
            //To display a pattern like triangles with a number
            //Tam giác vuông bên phải
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            int j = 0;
            int a = 1;
            //Tam giác vuông
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(j);

                Console.WriteLine(" ");
            }


            //Tam giác vuông bên phải nhưng số tiếp tục
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(a);

                Console.WriteLine(" ");
            }
        }
        public static void Session04_06()
        {
            //To display the n terms of harmonic series and their sum
            Console.Write("Nhap vao n: ");
            int n = int.Parse(Console.ReadLine());
            float sum = 0;
            int a = 0;
            for (int i = 1; i <= n; i++)
            {

                sum += 1 / (float)i;
            }
            Console.WriteLine(sum);
        }
        public static void Session04_07()
        {
            //To find the 'perfect' numbers within a givin number
            Console.Write("Nhap n: ");
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    a += i;
            }
            if (n == a)
            {

                Console.WriteLine("N la so hoan hao");
                count++;
            }
            else

                Console.WriteLine("N khong phai la so hoan hao");
                Console.WriteLine($"Co tong {count} so hoan hao");
        }
        public static void Session04_08()
        {
            //To determine whether a given number is prime or not
            int a;
            Console.WriteLine("Nhap vao so a sao cho a>0: ");
            a = int.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("Nhập lại a, a phải lớn hơn 0");
                a = int.Parse(Console.ReadLine());
            }
            int demUoc = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    demUoc++;
            }
            if (demUoc == 2)
                Console.WriteLine("{0} là số nguyên tố", a);
            else
                Console.WriteLine("{0} không phải là số nguyên tố", a);
        }

    }
}
