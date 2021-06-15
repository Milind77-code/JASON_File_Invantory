using System;

namespace JsonInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Json Inventory Management");
            Console.WriteLine("Checking Prodects Price");
            Detail Data = new Detail();
            Data.GetData();
        }
    }
}
