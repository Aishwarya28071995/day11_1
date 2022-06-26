using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class InventoryFactory
    {
        
            public String name;
            public int weight;
            public int price;


            public InventoryFactory(String name, int weight, int price)
            {
                this.name = name;
                this.weight = weight;
                this.price = price;
                // Console.WriteLine(name+weight+price);
            }

        public static void CalculateValue(List<InventoryFactory> list)
        {
            foreach (InventoryFactory item in list)
            {
                float weight = item.weight;
                float price = item.price;
                float value = weight * price;
                Console.WriteLine("Total value of item is " + value);
            }


        }

    }
}
