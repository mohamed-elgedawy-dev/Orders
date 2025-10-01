using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Orders
{
    internal class BillSave
    {
        private Bill bill;
        public BillSave()
        {
            
        }
        public BillSave(List<BillItem> list)
        {
            string customerName = list[0].CustomerName ?? "Unknown";

            
            string fileName = $"{customerName}.json";


            string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });

            
            File.WriteAllText(fileName, json);



        }

     
    }
}
