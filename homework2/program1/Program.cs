using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {

            AnotherWay();

            Console.WriteLine("请输入一个整数：");
            string s = Console.ReadLine();
            int number = Int32.Parse(s);
            Console.WriteLine("该整数的素数因子有：");
            for(int i = 2;i<number;i++)
            {
                //先求所有小于number的素数
                bool prime = true;
                for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(prime)
                {
                    if(0==number%i)//判断这些素数里哪些是number的因子
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
        static void AnotherWay()
        {
           //输出包括次方
            Console.WriteLine("请输入一个整数：");
            string s =Console.ReadLine();
            int number = Int32.Parse(s);
            int temp = number;
            Console.WriteLine("该整数的素数因子有：");
            int i = 2;
            while (temp >= i)//temp小于除数（待选因子）时结束循环
            {
                if (temp % i == 0)
                {
                    Console.WriteLine(i);
                    temp = temp/ i;
                }
                else
                    i++;
            }
            if (temp != 1)
                Console.WriteLine(temp); 
        }
    }
}
