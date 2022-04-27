using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS.InventoryDataManagement;

namespace OOPS.ExtendedInventoryManagement
{
    public class InventoryFactory
    {
        public InventoryDetails ReadJson(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<InventoryDetails>(json);
                return inventory;
            }
        }
        public void WriteToJson(string filePath, InventoryDetails details)
        {
            var serializeJson = JsonConvert.SerializeObject(details);
            File.WriteAllText(filePath, serializeJson);
        }
    }
}