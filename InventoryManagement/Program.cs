using System;

namespace InventoryManagement
{
    class Program
    {
        /// <summary>
        /// create the inventory management system using Json and displaying the data
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inventory Management System");
            Inventory.ReadInput();
            Console.ReadLine();
        }
    }
}
