using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaiptbac1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap he so a:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap he so b:");
            float b = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                
            
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                float x = -b / a;
                Console.WriteLine("{0}x + {1} = 0 \n => x={2}", a, b, x);
            }
            Console.ReadKey();
        }
    }
}
