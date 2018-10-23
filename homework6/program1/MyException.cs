using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class MyException : ApplicationException
    {
        public MyException(string message) : base(message) { }
    }
}

