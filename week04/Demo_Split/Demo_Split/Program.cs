using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "男人，女人，好人，坏人，圣人，";
            int[] x = {1,2,3};
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x[i]);

            string[] sList = str.Split('，');

            for (int i = 0; i < sList.Length; i++)
                Console.WriteLine(sList[i].Replace("人",""));
            

            Console.ReadKey();

        }
    }
}
