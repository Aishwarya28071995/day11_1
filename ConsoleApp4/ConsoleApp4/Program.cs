using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Inventory> list = new List<Inventory>()
            {
                new Inventory("rice", 2, 200),
               new Inventory("wheat", 2, 150),
             };
            foreach(Inventory item in list)
            {
                Console.WriteLine(item.name);
            }

            var deserializeobject = "[{ \"name\":\"rice\",\"weight\":2,\"price\":200},{ \"name\":\"wheat\",\"weight\":2,\"price\":150}]";

            //var value = JsonConvert.SerializeObject(list);

            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(deserializeobject);

            Inventory.CalculateValue(inventories);
            

        }

        public class Inventory
        {
            public String name;
            public int weight;
            public int price;

            
            public Inventory(String name,int weight,int price)
            {
                this.name = name;
                this.weight = weight;
                this.price = price;
               // Console.WriteLine(name+weight+price);
            }

            public static void CalculateValue(List<Inventory> list)
            {
                foreach(Inventory item in list)
                {
                    float weight = item.weight;
                    float price = item.price;
                    float value = weight * price;
                    Console.WriteLine("Total value of item is "+value);
                }


            }
        }
    }
}
