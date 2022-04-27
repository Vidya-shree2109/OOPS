using OOPS.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.ExtendedInventoryManagement
{
    public class InventoryManager
    {
        InventoryManagement inventory = new InventoryManagement();
        InventoryFactory factory = new InventoryFactory();
        List<InventoryManagement> riceList = new List<InventoryManagement>();
        List<InventoryManagement> wheatList = new List<InventoryManagement>();
        List<InventoryManagement> pulsesList = new List<InventoryManagement>();
        public void ReadData(string filePath)
        {
            InventoryDetails details = factory.ReadJson(filePath);
            this.riceList = details.RiceList;
            this.wheatList = details.WheatList;
            this.pulsesList = details.PulsesList;
        }
        public void AddInventory(InventoryManagement data, string inventoryName, string filePath)
        {
            if (inventoryName.Equals("RiceList"))
            {
                riceList.Add(data);
            }
            if (inventoryName.Equals("WheatList"))
            {
                wheatList.Add(data);
            }
            if (inventoryName.Equals("PulsesList"))
            {
                pulsesList.Add(data);
            }
            SaveInventory(filePath);

        }
        public void SaveInventory(string filePath)
        {
            InventoryDetails details = new InventoryDetails();
            details.RiceList = riceList;
            details.WheatList = wheatList;
            details.PulsesList = pulsesList;
            factory.WriteToJson(filePath, details);
            inventory.DisplayInventory(filePath);
        }
        public void EditInventory(InventoryData data1, string inventoryName, string filePath)
        {
            ReadData(filePath);
            InventoryData inventory = new InventoryData();
            if (inventoryName.Equals("Rice"))
            {
                foreach (InventoryManagement data in riceList)
                {
                    if (data.Equals(data1))
                    {
                        Console.WriteLine("Enter to edit RICE details :\n1.Name\n2.Price\n3.Weight\n");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("Wheat"))
            {
                foreach (InventoryManagement data in wheatList)
                {
                    if (data.Equals(data1))
                    {
                        Console.WriteLine("Enter to edit WHEAT details :\n1.Name\n2.Price\n3.Weight\n");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("Pulses"))
            {
                foreach (InventoryManagement data in pulsesList)
                {
                    if (data.Equals(data1))
                    {
                        Console.WriteLine("Enter to edit PULSES details :\n1.Name\n2.Price\n3.Weight\n");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            SaveInventory(filePath);
        }
    }
}