using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class
{
    class Program
    {
        public class Student  //引用类型
        {
            private string _Name;//private 字段
            private string _Sex;
            private int _Age;
            private string _Addr;

            public string Name //public 属性，如果没有set方法，则当前属性为只读属性
            {
                get { return _Name; }
                //set { _Name = value; }//value 是set方法中的隐型变量
            }
            public string Sex
            {
                get { return _Sex; }
                set
                {
                    if(value!="男" && value!="女")
                    {
                        Console.WriteLine("Sex属性只能赋值【男】或者【女】。");
                        _Sex = "男";
                    }
                    else
                    {
                        _Sex = value;
                    }
                }
            }

            public int Age
            {
                get { return _Age; }
                set
                {
                    if (value <18 || value > 38)
                    {
                        Console.WriteLine("Age的取值范围为：18~38岁之间。");
                        _Age = 18;
                    }
                    else
                    {
                        _Age = value;
                    }
                }

            }
            public string Addr
            {
                get { return _Addr; }
                set { _Addr = value; }
            }

            public Student(string name, string sex, int age, string addr)
            {
                _Name = name;

                if (sex != "男" && sex != "女")
                {
                    Console.WriteLine("Sex属性只能赋值【男】或者【女】。");
                    _Sex = "男";
                }
                else
                {
                    _Sex = sex;
                }

                _Age = age;
                _Addr = addr;
            }

            public Student()
            {
                _Name = "小宇飞刀";
                _Sex = "";
                _Age = 0;
                _Addr = "";
            }

            public void Show()
            {
                Console.WriteLine("Show()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", _Name, _Sex, _Age, _Addr);
            }
        }
        static void Main(string[] args) //栈
        {
            Student stu = new Student();

            //stu.Name = "小宇飞刀";
            stu.Sex = "中";
            stu.Age = 100;
            stu.Addr = "江西南昌";

            stu.Show();

            Console.WriteLine("Main()方法中显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", stu.Name, stu.Sex, stu.Age, stu.Addr);

            Student stu2 = new Student("xieyunc", "man", 33, "中国北京");
            stu2.Show();

            Console.WriteLine("Main()方法中显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", stu2.Name, stu2.Sex, stu2.Age, stu2.Addr);


            Console.ReadKey();
        }
    }
}
