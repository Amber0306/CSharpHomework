using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Square: Shape
    {
        //具体产品
        private int mySide;


        public override void SetParameters(int side,int b=0)
        {
            this.mySide = side;
        }

        public override double Area
        {
            get
            {
                return mySide * mySide;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
}
