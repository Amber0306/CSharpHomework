using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Rectangle:Shape
    {
        //具体产品
        private int myWidth;
        private int myHeight;

        public  override void SetParameters(int width, int height)
        {
            this.myWidth = width;
             this.myHeight = height;
        }

        public override double Area
        {
            get
            {
                return myWidth*myHeight;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
