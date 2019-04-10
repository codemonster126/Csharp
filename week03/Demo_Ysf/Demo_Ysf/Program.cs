using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ysf
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 2;
            int z;
            z = x + 3 * 2 ^ y + 10 % (x * 2);
            System.Console.WriteLine("{0}",2^2); // ^ 为按位异或运算符
            System.Console.WriteLine("z={0}",z); //结果为9

            bool b = (!(x > 3) || y > 1) && 6 != 7;
            Console.WriteLine("b={0}",b);
            System.Console.ReadKey();


        }
    }
}
