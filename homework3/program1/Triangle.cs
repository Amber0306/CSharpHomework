using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Triangle:Shape
    {
        //具体产品
        private int myHeight;
        private int myBase;

 
        public override  void SetParameters(int height, int mybase)
        {
            this.myBase = mybase;
            this.myHeight = height;
         }

        public override double Area
        {
            get
            {
                return myHeight * myBase*0.5;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Draw  Triangle" );
        }
    }
}
