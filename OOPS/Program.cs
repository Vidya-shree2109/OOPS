using OOPS.InventoryDataManagement;
using System;
namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome To Food Grains Program----------\n");
            const string INVENTORY_DATA_PATH = @"E:\PracticeProblems\OOPS\OOPS\OOPS\InventoryDataManagement\Inventory.json";
            InventoryManagement foodGrains = new InventoryManagement();
            bool check = true;
            while (check)
            {
                Console.WriteLine("\nEnter\n1.Display\n2.End the program\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Display Info of food grains -->\n");
                        foodGrains.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 2:
                        check=false;
                        Console.WriteLine("\nProgram Ended !");
                        break;
                }
            }
        }
    }
}