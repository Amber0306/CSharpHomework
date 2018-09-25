using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public abstract class Shape//抽象产品
    {
        
        public abstract double Area
        {
            get;//抽象属性：面积
        }

       public virtual void SetParameters(int a,int b=0) { }
       

        public  virtual void Draw()
        {
            Console.WriteLine("Draw Shape: ");
            //虚方法：绘制
        }

    }
}
