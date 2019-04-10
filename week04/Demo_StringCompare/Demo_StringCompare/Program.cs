using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc";
            string str2 = "Abc";
            Console.WriteLine("str1==str2的结果为：{0}",str1==str2);
            Console.WriteLine("str1.Equals(str2)的结果为：{0}", str1.Equals(str2));
            Console.WriteLine("str1.CompareTo(str2)的结果为：{0}", str1.CompareTo(str2));
            Console.WriteLine("string.Compare(str1,str2)的结果为：{0}", string.Compare(str1, str2));

            Console.WriteLine("string.Compare(str1,str2,true)的结果为：{0}", string.Compare(str1, str2,true));//比较是不区分字符大小写

            Console.WriteLine("str1.ToLower()==str2.ToLower()的结果为：{0}",str1.ToLower()==str2.ToLower());//先转换为小写再比较

            string str = "中国是china";

            string ss = str.Insert(2, "人民");
            Console.WriteLine("ss={0}", ss);

            ss = "abc" + str;

            Console.WriteLine("ss={0}",ss);

            ss = str.Replace("国","华人民共和国");

            Console.WriteLine("ss={0}", ss);

            ss = str.Remove(2,1);
            Console.WriteLine("ss={0}", ss);

            str = "小宇飞刀";
            str1 = str.PadLeft(3, '【');
            ss = str1.PadRight(6, '】');
            ss = ""; 

            ss = ss.PadRight(100, 'a');

            Console.WriteLine("ss={0}", ss);

            ss = "abc\tdef\tghi\rjkl";

            Console.WriteLine("ss={0}", ss);

            str = "小宇飞刀的网名为xieyunc";
            ss = str.Substring(5, 2);
            Console.WriteLine("ss={0}", ss);

            str = "xieyunc@qq.com";
            int i = str.IndexOf('@');
            ss = str.Substring(0, i);
            Console.WriteLine("ss={0}", ss);

            str = null;
            //if (str == null || str == "")
            //if (string.IsNullOrEmpty(str))
            //if (str.Equals(string.Empty))
            Console.ReadKey();
        }
    }
}
