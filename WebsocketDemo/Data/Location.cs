using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsocketDemo.Data
{
    public class Location
    {
        public string type { get; set; }

        public double[] coordinates { get; set; }
    }
}
