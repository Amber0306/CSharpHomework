using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace program2
{
    public class OrderService
    {
        //订单数据
        //存储多个订单
        public  List<Order> orderList = new List<Order>();

        //添加订单
        public Order AddOrder(string id, string customer)
        {
            var order = from order0 in orderList select order0;
            bool IsExistance = false;
            foreach (var order0 in order)
            {
                if (order0.id == id)
                {
                    IsExistance = true;
                    throw new MyException("该订单已存在！");
                }
                else
                {
                    IsExistance = false;
                }
            }
            if (IsExistance == false)
            {
                Order myOrder = new Order(id, customer);
                orderList.Add(myOrder);
                Console.WriteLine("为" + customer + "新建了一个订单，订单号为" + id);
                return myOrder;
            }
            else
            {
                return null;
            }
        }

        //删除订单
        public bool DeleteOrder(Order order)
        {
            int idx = orderList.IndexOf(order);
            if (idx < 0)
            {
                throw new MyException("无法删除! ");
            }
            else   
            {
                Console.WriteLine("删掉" + order.customer + "的订单！");
                orderList.Remove(order);
                return true;
            }
        }

        //修改订单
        //具体操作在Order类中实现

        //查找订单（按订单号）
        public Order FindOrderById(string num)
        {
            foreach (Order order in orderList)
            {
                if (order.id == num)
                {
                    return order;
                }
            }
            return null;
        }

        //查找订单（按商品名称）
        //public Order FindOrderByProduct(string product)
        //{
        //    foreach (Order order in orderList)
        //    {
        //        foreach (OrderDetail data in order.orderdata)
        //        {
        //            //若订单中存在包含查找的商品，则返回该订单
        //            //（订单中可能不仅仅有该种商品）
        //            if (data.pdtName == product)
        //            {
        //                return order;
        //            }
        //        }
        //    }
        //    return null;
        //}

        //查找订单（按客户）
        //public Order FindOrderByCustomer(string name)
        //{
        //    foreach (Order order in orderList)
        //    {
        //        if (order.customer == name)
        //        {
        //            return order;
        //        }
        //    }
        //    return null;
        //}

        //使用linq语句（1)使用按照商品名称、客户等字段查询订单的功能
        //（2）查询订单金额大于1万元的订单

        //按照商品查询订单
        public List<Order> FindOrderByProduct(string product)
        {
            List<Order> list = new List<Order>();
            var order = from order0 in orderList select order0;
            foreach (var order0 in order)
            {
                var data = from data0 in order0.orderdata
                           where data0.pdtName == product
                           select data0;
                foreach (var data0 in data)
                {
                    data0.ShowDetail();

                    list.Add(order0);
                }
            }
            return list;
        }

        //按照客户查询订单
        public List<Order> FindOrderByCustomer(string name)
        {
            Console.WriteLine("该客户下的订单有：");
            //var query = from order0 in orderList where order0.customer == name select order0;
            var query = orderList.Where(order => order.customer == name);
            return query.ToList();
        }

        //查询总金额大于一万元的订单
        public List<Order> FindOrderOverWan()
        {
            List<Order> list = new List<Order>();
            var order = from order0 in orderList where order0.GetSum() > 10000 select order0;
            int i = 0;
            Console.WriteLine("总额大于一万的订单：");
            foreach (var order0 in order)
            {
                Console.WriteLine("第" + (++i) + "个: ");
                order0.ShowOrder();
                list.Add(order0);
            }
            return list;
        }


        public static XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
        public static string xmlFileName = "orders.xml";
        //将订单序列化为XML文件
        public static void XmlSerialize(XmlSerializer ser, string fileName,object obj)
        {
             
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
        public void Export()
        {
            //XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            //string xmlFileName = "orders.xml";
            XmlSerialize(xmlser, xmlFileName, orderList);

            Console.WriteLine("XML序列化订单：");
            //显示文本
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);
            Console.WriteLine('\n');
        }

        //将XML文件反序列化为订单
        public static object XmlDeserialize(XmlSerializer xmlser,string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            object obj = xmlser.Deserialize(fs);
            fs.Close();
            return obj;
        }
        public void Import()
        {
            Console.WriteLine("从XML文件中载入订单如下：");
            List<Order> orderList2 = XmlDeserialize(xmlser, xmlFileName)
                as List<Order>;
            foreach (Order order in orderList)
                order.ShowOrder();
        }
    }
}

