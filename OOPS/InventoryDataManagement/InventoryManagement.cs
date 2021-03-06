using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace OOPS.InventoryDataManagement
{
    public class InventoryManagement
    {
        public void DisplayInventory(string filePath)
        {
            using (StreamReader reader= new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                Console.WriteLine("Name" + "\t" + "Price" + "\t" + "Weight" + "\t" + "TotalPrice\n");
                foreach(var data in inventory)
                {
                    Console.WriteLine(data.Name + "\t" + data.Price + "\t" + data.Weight + "\t" + (data.Weight * data.Price));
                }
            }
        }
    }
}