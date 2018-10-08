using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    //声明委托类型
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);
    //定义事件源（闹钟）
    public class Clock
    {
        //声明事件
        public event ClockEventHandler ClockGoOff;

        public void SetClock()
        {
            //接收闹钟设定的时间
            Console.WriteLine("Input the clock time: (year,month,day,hour,minute,second)");
            Console.WriteLine("The Clock goes off when the minute comes");
            string s=Console.ReadLine();
            DateTime time1 = DateTime.Parse(s);
            //DateTime time1 = new DateTime(2018, 10, 5, 9, 33, 0);

            //时间到达闹钟时间，发生一个事件，即通知外界
            //闹钟的设定通知时间精确到分钟
            while (ClockGoOff != null)
            {
                if (time1.Minute == DateTime.Now.Minute)
                {
                    ClockEventArgs args = new ClockEventArgs();
                    args.clocktime = DateTime.Now;
                    ClockGoOff(this, args);
                    break;
                }
               else if (time1.Minute < DateTime.Now.Minute)
                {
                    break;
                }
            }
        }
    }
}
