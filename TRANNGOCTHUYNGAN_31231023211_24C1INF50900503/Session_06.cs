using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANNGOCTHUYNGAN_31231023211_24C1INF50900503
{
    internal class Session_06
    {
        public static void Main9()
        {
            //ss();
            change();

            Console.ReadKey();
        }
        public static void Session06_01()
        {
            //Enter item values for this array
            Console.Write("Nhap vao N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao phan tu: ");
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter a number: ");

            }
        }
        public static void ss()
        {
            int[] a = { 3, 5, 7 };
            foreach (int item in a)
            {
                Console.WriteLine($"{item}, ");
            }
        }
        public static void change()
        {
            int[] a = { 3, 5, 7 };
            for (int i = 0; i < a.Length; i++)
            {
                a[i]++;
                Console.WriteLine($"{a[i]}, ");
            }
        }

    }
}
