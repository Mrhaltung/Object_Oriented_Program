using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "C:\Users\lenovo\Source\Repos\Object_Oriented_Program\inventory.json";
            Console.WriteLine("Welcome to the Inventory Data Management.!!!");

            ReadInventoryData readInventoryData = new ReadInventoryData();
            InventoryManagement data = readInventoryData.Read(Path);

            for (int i = 0; i < data.Rice.Count; i++)
            {
                Console.WriteLine("Rice Details");
                Console.WriteLine("Name : " + data.Rice[i].name + " Weight : " + data.Rice[i].weight + " Price : " + data.Rice[i].price);
                Console.WriteLine("---------------------------------------------------------");
            }


            for (int i = 0; i < data.Pulses.Count; i++)
            {
                Console.WriteLine("Pulses Details");
                Console.WriteLine("Name : " + data.Pulses[i].name + " Weight : " + data.Pulses[i].weight + " Price : " + data.Pulses[i].price);
                Console.WriteLine("---------------------------------------------------------");
            }


            for (int i = 0; i < data.Wheat.Count; i++)
            {
                Console.WriteLine("Wheat Details");
                Console.WriteLine("Name : " + data.Wheat[i].name + " Weight : " + data.Wheat[i].weight + " Price : " + data.Wheat[i].price);
                Console.WriteLine("---------------------------------------------------------");
            }

            Console.Write("If you want to give details press Y. : ");
            char ch = Convert.ToChar(Console.ReadLine());
            var consent = ch;

            while (consent == 'y' || consent == 'Y')
            {
                InventoryFactory.InventoryFactories();
            }
        }
    }
}
