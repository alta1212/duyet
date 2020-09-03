  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThayHau
{
    class Program
    { 
	 static void Main(string[] args)
        {
            int n;
            Console.Write("Nhập vào các số số nguyên tố cần tìm nhỏ hơn:");
            n = int.Parse(Console.ReadLine());
            bool[] a = new bool[n + 1];
            //Khởi tạo mảng khởi tạo ban đầu đều là số nguyên tố
            for (int i = 2; i <= n; i++)
                a[i] = true;
            //Tìm số nguyên tố
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (a[i])
                {
                    int j = i*i;
                    while (j <= n)
                    {
                        a[j] = false;
                        j += i;
                    }
                }
            }
            Console.WriteLine("Các số nguyên tố là:");
            for (int i = 2; i <= n; i++)
                if (a[i])
                    Console.Write("{0}, ", i);
        }

	   
}