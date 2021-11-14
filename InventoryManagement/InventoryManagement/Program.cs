using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "D:/Program/inventory.json";
            Console.WriteLine("Welcome to the Inventory Data Management.!!!");

            ReadInventoryData readInventoryData = new ReadInventoryData();
            InventoryManagement data = readInventoryData.Read(Path);

            for (int i = 0; i < data.Rice.Count; i++)
            {
                Console.WriteLine("Rice Details");
                int valueofRice = data.Rice[i].weight * data.Rice[i].price;
                Console.WriteLine("The value of {0} is {1}", data.Rice[i].name, valueofRice);
                Console.WriteLine("---------------------------------------------------------");
            }


            for (int i = 0; i < data.Pulses.Count; i++)
            {
                Console.WriteLine("Pulses Details");
                int valueofPulses = data.Pulses[i].weight * data.Pulses[i].price;
                Console.WriteLine("The value of {0} is {1}", data.Pulses[i].name, valueofPulses);
                Console.WriteLine("---------------------------------------------------------");
            }


            for (int i = 0; i < data.Wheat.Count; i++)
            {
                Console.WriteLine("Wheat Details");
                int valueofWheat = data.Wheat[i].weight * data.Wheat[i].price;
                Console.WriteLine("The value of {0} is {1}", data.Wheat[i].name, valueofWheat);
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}
