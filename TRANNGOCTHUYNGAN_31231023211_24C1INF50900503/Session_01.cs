using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANNGOCTHUYNGAN_31231023211_24C1INF50900503
{
    internal class Session_01
    {
        public static void Main()
        {
            //Session01_01();
            //Session01_02();
            //Session01_03();
            //Session01_04();
            //Session01_05();
            //Session01_06();
            //Session01_07();
            //Session01_08();
            //Session01_09();
            //Session01_10();
            Console.ReadLine();
        }
        public static void Session01_01()
        {
            //To add/ sum two numbers
            Console.Write("Nhap vao so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($" Tong cua hai so {a} và {b} là {sum}");
        }
        public static void Session01_02()
        {
            //To swap values of two variables
            Console.Write("Nhap vao bien x: ");
            string x = Console.ReadLine();
            Console.Write("Nhap vao bien y: ");
            string y = Console.ReadLine();
            string z;
            z = x; x = y; y = z;
            Console.WriteLine($"Gia tri cua x sau khi swap la: {x}");
            Console.WriteLine($"Gia tri cua y sau khi swap la: {y}");
        }
        public static void Session01_03()
        {
            //To multiply two floating point numbers
            Console.Write("Nhap vao so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            float b = float.Parse(Console.ReadLine());
            float multiply = a * b;
            Console.WriteLine($" Nhan cua hai so {a} và {b} là {multiply}");
        }
        public static void Session01_04()
        {
            //To convert feet to meter
            Console.Write("Nhap so feet can chuyen: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet / 3.281;
            Console.WriteLine($"Chuyen Feet sang Meter la: {meter}");
        }
        public static void Session01_05()
        {
            //To convert Celsius to Fahrenheit and vice versa
            Console.WriteLine("Option?");
            Console.WriteLine("1. C sang F");
            Console.WriteLine("2. F sang C");
            int a = int.Parse(Console.ReadLine());

            // đổi từ độ C sang độ F
            if (a == 1)
            {
                double cDegree;
                Console.Write("Nhap do C : ");
                cDegree = Convert.ToInt32(Console.ReadLine());
                Console.Write("Do F : " + cDegree * 9 / 5 + 32);
            }
            else if (a == 2) //đổi từ độ F sang độ C
            {
                double fDegree;
                Console.Write("Nhap do F : ");
                fDegree = Convert.ToInt32(Console.ReadLine());
                Console.Write("Do C : " + (fDegree - 32) * 5 / 9);
            }

        }
        public static void Session01_06()
        {
            // To find the size of data types
            Console.WriteLine("Kich thuoc cua kieu du lieu int la: " + sizeof(int));
            Console.WriteLine("Kich thuoc cua kieu du lieu char la: " + sizeof(char));
            Console.WriteLine("Kich thuoc cua kieu du lieu double la: " + sizeof(double));
        }
        public static void Session01_07()
        {
            // To pritn ASCII Value 
            Console.Write("Nhap mot ky tu: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int ascii = (int)input;
            Console.WriteLine($"Gia tri cua {input} trong bang ma ASCII la {ascii}");
        }
        public static void Session01_08()
        {
            //To calculate area of circle
            Console.Write("Nhap ban kinh hinh tron: ");
            float x = float.Parse(Console.ReadLine());
            double dientich = x * x * 3.14;
            Console.Write($"Dien tich hinh tron la: {dientich}");
        }
        public static void Session01_09()
        {
            //To calculate area of square
            Console.Write("Nhap ban kinh hinh vuong: ");
            float x = float.Parse(Console.ReadLine());
            double dientich = x * x;
            Console.Write($"Dien tich hinh vuong la: {dientich}");
        }
        public static void Session01_10()
        {
            string ket_qua = "";
            int n;
            Console.Write("Nhap so ngay : ");
            n = Convert.ToInt32(Console.ReadLine());
            int nam = n / 365;
            if (nam != 0)
            {
                ket_qua += nam.ToString();
                ket_qua += " nam ";
            }

            int tuan = (n - nam * 365) / 7;
            if (tuan != 0)
            {
                ket_qua += tuan.ToString();
                ket_qua += " tuan ";
            }

            int ngay = (n - nam * 365) % 7;
            if (ngay != 0)
            {
                ket_qua += ngay.ToString();
                ket_qua += " ngay.";
            }

            Console.Write(ket_qua);

        }
    }
}

