using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monostate
{
    public class Monostate
    {
        private static int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
    }
}
