using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取数据
            Console.WriteLine("请输入数组元素个数:");
            string s = Console.ReadLine();
            int length = Int32.Parse(s);
            int [] array = new int[length];
            for(int i = 0;i<length;i++)
            {
                Console.WriteLine("请输入第 "+(i+1)+" 个元素");
                string str = Console.ReadLine();
                array[i] = Int32.Parse(str);
            }
            //从小到大排序
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < length - j - 1; k++)
                {
                    if (array[k] > array[k + 1])
                    {
                        int temp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temp;
                    }
                }
            }
            //输出
            Console.WriteLine("数组的最大值是：");
            Console.WriteLine(array[length-1]);
            Console.WriteLine("数组的最小值是：");
            Console.WriteLine(array[0]);
            double sum = 0;
            for(int i=0;i<length;i++)
            {
                sum += array[i];
            }
            double average = sum / length;
            Console.WriteLine("数组的平均值是：");
            Console.WriteLine(average);
            Console.WriteLine("数组所有元素的和是：");
            Console.WriteLine(sum);
        }
    }
}
