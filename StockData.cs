using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Stock_Account_Management
{
    class StockData
    {
        public StockManagement Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockManagement>(json);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Problem in Getting data {0}", e);
                    return null;
                }
            }
        }
    }
}
