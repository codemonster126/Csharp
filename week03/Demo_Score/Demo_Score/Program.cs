using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int csharp = 70, java = 60, sql = 39;
            int x_fx = csharp - sql;
            int avg = (csharp + java + sql) / 3;
            System.Console.WriteLine("====================================");
            System.Console.WriteLine("\tC#\tJava\tSQL");
            System.Console.WriteLine("\t{0}\t{1}\t{2}",csharp,java,sql);
            System.Console.WriteLine("====================================");
            System.Console.WriteLine("C#和SQL课程的成绩分差：{0}",x_fx);
            System.Console.WriteLine("三门课程的平均分为：{0}",avg);
            System.Console.ReadKey();
        }
    }
}
