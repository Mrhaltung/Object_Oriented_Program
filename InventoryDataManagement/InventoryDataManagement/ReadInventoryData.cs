using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace InventoryDataManagement
{
    class ReadInventoryData
    {
        public InventoryManagement Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryManagement>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problem in Getting data {0}", ex);
                    return null;
                }
            }
        }
    }
}
