using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class InventoryManager
    {
        public void getObject()
        {
            List<InventoryFactory> list = new List<InventoryFactory>()
            {
                new InventoryFactory("rice", 2, 200),
               new InventoryFactory("wheat", 2, 150),
             };
            foreach (InventoryFactory item in list)
            {
                Console.WriteLine(item.name);
            }

            var deserializeobject = "[{ \"name\":\"rice\",\"weight\":2,\"price\":200},{ \"name\":\"wheat\",\"weight\":2,\"price\":150}]";

            //var value = JsonConvert.SerializeObject(list);

            List<InventoryFactory> inventories = JsonConvert.DeserializeObject<List<InventoryFactory>>(deserializeobject);

            InventoryFactory.CalculateValue(inventories);
        }
    }
}