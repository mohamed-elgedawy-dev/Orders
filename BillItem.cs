﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    internal class BillItem
    {
        public string? ProductName { get; set; }

        public int Amount { get; set; }


        public string? CustomerName { get; set; }

        public decimal Price { get; set; }


        public decimal Total { get; set; }

        public int GrandTotal { get; set; } 


    }
}
