using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    [Serializable]
    public class OrderDetail
    {
        //一个条目
        //商品名称
        public string pdtName { get; set; }//商品名称
        public int pdtNumber { get; set; }//商品数量
        public int pdtPrice { get; set; }//商品单价
        public OrderDetail() { }
        public OrderDetail(string name, int price, int number = 1)
        {
            this.pdtName = name;
            this.pdtNumber = number;
            this.pdtPrice = price;
        }
        public void ShowDetail()
        {
            Console.WriteLine("商品名称：" + this.pdtName);
            Console.WriteLine("商品数量：" + this.pdtNumber);
            Console.WriteLine("商品价格：" + this.pdtPrice);
        }
    }
}
