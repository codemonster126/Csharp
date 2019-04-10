using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enum
{
    class Program
    {
        public enum Mrkj
        {
            csharp, cpp = 5, c, java
        }
        public enum SEX
        {
            M,W
        }
        public class Student
        {
            public string Name = "xieyunc";
            public SEX Sex = SEX.M;
            public int Age = 18;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Mrkj.csharp={0},索引值={1}",Mrkj.csharp,(int)Mrkj.csharp);
            System.Console.WriteLine("Mrkj.cpp={0},索引值={1}", Mrkj.cpp, (int)Mrkj.cpp);
            System.Console.WriteLine("Mrkj.c={0},索引值={1}", Mrkj.c, (int)Mrkj.c);
            System.Console.WriteLine("Mrkj.java={0},索引值={1}", Mrkj.java, (int)Mrkj.java);


            Student stu1 = new Student();

            System.Console.WriteLine("stu1中的原始值：{0},{1},{2}",stu1.Name,stu1.Sex,stu1.Age);

            stu1.Name = "小宇飞刀";
            stu1.Sex = SEX.W;
            stu1.Age = 108;

            System.Console.WriteLine("stu1中的更改后的值：{0},{1},{2}", stu1.Name, stu1.Sex, stu1.Age);

            System.Console.ReadKey();

        }
    }
}
