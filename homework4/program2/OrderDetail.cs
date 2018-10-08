using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderDetail
    {
        //一个条目
        //商品名称
        public string pdtName;//商品名称
        public int pdtNumber;//商品数量
        public int pdtPrice;//商品单价
       public OrderDetail(string name,int price,int number= 1)
        {
            this.pdtName = name;
            this.pdtNumber = number;
            this.pdtPrice = price;
        }
    }
}
