using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("char类型原型为{0},占用字节数{1},取值范围：{2} ~ {3}", typeof(char), sizeof(char), char.MinValue, char.MaxValue);
            System.Console.WriteLine("int类型原型为{0},占用字节数{1},取值范围：{2} ~ {3}", typeof(int), sizeof(int), int.MinValue, int.MaxValue);
            System.Console.WriteLine("long类型原型为{0},占用字节数{1},取值范围：{2} ~ {3}", typeof(long), sizeof(long), long.MinValue, long.MaxValue);

            int i = 10;
            float f = 10.34F;
            double d = 10.78d;

            long l = 10;

            i = (int)d; //强制类型转换方法一
            //i = Convert.ToInt32(d);//强制类型转换方法一
            //i = int.Parse(d.ToString());

            System.Console.WriteLine("i={0}",i);

            System.Console.ReadKey();
        }
    }
}
