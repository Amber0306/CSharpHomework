using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService
    {
        //订单数据
        //存储多个订单
        static  List<Order> orderList = new List<Order>();

        //添加订单
        public Order AddOrder(string id,string customer)
        {
            Order order=new Order(id,customer);
            orderList.Add(order);
            Console.WriteLine("为"+customer+"新建了一个订单，订单号为"+id);
            return order;
        }

        //删除订单
        public bool DeleteOrder(Order order)
        {
            int idx = orderList.IndexOf(order);
            if (idx < 0)
            {
                return false;
            }else{
                throw new MyException("无法删除! ");
            }
           
           
            Console.WriteLine("删掉" + order.customer+"的订单！");
            orderList.Remove(order);
            return true;
        }

        //修改订单
        //具体操作在Order类中实现

        //查找订单（按订单号）
        public Order FindOrderById(string num)
        {
            foreach (Order order in orderList)
            {
                if (order.id==num)
                {
                    return order;
                }
            }
            return null;
        }

        //查找订单（按商品名称）
        public Order FindOrderByProduct(string product)
        {
            foreach (Order order in orderList)
            {
                foreach(OrderDetail data in order.orderdata)
                {
                    //若订单中存在包含查找的商品，则返回该订单
                    //（订单中可能不仅仅有该种商品）
                    if (data.pdtName == product)
                    {
                        return order;
                    }
                }
            }
            return null;
        }

        //查找订单（按客户）
        public Order FindOrderByCustomer(string name)
        {
            foreach (Order order in orderList)
            {
                if (order.customer == name)
                {
                    return order;
                }
            }
            return null;
        }

    }
}
