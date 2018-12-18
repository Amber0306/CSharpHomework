using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试
            OrderService service = new OrderService();

            //添加订单
            Order myOrder01 = service.AddOrder("20181111001", "Lily", "13245678901");
            Order myOrder02 = service.AddOrder("20181111002", "Mike","15466666666");

            try
            {
                //给订单添加条目(商品)
                myOrder01.AddProduct("apple");
                myOrder01.AddProduct("sofa");
                myOrder02.AddProduct("banana");

                //修改订单中的内容 
                myOrder01.ChangeProduct("apple", "number", 12);//使apple的数量变为12
                myOrder01.ChangeProduct("apple", "price", 5);//使apple单价变为5
                myOrder01.ChangeProduct("sofa", "number", 3);
                myOrder01.ChangeProduct("sofa", "price", 5000);
                myOrder02.AddProduct("banana");//再增加一个banana
                myOrder02.ChangeProduct("banana", "price", 7);

                //显示订单内容
                myOrder01.ShowOrder();
                myOrder02.ShowOrder();

                //按照客户名字查找订单
                List<Order> myOrder = service.FindOrderByCustomer("Mike");
                foreach (Order order in myOrder)
                {
                    order.ShowOrder();
                }

                //service.AddOrder("01","Lily");

                //按照订单中的商品返回订单
                List<Order> pdtOrder = service.FindOrderByProduct("banana");

                //查找总额大于10000的订单
                List<Order> bigOrder = service.FindOrderOverWan();

                ////序列化订单
                //// OrderService.Export();
                //XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
                //string xmlFileName = "orders.xml";
                //OrderService.XmlSerialize(xmlser, xmlFileName, OrderService.orderList);
                //Console.WriteLine("XML序列化订单：");
                ////显示文本
                //string xml = File.ReadAllText(xmlFileName);
                //Console.WriteLine(xml);

                ////反序列化订单
                //List<Order> orderList2 = OrderService.XmlDeserialize(xmlser, xmlFileName)
                //as List<Order>;
                //foreach (Order order in OrderService.orderList)
                //    Console.WriteLine(order);

                //序列化订单
                service.Export();
                //反序列化订单
                service.Import("orders.xml");

                service.ShowExploration();

                //删除订单
                service.DeleteOrder(myOrder01);
                service.DeleteOrder(myOrder02);

            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("操作失败！");
            }
        }
    }
}
