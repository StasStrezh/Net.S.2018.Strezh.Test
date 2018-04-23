﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class StockEventArgs : EventArgs
    {
        public int USD { get; set; }
        public int Euro { get; set; }

        public StockEventArgs()
        {

        }

        public StockEventArgs(int usd, int euro)
        {
            USD = usd;
            Euro = euro;
        }
    }
}
