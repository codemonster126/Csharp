using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10; //值类型
            object obj;//引用类型
            obj = i;//装箱
            int x = (int)obj;//拆箱

            System.Console.WriteLine("x={0}",x);
            System.Console.ReadKey();
        }
    }
}
