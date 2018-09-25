using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class ShapeFactory
    {
        //静态工厂方法
        public static Shape GetShape(string type)
        {
            Shape shape = null;
            if(type =="Triangle")
            {
                shape = new Triangle();
            }
            else if(type =="Square")
            {
                shape = new Square();
            }
            else if(type == "Circle")
            {
                shape = new Circle();
            }
            else if(type == "Rectangle")
            {
                shape = new Rectangle();
            }
            return shape;
        }
    }
}
