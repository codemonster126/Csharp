using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("int的字节数:{0},真实数据类型{1},数据范围为{2}--{3}",sizeof(int),typeof(int),int.MinValue,int.MaxValue);
            System.Console.WriteLine("long的字节数:{0},真实数据类型{1},数据范围为{2}--{3}", sizeof(long), typeof(long), long.MinValue, long.MaxValue);
            System.Console.WriteLine("char的字节数:{0},真实数据类型{1},数据范围为{2}--{3}", sizeof(char), typeof(char), char.MinValue, char.MaxValue);
            System.Console.WriteLine("float的字节数:{0},真实数据类型{1},数据范围为{2}--{3}", sizeof(float), typeof(float), float.MinValue, float.MaxValue);
            System.Console.WriteLine("double的字节数:{0},真实数据类型{1},数据范围为{2}--{3}", sizeof(double), typeof(double), double.MinValue, double.MaxValue);
            System.Console.WriteLine("bool的字节数:{0},真实数据类型{1}", sizeof(bool), typeof(bool));
            Student stu;
            stu = new Student();
            stu.SetSex(Student.Studentsex.female);
            System.Console.WriteLine(stu.sex);
            System.Console.ReadKey();
        }
        
    }
    class Student
    {
        public enum Studentsex
        {
            male, female
        }
        public String name;
        public Studentsex sex;
        public void SetName(){

        }
        public void SetSex(Studentsex sex){

            this.sex = sex;
        }
    }
}
