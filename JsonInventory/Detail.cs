﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace JsonInventory
{
    public class Detail
    {

        public void GetData()
        {
            var json = File.ReadAllText(@"C:\Users\Milind\Documents\JSON_File_Invantory\JsonInventory");
            var jObject = JObject.Parse(json);
            var ProdectsArray = (JArray)jObject["Prodects"];
            if (jObject != null)
            {
                Console.WriteLine("Prodects");
                foreach (var item in ProdectsArray)
                {
                    Console.WriteLine($"Name:" + (item["Name"]));
                    Console.WriteLine($"Weight:" + (item["Weight"]));
                    Console.WriteLine($"price:" + (item["Price_per_kg"]));
                    Price(item["Weight"], item["Price_per_kg"]);
                    Console.WriteLine();
                }
            }

        }
        public void Price(JToken Weight, JToken Price_per_kg)
        {
            int weight = Weight.ToObject<int>();
            int price = Price_per_kg.ToObject<int>();
            int total = weight * price;
            Console.WriteLine("Total value of the iteam is" + total);
        }
    }

}
