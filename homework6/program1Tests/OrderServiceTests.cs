using Microsoft.VisualStudio.TestTools.UnitTesting;
using program2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");

            List<Order> result = new List<Order>();
            result.Add(myOrder01);
            Assert.AreEqual(service.orderList[0], result[0]);
            Assert.IsTrue(service.orderList.Count == 1);
        }

        [ExpectedException(typeof(MyException))]
        [TestMethod()]
        public void AddOrderTest1()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            //重复添加订单（订单编号相同）
            service.AddOrder("01", "Lily");
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            //删除订单
            service.DeleteOrder(myOrder01);

            Assert.IsTrue(service.orderList.Count == 0);
        }

        [ExpectedException(typeof(MyException))]
        [TestMethod()]
        public void DeleteOrderTest1()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            //删除订单
            service.DeleteOrder(myOrder01);
            //重复删除，删除原本不存在的订单
            service.DeleteOrder(myOrder01);
        }

        [TestMethod()]
        public void FindOrderByIdTest()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            Order result = service.FindOrderById("01");

            Assert.AreEqual(myOrder01, result);
        }

        [TestMethod()]
        public void FindOrderByProductTest()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            //给订单添加条目(商品)
            myOrder01.AddProduct("apple");
            List<Order> result = service.FindOrderByProduct("apple");

            Assert.AreEqual(myOrder01, result[0]);
        }

        [TestMethod()]
        public void FindOrderByCustomerTest()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            List<Order> result = service.FindOrderByCustomer("Lily");

            Assert.AreEqual(myOrder01, result[0]);
        }

        [TestMethod()]
        public void FindOrderOverWanTest()
        {
            //测试
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            Order myOrder02 = service.AddOrder("02", "Mike");
            //给订单添加条目(商品)
            myOrder01.AddProduct("apple");
            myOrder01.AddProduct("sofa");
            myOrder02.AddProduct("banana");
            //修改订单中的内容 
            myOrder01.ChangeProduct("apple", "number", 12);//使apple的数量变为12
            myOrder01.ChangeProduct("apple", "price", 5);//使apple单价变为5
            myOrder01.ChangeProduct("sofa", "number", 3);
            myOrder01.ChangeProduct("sofa", "price", 5000);

            List<Order> result = service.FindOrderOverWan();

            Assert.AreEqual(myOrder01, result[0]);
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            service.Export();
            Assert.AreEqual(service.Export(), "orders.xml");
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService service = new OrderService();
            //添加订单
            Order myOrder01 = service.AddOrder("01", "Lily");
            string fileName = service.Export();
            bool result = service.Import(fileName);

            Assert.IsTrue(result);
        }

       // [ExpectedException(typeof(MyException))]
        [TestMethod()]
        [ExpectedException(typeof(MyException))]
        public void ImportTest1()
        {
            OrderService service = new OrderService();
            service.Import("test.xml");
        }
    }
}