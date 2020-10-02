using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите шестизначное число: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 100000 && x <= 999999)
                {
                    if (x / 100000 + x / 10000 % 10 + x / 1000 % 10 == x / 100 % 10 + x / 10 % 10 + x % 10) Console.WriteLine("Число счастливое");
                    else Console.WriteLine("Число не счастливое");
                }
                else Console.WriteLine("Число не является шестизначным");
   
         
                
               


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
