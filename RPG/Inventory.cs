using System;
using System.Collections.Generic;

namespace OOP_HW.RPG
{
    public class Inventory
    {
        /// <summary>
        /// List of items in inventory
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Maximum capacity of the inventory
        /// </summary>
        private int _capacity;
        /// <summary>
        /// Current occupancy of the inventory
        /// </summary>
        private int _occupancy;
        public Hero Owner { get; set; }





        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        public int Occupancy
        {
            get { return _occupancy; }
            set { _occupancy = value; }
        }





        public Inventory()
        {
            Items = new List<Item>();
            _capacity = 100;
        }





        public void CollectItem(Item item)
        {
            if (OnCollectItem(item))
            {
                Items.Add(item);
                Console.WriteLine($"Item {item.Name} added to Inventory");
                return;
            }
            Console.WriteLine($"Not enough space. Current occupancy: {_occupancy}, " +
                $"Max capacity: {_capacity}, " +
                $"Item {item.Name} weight: {item.Weight}");
        }





        private bool OnCollectItem(Item item)
        {
            if((Occupancy + item.Weight) > Capacity)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}