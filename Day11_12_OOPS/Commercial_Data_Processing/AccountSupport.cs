﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commercial_Data_Processing
{
    class AccountSupport
    {
        public List<Account> AccountList { get; set; }

        public class Account
        {
            public string Stockholder { get; set; }
            public string StockName { get; set; }
            public int shares { get; set; }
            public int Price { get; set; }
        }
    }
}
