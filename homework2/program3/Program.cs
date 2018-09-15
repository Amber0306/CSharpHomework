using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            bool[] prime = new bool[number+1];
            prime[0] = prime[1]= false;//使数组的下标与数值一致
            for(int i=2; i<=number; i++)//初始化
            {
                prime[i] = true;
            }
            //埃式筛法
            for(int i=2; i<=Math.Sqrt(number); i++)//取基数
            {
                for(int j=i; i*j<=number; j++)
                {
                    prime[i * j] = false;//去掉倍数
                }
            }
            //输出
            for(int i=2; i<=number; i++)
            {
                if(prime[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
