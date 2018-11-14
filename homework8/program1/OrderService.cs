using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System.Text.RegularExpressions;

namespace Program1
{
    public class OrderService
    {
        //订单数据
        //存储多个订单
        public List<Order> orderList = new List<Order>();

        //添加订单
        public Order AddOrder(string id, string customer,string phone)
        {
            //判断订单号是否重复
            var order = from order0 in orderList select order0;
            bool IsExistance = false;
            foreach (var order0 in order)
            {
                if (order0.id == id)
                {
                    IsExistance = true;
                    throw new MyException("该订单已存在！订单号不能重复！");
                }
                else
                {
                    IsExistance = false;
                }
            }
            //订单号不重复可以新建订单
            if (IsExistance == false)
            {
                //判断订单号是否为空
                //确定模式串
                Regex rxId = new Regex("((([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})" +
                    //判断年份：0001-9999
                    "(((0[13578]|1[02])(0[1-9]|[12][0-9]|3[01]))|" +
                    //判断月份：1、3、5、7、8、10、12都是1-31日
                    "((0[469]|11)(0[1-9]|[12][0-9]|30))|" +
                    //判断月份：4、6、9、11都是1-30日
                    "(02(0[1-9]|[1][0-9]|2[0-8]))))|" +
                    //不是闰年：2月1-28日
                    //判断闰年
                    "((([0-9]{2})(0[48]|[2468][048]|[13579][26])|" +
                    //能被4整除但不能被400整除的年份
                    "((0[48]|[2468][048]|[3579][26])00))" +
                    //能被400整除的年份
                    "0229))" +
                    //2月份有29日
                    "([0-9]{3})");
                Regex rxPhone = new Regex("^1[0-9]{10}$");
                //判断是否匹配
                bool IsId = rxId.IsMatch(id);
                bool IsPhone = rxPhone.IsMatch(phone);
                if((""!=id)&&(IsId)&&(IsPhone))
                {
                    Order myOrder = new Order(id, customer,phone);
                    orderList.Add(myOrder);
                    Console.WriteLine("为" + customer + "新建了一个订单，订单号为" + id);
                    return myOrder;
                }
                else
                {
                    throw new MyException("格式不匹配！");
                }    
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
        //public static string xmlFileName = "orders.xml";
        //将订单序列化为XML文件
        public static void XmlSerialize(XmlSerializer ser, string fileName, object obj)
        {

            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
        public string Export()
        {
            string xmlFileName = "orders.xml";
            XmlSerialize(xmlser, xmlFileName, orderList);

            Console.WriteLine("XML序列化订单：");
            //显示文本
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);
            Console.WriteLine('\n');
            return xmlFileName;
        }

        //将XML文件反序列化为订单
        public static object XmlDeserialize(XmlSerializer xmlser, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            object obj = xmlser.Deserialize(fs);
            fs.Close();
            return obj;
        }
        public bool Import(string xmlFileName)
        {
            if (xmlFileName == "orders.xml")
            {
                Console.WriteLine("从XML文件中载入订单如下：");
                List<Order> orderList2 = XmlDeserialize(xmlser, xmlFileName)
                as List<Order>;
                foreach (Order order in orderList)
                    order.ShowOrder();
                return true;
            }
            else
            {
                throw new MyException("该文件不存在！");
            }
        }

        //将订单导出为HTML文件并在浏览器打开显示
        //使用XSLT转换
        public void ShowExploration()
        {
            try
            {
                Export();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\orders.xml");
                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslTransform xt = new XslTransform();
                xt.Load(@"..\..\XsltFile.xslt");

                FileStream outFileStream = File.OpenWrite(@"..\..\index.html");
                XmlTextWriter writer = new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);

                //调用默认浏览器打开链接
                System.Diagnostics.Process.Start("explorer.exe", @"..\..\index.html");
            }
            catch(XmlException e)
            {
                Console.WriteLine("Xml Exception: "+e.ToString());
            }
           catch(XsltException e)
            {
                Console.WriteLine("XSLT Exception: "+e,ToString());
            }
        }
    }
}

