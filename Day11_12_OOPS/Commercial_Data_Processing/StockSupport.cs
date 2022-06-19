using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commercial_Data_Processing
{
    class StockSupport
    {

        public LinkedList<Stocks> stocksList = new LinkedList<Stocks>();

        public class Stocks
        {
            public string StockName { get; set; }
            public int shares { get; set; }
            public int Price { get; set; }
        }
    }
}
