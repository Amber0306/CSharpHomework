using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Circle: Shape
    {
        //具体产品
        private int myRadius;
  
        public override double Area
        {
            get
            {
                return myRadius * myRadius * System.Math.PI;
            }
        }

        public override void SetParameters(int radius,int b=0)
        {
            this.myRadius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
