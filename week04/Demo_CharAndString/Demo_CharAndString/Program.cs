using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CharAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test(); //引用类型 
            Test t2 = t1;

            Console.WriteLine("t1.x={0},t1.y={1}",t1.x,t1.y);
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);

            t2.x = 77;
            t2.y = 88;
            Console.WriteLine("t1.x={0},t1.y={1}", t1.x, t1.y);
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);

            double score = 83.5;
            string name = "小宇飞刀";
            string ss = name;


            char sex = '男';
            Console.WriteLine("{0},{1},{2}",name,sex,score);

            ss = "xieyunc";
            Console.WriteLine("{0},{1},{2}", name, sex, score);//此时输出的name 依旧为 小宇飞刀

            Console.ReadKey();
        }
    }
    class Test
    {
        public int x = 10;
        public int y = 20;
    }
}
