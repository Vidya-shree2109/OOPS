using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.StockAccountManagement
{
    public class StockManagement
    {
        public void DisplayStockDetails(string path)
        {
            using StreamReader reader = new StreamReader(path);
            {
                var jsonFile = reader.ReadToEnd();
                var stock = JsonConvert.DeserializeObject<List<StockData>>(jsonFile);
                Console.WriteLine("-----WELCOME TO STOCK MANAGEMENT-----\n");
                Console.WriteLine("STOCK NAME" + "\t" + "STOCK" + "\t" + "PRICE"  + "\t" + "NUMBER OF SHARES\n");
                foreach (StockData data in stock)
                {
                    Console.WriteLine(data.StockName + "\t\t" + data.StockPrice + "\t" + data.NumOfShares + "\t\t" + (data.StockPrice * data.NumOfShares));
                }
            }
        }
    }
}
