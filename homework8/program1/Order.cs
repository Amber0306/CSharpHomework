using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    [Serializable]
    public class Order
    {

        public string id { get; set; }//订单号
        public string customer { get; set; }//客户名字
        public string phone { get; set; }//客户电话号码
        public int sum { get; set; }//订单总额

        public Order() { }
        public Order(string id, string name,string phone)
        {
            this.id = id;
            this.customer = name;
            this.phone = phone;
        }

        //一个order里面有多个条目组成一个完整的订单
        public List<OrderDetail> orderdata = new List<OrderDetail>();

        //计算订单总额
        public int GetSum()
        {
            int sum = 0;
            foreach (OrderDetail d in orderdata)
            {
                sum += d.pdtNumber * d.pdtPrice;
            }
            this.sum = sum;
            return sum;
        }

        //增加商品
        //先查看订单中是否已有该种商品，如果有，则该商品数量增加
        //如果没有，则商品种类加一，该商品数量增加
        public bool AddProduct(string newpdt)
        {
            bool IsExistSame = false;
            foreach (OrderDetail product in orderdata)
            {
                if (product.pdtName == newpdt)
                {
                    product.pdtNumber++;
                    IsExistSame = true;
                }
            }
            if (IsExistSame == false)
            {
                OrderDetail product = new OrderDetail(newpdt, 0);
                orderdata.Add(product);
            }
            return IsExistSame;
        }

        //删除商品
        public bool DeleteProductOrderDataList(OrderDetail product)
        {
            int idx = orderdata.IndexOf(product);
            if (idx < 0) return false;
            orderdata.Remove(product);
            return true;

        }

        //改变某种商品的数量或单价
        public OrderDetail ChangeProduct(string pdt, string type, int num)
        {
            foreach (OrderDetail product in orderdata)
            {
                if (product.pdtName == pdt)
                {
                    if ("number" == type)
                    {
                        product.pdtNumber = num;
                        return product;
                    }
                    else if ("price" == type)
                    {
                        product.pdtPrice = num;
                        return product;
                    }
                    else
                    {
                        throw new MyException("错误：无法修改！");
                    }
                }
            }
            return null;
        }

        //输出订单信息
        public void ShowOrder()
        {
            Console.WriteLine('\n');
            Console.WriteLine("订单号：" + this.id);
            Console.WriteLine("客户名：" + this.customer);
            Console.WriteLine("客户电话号码："+this.phone);
            Console.WriteLine("商品名" + '\t' + "数量" + '\t' + "价格");
            foreach (OrderDetail product in this.orderdata)
            {
                Console.WriteLine(product.pdtName + '\t' + product.pdtNumber + '\t' + product.pdtPrice);
            }
            Console.WriteLine('\n');
        }
    }
}