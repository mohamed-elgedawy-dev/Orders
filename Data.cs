﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Orders
{
    internal class Data
    {

        
        public string filePath { get; } = "products.json";


        public List<Product> Products { get; set; } = new List<Product>();



        public Data()
        {

            string json = File.ReadAllText(filePath);
            Products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

    }
}
