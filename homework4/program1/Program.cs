using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    
        public class UseClock
        {
            static void Main(string[] args)
            {
                var clock = new Clock();
                //注册事件
                clock.ClockGoOff += ShowTime;
                clock.SetClock();
            }
             //事件处理方法
             static void ShowTime(object sender,ClockEventArgs e)
             {
                  Console.WriteLine("The time now is "+e.clocktime);
                  Console.WriteLine("The clock goes off!");
              }
        }
 
}
