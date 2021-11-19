using System;
using System.Linq;

namespace Stock_Account_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Program/share.json";
            Console.WriteLine(" Welcome to Stock Management ");

            StockData stockData = new StockData();
            StockManagement data = stockData.Read(path);

            for (int i = 0; i < data.Stock.Count; i++)
            {
                Console.WriteLine("Rice Details");
                Console.WriteLine("Name : " + data.Stock[i].StockName + " Quality : " + data.Stock[i].quatity + " Price : " + data.Stock[i].price);
                int total = (int)(data.Stock[i].quatity * data.Stock[i].price);
                Console.WriteLine("\n Total Share Price : " + total);
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}
