using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            long startTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000;i++ )
            {
                str += i;
            }
            //Console.WriteLine("stirng={0}", str);
            long endTime = DateTime.Now.Millisecond;
            long time = endTime - startTime;
            Console.WriteLine("stirng消耗的时间：{0}ms",time);
            Console.ReadKey();

            StringBuilder str2 = new StringBuilder("");
            startTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            {
                str2.Append(i);
            }
            //Console.WriteLine("StirngBuilder={0}", str2.ToString());
            endTime = DateTime.Now.Millisecond;
            time = endTime - startTime;
            Console.WriteLine("StringBuilder消耗的时间：{0}ms",time);

            Console.ReadKey();
        }
    }
}
