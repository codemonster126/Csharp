using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine("交换之前的数据：");
            Console.WriteLine("x={0},y={1}",x,y);

            SwapByValue(x, y); 
            Console.WriteLine("调用SWapByValue(x,y);函数之后的数据：");
            Console.WriteLine("x={0},y={1}", x, y);//并没有交换x,y的值

            SwapByRef(ref x, ref y);
            Console.WriteLine("调用SWapByRef(ref x,ref y);函数之后的数据：");
            Console.WriteLine("x={0},y={1}", x, y);//已经交换了x,y的值

            Console.ReadKey();
        }

        public static void SwapByValue(int a, int b) //a,b为值类型参数
        {
            int t = a;
            a = b;
            b = t;
        }
        public static void SwapByRef(ref int a, ref int b)//a,b为引用类型参数
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
