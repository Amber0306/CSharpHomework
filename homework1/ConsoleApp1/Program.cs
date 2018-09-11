using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s1 = "";
            double d1 = 0;
            Console.WriteLine("请输入一个数：");
            s1 = Console.ReadLine();
            d1 = double.Parse(s1);

            string s2 = "";
            double d2 = 0;
            Console.WriteLine("请再输入一个数：");
            s2 = Console.ReadLine();
            d2 = double.Parse(s2);

            Console.WriteLine("两个数字的乘积是："+(d1*d2));

        }
    }
}
