using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: "); 
            int n = Convert.ToInt32(Console.ReadLine()); 
            
            int result;
            if (n > 123)
                result = Math.Abs((n - 123) * 3); 
            else
                result = Math.Abs(123 - n); 
            Console.WriteLine(result);
        }
    }
}
