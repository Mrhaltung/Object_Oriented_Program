using System;

namespace InventoryDataManagement
{
    public class InventoryFactory
    {
        public static void InventoryFactories()
        {
            Console.Write("Enter the name of Item : ");
            char a = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the name of Weight : ");
            int b = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the name of Price : ");
            int c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\n ---------------------------------------------------------- \n");

            Console.WriteLine("Name : " + a + "\n Weight : " + b + "\n Price : " + c);

            int value = b * c;

            Console.WriteLine("\n Value of the Item : " + value);

        }
    }
}