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
            //测试
            OrderService service = new OrderService();

            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            Order myOrder02 = service.AddOrder("02", "Mike");

            try
            {
                //给订单添加条目(商品)
                myOrder01.AddProduct("apple");
                myOrder01.AddProduct("beer");
                myOrder02.AddProduct("banana");

                //修改订单中的内容 
                myOrder01.ChangeProduct("apple", "number", 12);//使apple的数量变为12
                myOrder01.ChangeProduct("apple", "price", 5);//使apple单价变为5
                myOrder01.ChangeProduct("beer", "number", 3);
                myOrder01.ChangeProduct("beer", "price", 25);
                myOrder02.AddProduct("banana");//再增加一个banana
                myOrder02.ChangeProduct("banana", "price", 7);

                //显示订单内容
                myOrder01.ShowOrder();
                myOrder02.ShowOrder();

                //按照客户名字查找订单
                Order myOrder = service.FindOrderByCustomer("Mike");
                myOrder.ShowOrder();//查找后输出

                //删除订单
                service.DeleteOrder(myOrder01);
                service.DeleteOrder(myOrder02);

            }catch(MyException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("操作失败！");
            }
        }
    }
}
