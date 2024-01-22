using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace практ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z; char d;
            Console.WriteLine("Введите первое число");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак +,-,*,/");
            d=Convert.ToChar(Console.ReadLine());
            try
            {
                switch (d)
                {
                    case '+': z = x + y; Console.WriteLine("Сумма =" + z); break;
                    case '-': z = x - y; Console.WriteLine("Разность =" + z); break;
                    case '*': z = x * y; Console.WriteLine("Произведение =" + z); break;
                    case '/': z = x / y; Console.WriteLine("Частное =" + z); break;
                    default: Console.WriteLine("Нет такого действия!"); break;
                }
            } 
            catch (DivideByZeroException) { Console.WriteLine("Деление на 0!"); }

            Console.ReadKey();
        }
    }
}
