using OOPS.InventoryDataManagement;
using OOPS.ExtendedInventoryManagement;
using System;
using OOPS.StockAccountManagement;

namespace OOPS
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------WELCOME TO INVENTORY MANAGEMENT----------\n");
            const string INVENTORY_DATA_PATH = @"E:\PracticeProblems\OOPS\OOPS\OOPS\InventoryDataManagement\Inventory.json";
            InventoryManagement management = new InventoryManagement();
            const string INVENTORY_PATH = @"E:\PracticeProblems\OOPS\OOPS\OOPS\ExtendedInventoryManagement\InventoryList.json";
            InventoryManager extendedInventory = new InventoryManager();
            const string STOCK_PATH = @"E:\PracticeProblems\OOPS\OOPS\OOPS\StockAccountManagement\StockAccount.json";
            StockManagement stockManagement = new StockManagement();
            bool check = true;
            while (check)
            {
                Console.WriteLine("\nEnter\n1.Display\n2.Add data to the Inventory\n3.Edit data in the Inventory\n4.Display Stock Management\n5.End the program\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Display Info of food grains -->\n");
                        management.DisplayInventory(INVENTORY_PATH);
                        break;
                    case 2:
                        Console.WriteLine(" Enter for ADDING data in the Inventory\nInventory Name :");
                        string inventoryNameToAdd = Console.ReadLine();
                        InventoryData data = new InventoryData();
                        Console.WriteLine("Enter the Name, weight and Price :");
                        data.Name = Console.ReadLine();
                        data.Weight = Convert.ToInt32(Console.ReadLine());
                        data.Price = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter for EDITING data in the Inventory\nInventory Name :");
                        string inventoryNameToEdit = Console.ReadLine();
                        InventoryData editData = new InventoryData();
                        editData.Name = Console.ReadLine();
                        editData.Weight = 40;
                        editData.Price = 75;
                        extendedInventory.EditInventory(editData, inventoryNameToEdit, INVENTORY_PATH);
                        break;
                    case 4:
                        Console.WriteLine("Display Info of Stock Management -->\n");
                        stockManagement.DisplayStockDetails(STOCK_PATH);
                        break;
                    case 5:
                        check=false;
                        Console.WriteLine("\nProgram Ended !");
                        break;
                }
            }
        }
    }
}